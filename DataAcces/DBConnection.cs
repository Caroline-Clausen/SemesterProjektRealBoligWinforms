using Microsoft.Data.SqlClient;
using Projekt1Semester;
using System;

namespace DataAccess
{
    public class DBConnection : IDisposable  // Needed so the connection can be forcefully closed
    {
        const String ConnectionString = "Data Source=uclprojects.database.windows.net;Integrated Security=false;User ID=serverlogin;Password=1234Login;\r\n\r\n";
        private SqlConnection conn;
        private bool disposedValue;


        /// <summary>
        /// Starts a new connection with the database
        /// </summary>
        public DBConnection()
        {
            conn = new SqlConnection(ConnectionString);
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


    }
}
