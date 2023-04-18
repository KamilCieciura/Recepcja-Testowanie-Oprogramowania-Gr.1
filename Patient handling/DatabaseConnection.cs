using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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


        public void LoadPatientsAndDoctorsToComboBoxes(ComboBox cbPatients, ComboBox cbDoctors)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pobieranie pacjentów
                    string queryPatients = "SELECT FirstName, LastName FROM Patients";
                    SqlCommand commandPatients = new SqlCommand(queryPatients, connection);
                    SqlDataReader readerPatients = commandPatients.ExecuteReader();
                    if (readerPatients.HasRows)
                    {
                        while (readerPatients.Read())
                        {
                            string firstName = readerPatients["FirstName"].ToString();
                            string lastName = readerPatients["LastName"].ToString();
                            cbPatients.Items.Add($"{firstName} {lastName}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak danych o pacjentach w bazie danych.");
                    }
                    readerPatients.Close();

                    // Pobieranie doktorów
                    string queryDoctors = "SELECT FirstName, LastName FROM Employees";
                    SqlCommand commandDoctors = new SqlCommand(queryDoctors, connection);
                    SqlDataReader readerDoctors = commandDoctors.ExecuteReader();
                    if (readerDoctors.HasRows)
                    {
                        while (readerDoctors.Read())
                        {
                            string firstName = readerDoctors["FirstName"].ToString();
                            string lastName = readerDoctors["LastName"].ToString();
                            cbDoctors.Items.Add($"{firstName} {lastName}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak danych o doktorach w bazie danych.");
                    }
                    readerDoctors.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych: " + ex.Message);
            }
        }


     




    }
}
