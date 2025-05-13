using Microsoft.Data.SqlClient;
using Projekt1Semester;
using System;

namespace DataAccess
{
    public class DBConnection : IDisposable  // Needed so the connection can be forcefully closed
    {
        const String ConnectionString = "Data Source=uclprojects.database.windows.net;Integrated Security=false;User ID=serverlogin;Password=1234Login;Database=SemesterProjekt2025;";
        private SqlConnection conn;
        private bool disposedValue;


        /// <summary>
        /// Starts a new connection with the database
        /// </summary>
        public DBConnection()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }

        /* Destruction methods */
        ~DBConnection()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Ensure we close out SQL connection when object is deleted
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /* Data Access */

        public Ejendomsmaegler? GetRealtor(String username)
        {
            // Ensure connection is open
            if (conn.State == System.Data.ConnectionState.Closed)
                return null;

            // Create command
            var command = conn.CreateCommand();

            // Create select query text
            command.CommandText = "SELECT * FROM ejendomsmæglere WHERE username = @username";
            command.Parameters.AddWithValue("@username", username);

            // Execute command
            using (var reader = command.ExecuteReader())
            {
                // Try to parse the querry response into a Realtor object
                try
                {
                    // We only need to read the first record
                    if (reader.Read())
                    {
                        // Process the data
                        Ejendomsmaegler realtor = new Ejendomsmaegler
                        {
                            EjendomsmaeglerID = int.Parse(reader["Id"].ToString()),
                            EjendomsmaeglerBrugernavn = reader["Username"].ToString(),
                            EjendomsmaeglerPassword = reader["Password"].ToString(),
                        };
                        return realtor;
                    }
                } catch (Exception e)
                {
                    return null;
                }
            }

            return null;
        }
    }
}
