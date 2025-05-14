using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class AdministratorRepository
    {
        // Connection string
        private const string ConnString =
          "Server=tcp:uclprojects.database.windows.net,1433;" +
          "Initial Catalog=SemesterProjekt2025;" +
          "User ID=serverlogin;Password=1234Login;" +
          "Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        /// <summary>
        /// Returnerer true hvis administrator findes med netop denne brugernavn+kode.
        /// </summary>
        public bool Authenticate(string brugernavn, string adgang)
        {
            const string sql = @"
      SELECT COUNT(*) 
        FROM dbo.Administrator
       WHERE Brugernavn = @u
         AND Password   = @p";

            using (SqlConnection conn = new SqlConnection(ConnString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", brugernavn);
                cmd.Parameters.AddWithValue("@p", adgang);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count == 1;
            }
        }


    }
}
