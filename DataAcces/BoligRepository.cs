using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt1Semester;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class BoligRepository : RepositoryBase
    {
        public List<Bolig> HentBoliger()
        {
            List<Bolig> boliger = new List<Bolig>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM boliger WHERE navn<> 'slettet'", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                Bolig bolig = new Bolig
                                {
                                    BoligID = Convert.ToInt32(reader["boligID"]), // Primarnøgle tildelt fra database (autogenereret)
                                    Adresse = reader["adresse"].ToString(),
                                    Kvadratmeter = Convert.ToInt32(reader["m2"]),
                                    Type = reader["type"].ToString(),
                                    Pris = Convert.ToDouble(reader["pris"]),
                                    AfstandTilIndkoeb = Convert.ToDouble(reader["afstand_til_indkoeb"]),
                                    Status = reader["status"].ToString(),
                                    Område = reader["område"].ToString(),
                                                                       
                                };
                                boliger.Add(bolig);
                            }
                        }
                    }
                }
            }
            return boliger;
        }
        public void TilføjBolig(Bolig bolig)
        {
            // Implementer tilføjelse af bolig til databasen
        }
        public void FjernBolig(int boligId)
        {
            // Implementer fjernelse af bolig fra databasen
        }
    }
    {
    }
}
