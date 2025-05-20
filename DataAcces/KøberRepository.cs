using Microsoft.Data.SqlClient;
using Projekt1Semester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KøberRepository : RepositoryBase
    {
        public List<Koeber> Hentkøbere()

        {
            List<Koeber> købere = new List<Koeber>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM købere", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                Koeber bolig = new Koeber
                                {
                                    KoeberID = Convert.ToInt32(reader["køberID"]), // Primarnøgle tildelt fra database (autogenereret)
                                    PersonNavn = reader["navn"].ToString(),
                                    PersonTelefon = reader["telefonnummer"].ToString(),
                                    PersonEmail = reader["mail"].ToString(),
                                };
                                købere.Add(bolig);
                            }
                        }
                    }
                }
            }
            return købere;
        }
    }
}
