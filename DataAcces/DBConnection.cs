using Microsoft.Data.SqlClient;
using Projekt1Semester;
using System;

namespace DataAccess
{
    public static class DBConnection  // Needed so the connection can be forcefully closed
    {
        const String ConnectionString = "Data Source=uclprojects.database.windows.net;Integrated Security=false;User ID=serverlogin;Password=1234Login;Database=SemesterProjekt2025;";


        public static Ejendomsmaegler? GetRealtor(String username)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
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
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }

                return null;
            }
        }
    }
}
