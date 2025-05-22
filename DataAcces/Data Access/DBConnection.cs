using Microsoft.Data.SqlClient;
using Projekt1Semester;
using System;
using System.Data.Common;
using System.Data;
using System.Globalization;

namespace DataAccess
{
    public class DBConnection : RepositoryBase 
    {
       
        public static Ejendomsmaegler? GetRealtor(String username)
        {
            // Start a connection to the database
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();

                // Ensure connection is open
                if (conn.State == System.Data.ConnectionState.Closed)
                    return null;

                // Create command
                var command = conn.CreateCommand();

                // Create select query text
                command.CommandText = "SELECT * FROM ejendomsmæglere WHERE brugernavn = @username";
                command.Parameters.AddWithValue("@username", username);

                // Execute command
                using (var reader = command.ExecuteReader())
                {
                    // We only need to read the first record
                    if (reader.Read())
                    {
                        // Process the data
                        Ejendomsmaegler realtor = new Ejendomsmaegler
                        {
                            // To-do: Update to match final database design
                            EjendomsmaeglerID = Convert.ToInt32(reader["ejendomsmæglerID"].ToString()),
                            EjendomsmaeglerBrugernavn = reader["brugernavn"].ToString(),
                            EjendomsmaeglerPassword = reader["password"].ToString(),
                        };
                        return realtor;
                    }
                }

                return null;
            }
        }
    
        public static DataTable GetHomesTable()
        {
            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM boliger;", ConnString);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };
            dataAdapter.Fill(table);

            return table;
        }
    }
}
