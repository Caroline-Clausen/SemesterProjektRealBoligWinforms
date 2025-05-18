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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM boliger WHERE adresse <> 'slettet'", con))
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
                                    Kvadratmeter = Convert.ToInt32(reader["kvadratmeter"]),
                                    Type = reader["type"].ToString(),
                                    Pris = Convert.ToDouble(reader["pris"]),
                                    AfstandTilIndkoeb = Convert.ToDouble(reader["afstandtilindkøb"]),
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

        public List<Bolig> HentBoligerOmråde(string område)
        {
            List<Bolig> boliger = new List<Bolig>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM boliger WHERE adresse <> 'slettet' and område=@område", con))
                {
                   cmd.Parameters.AddWithValue("@område", område);

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
                                    Kvadratmeter = Convert.ToInt32(reader["kvadratmeter"]),
                                    Type = reader["type"].ToString(),
                                    Pris = Convert.ToDouble(reader["pris"]),
                                    AfstandTilIndkoeb = Convert.ToDouble(reader["afstandtilindkøb"]),
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
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO boliger (adresse, m2, type, pris, afstand_til_indkoeb, status, område) VALUES (@adresse, @kvadratmeter, @type, @pris, @afstandTilIndkøb, @status, @område)", con))
                {
                    cmd.Parameters.AddWithValue("@adresse", bolig.Adresse);
                    cmd.Parameters.AddWithValue("@kvadratmeter", bolig.Kvadratmeter);
                    cmd.Parameters.AddWithValue("@type", bolig.Type);
                    cmd.Parameters.AddWithValue("@pris", bolig.Pris);
                    cmd.Parameters.AddWithValue("@afstandTilIndkøb", bolig.AfstandTilIndkoeb);
                    cmd.Parameters.AddWithValue("@status", bolig.Status);
                    cmd.Parameters.AddWithValue("@område", bolig.Område);
                    cmd.ExecuteNonQuery();
                }
                // Implementer tilføjelse af bolig til databasen
            }
        }
        public void FjernBolig(int boligId)
        {
            // Implementer fjernelse af bolig fra databasen
        }

        public List<string> HentOmråder()
        {
            List<string> områder = new List<string>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT område FROM boliger", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                områder.Add(reader["område"].ToString());
                            }
                        }
                    }
                }
            }
            return områder;
        }
        
    }
}
