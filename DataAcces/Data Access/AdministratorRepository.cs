using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class AdministratorRepository : RepositoryBase
    {
        /// <summary>
        /// Returnerer true hvis administrator findes med netop denne brugernavn+kode.
        /// </summary>
        public bool Authenticate(string brugernavn, string adgang)
        {
            //SQL-kommando, der tæller antal rækker hvor brugernavn+kode matcher
            const string sql = @"
      SELECT COUNT(*) 
        FROM dbo.Administrator
       WHERE Brugernavn = @u
         AND Password   = @p";

            //Opretter en databaseforbindelse med den angivne connection string
            using (SqlConnection conn = new SqlConnection(ConnString))
            //Opretter et SQL - kommando - objekt baseret på ovenstående SQL og forbindelsen
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                //Vi bruger @u og @p i SQL og tilføjer værdier med AddWithValue for at beskytte mod SQL-injektion.
                cmd.Parameters.AddWithValue("@u", brugernavn);
                cmd.Parameters.AddWithValue("@p", adgang);

                conn.Open();   //Åbner forbindelsen til databasen
                int count = (int)cmd.ExecuteScalar();  //Udfører forespørgslen og henter det første felt i første række (COUNT(*))
                return count == 1;  //Returnerer true hvis præcis én række matchede (brugeren findes og koden passer)
            }
        }


    }
}
