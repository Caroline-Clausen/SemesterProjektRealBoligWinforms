using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Projekt1Semester;

namespace DataAccess
{
    public class EjendomsmæglerRepository
    {
        // Connection string
        private const string ConnString =
          "Server=tcp:uclprojects.database.windows.net,1433;" +
          "Initial Catalog=SemesterProjekt2025;" +
          "User ID=serverlogin;Password=1234Login;" +
          "Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public List<Ejendomsmaegler> HentEjendomsmaeglere()
        {
            List<Ejendomsmaegler> ejendomsmæglere = new List<Ejendomsmaegler>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {

                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ejendomsmæglere", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                Ejendomsmaegler ejendomsmægler = new Ejendomsmaegler
                                {
                                    EjendomsmaeglerID = Convert.ToInt32(reader["ejendomsmæglerID"]),
                                    PersonNavn = reader["navn"].ToString(),
                                    PersonTelefon = reader["telefonnummer"].ToString(),
                                    PersonEmail = reader["mail"].ToString(),
                                    EjendomsmaeglerBrugernavn = reader["brugernavn"].ToString(),
                                    EjendomsmaeglerPassword = reader["password"].ToString()
                                };
                                ejendomsmæglere.Add(ejendomsmægler);
                            }
                        }
                    } // reader closed and disposed up here

                } // command disposed here

            } //connection closed and disposed here
            return ejendomsmæglere;
        }

        public void TilføjEjendomsmægler(Ejendomsmaegler ejendomsmægler)
        {
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ejendomsmæglere (navn, telefonnummer, mail, brugernavn, password) VALUES (@navn, @telefonnummer, @mail, @brugernavn, @password)", con))
                {
                    cmd.Parameters.AddWithValue("@navn", ejendomsmægler.PersonNavn);
                    cmd.Parameters.AddWithValue("@telefonnummer", ejendomsmægler.PersonTelefon);
                    cmd.Parameters.AddWithValue("@mail", ejendomsmægler.PersonEmail);
                    cmd.Parameters.AddWithValue("@brugernavn", ejendomsmægler.EjendomsmaeglerBrugernavn);
                    cmd.Parameters.AddWithValue("@password", ejendomsmægler.EjendomsmaeglerPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
