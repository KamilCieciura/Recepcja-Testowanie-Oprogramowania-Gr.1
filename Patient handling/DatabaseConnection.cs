﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Patient_handling
{
    public class DatabaseConnection
    {

        private SqlConnection connection;
        private string connectionString;

        public DatabaseConnection()
        {

            connectionString = "Data Source=localhost;Initial Catalog=testowanie;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }

      
        public void LoadDataIntoDataGridView(DataGridView dataGridView, string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {tableName}"; // zapytanie SQL do odczytu danych z tabeli
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
               


                    dataGridView.DataSource = dataTable; // ustawienie źródła danych dla DataGridView

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas odczytu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDataInDatabase(string tableName, string[] columnNames, string[] columnValues, string condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"UPDATE {tableName} SET ";
                    for (int i = 0; i < columnNames.Length; i++)
                    {
                        query += $"{columnNames[i]} = '{columnValues[i]}'";
                        if (i < columnNames.Length - 1)
                        {
                            query += ", ";
                        }
                    }
                    query += $" WHERE {condition};";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dane zostały zaktualizowane.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas aktualizowania danych: " + ex.Message);
            }
        }



        public void InsertDataToDatabase(string tableName, string[] columnNames, string[] columnValues)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) " +
                                   $"VALUES ({string.Join(", ", columnValues.Select(v => $"'{v}'"))})";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dane zostały dodane do bazy danych.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania danych do bazy danych: " + ex.Message);
            }
        }


        public (Dictionary<int, string>, Dictionary<int, string>) LoadPatientsAndDoctorsToComboBoxes(ComboBox cbPatients)
        {
            Dictionary<int, string> patientIdsAndNames = new Dictionary<int, string>();
            Dictionary<int, string> doctorIdsAndNames = new Dictionary<int, string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pobieranie pacjentów
                    string queryPatients = "SELECT Id, FirstName, LastName FROM Patients";
                    SqlCommand commandPatients = new SqlCommand(queryPatients, connection);
                    SqlDataReader readerPatients = commandPatients.ExecuteReader();
                    if (readerPatients.HasRows)
                    {
                        while (readerPatients.Read())
                        {
                            int id = Convert.ToInt32(readerPatients["Id"]);
                            string firstName = readerPatients["FirstName"].ToString();
                            string lastName = readerPatients["LastName"].ToString();
                            cbPatients.Items.Add($"{firstName} {lastName}");
                            patientIdsAndNames.Add(id, $"{firstName} {lastName}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak danych o pacjentach w bazie danych.");
                        return (patientIdsAndNames, doctorIdsAndNames);
                    }
                    readerPatients.Close();

                    // Pobieranie doktorów
                   /* string queryDoctors = "SELECT Id, FirstName, LastName FROM Employees";
                    SqlCommand commandDoctors = new SqlCommand(queryDoctors, connection);
                    SqlDataReader readerDoctors = commandDoctors.ExecuteReader();
                    if (readerDoctors.HasRows)
                    {
                        while (readerDoctors.Read())
                        {
                            int id = Convert.ToInt32(readerDoctors["Id"]);
                            string firstName = readerDoctors["FirstName"].ToString();
                            string lastName = readerDoctors["LastName"].ToString();
                            cbDoctors.Items.Add($"{firstName} {lastName}");
                            doctorIdsAndNames.Add(id, $"{firstName} {lastName}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak danych o doktorach w bazie danych.");
                        return (patientIdsAndNames, doctorIdsAndNames);
                    }
                    readerDoctors.Close();*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych: " + ex.Message);
            }

            return (patientIdsAndNames, doctorIdsAndNames);
        }


        public DataTable FilterData(string tableName, Dictionary<string, string> filters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName}";

                if (filters.Count > 0)
                {
                    query += " WHERE ";
                    query += string.Join(" AND ", filters.Select(f => $"{f.Key} LIKE '{f.Value}'"));
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                connection.Close();

                return dataTable;
            }
        }
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        public int GetPatientId(string patientName)
        {
            // Odseparuj imię i nazwisko pacjenta
            string[] nameParts = patientName.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            // Pobierz id pacjenta z bazy
            int patientId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM Patients WHERE FirstName=@firstName AND LastName=@lastName", connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    patientId = reader.GetInt32(0);
                }

                reader.Close();

            }

            return patientId;
        }

        public int GetDoctorId(string doctorName)
        {
            // Odseparuj imię i nazwisko pacjenta
            string[] nameParts = doctorName.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            // Pobierz id pacjenta z bazy
            int doctorId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM Employees WHERE FirstName=@firstName AND LastName=@lastName", connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    doctorId = reader.GetInt32(0);
                }

                reader.Close();

            }

            return doctorId;
        }








    }
}
