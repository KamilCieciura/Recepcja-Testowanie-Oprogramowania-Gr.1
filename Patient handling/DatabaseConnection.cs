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

                    string query = $"USE testowanie Go SELECT * FROM {tableName}"; // zapytanie SQL do odczytu danych z tabeli
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







    }
}
