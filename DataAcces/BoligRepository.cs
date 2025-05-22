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
                                    SaelgerID = Convert.ToInt32(reader["sælgerID"]),
                                };
                                boliger.Add(bolig);
                            }
                        }
                    }
                }
            }
            return boliger;
        }

        public Bolig HentBolig(int boligID)
        {
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM boliger WHERE boligID = @boligID", con))
                {
                    cmd.Parameters.AddWithValue("@boligID", boligID);

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
                                    SaelgerID = Convert.ToInt32(reader["sælgerID"]),
                                };
                                return bolig;
                            }
                        }
                        return new Bolig();
                    }
                }
            }
        }

        public List<Bolig> HentBoligerIkkeSolgtOmråde(string område)
        {
            List<Bolig> boliger = new List<Bolig>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM boliger WHERE status <> 'solgt' and område=@område", con))
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
                using (SqlCommand cmd = new SqlCommand("INSERT INTO boliger (adresse, kvadratmeter, type, pris, afstandTilIndkøb, status, område, SælgerID) VALUES (@adresse, @kvadratmeter, @type, @pris, @afstandTilIndkøb, @status, @område, @sælgerID)", con))
                {
                    cmd.Parameters.AddWithValue("@adresse", bolig.Adresse);
                    cmd.Parameters.AddWithValue("@kvadratmeter", bolig.Kvadratmeter);
                    cmd.Parameters.AddWithValue("@type", bolig.Type);
                    cmd.Parameters.AddWithValue("@pris", bolig.Pris);
                    cmd.Parameters.AddWithValue("@afstandTilIndkøb", bolig.AfstandTilIndkoeb);
                    cmd.Parameters.AddWithValue("@status", bolig.Status);
                    cmd.Parameters.AddWithValue("@område", bolig.Område);
                    cmd.Parameters.AddWithValue("@sælgerID", bolig.SaelgerID);
                    cmd.ExecuteNonQuery();
                }
                // Implementer tilføjelse af bolig til databasen
            }
        }

        public void OpdaterBolig(Bolig bolig)
        {
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE boliger SET adresse = @adresse, kvadratmeter = @kvadratmeter, type = @type, pris = @pris, afstandTilIndkøb = @afstandTilIndkøb, status = @status, område = @område WHERE boligID = @boligID", con))
                {
                    cmd.Parameters.AddWithValue("@boligID", bolig.BoligID);
                    cmd.Parameters.AddWithValue("@adresse", bolig.Adresse);
                    cmd.Parameters.AddWithValue("@kvadratmeter", bolig.Kvadratmeter);
                    cmd.Parameters.AddWithValue("@type", bolig.Type);
                    cmd.Parameters.AddWithValue("@pris", bolig.Pris);
                    cmd.Parameters.AddWithValue("@afstandTilIndkøb", bolig.AfstandTilIndkoeb);
                    cmd.Parameters.AddWithValue("@status", bolig.Status);
                    cmd.Parameters.AddWithValue("@område", bolig.Område);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void FjernBolig(int boligId)
        {
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE from boliger WHERE boligID = @boligID", con))
                {
                    cmd.Parameters.AddWithValue("@boligID", boligId);
                    cmd.ExecuteNonQuery();
                }
            }


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

        public void SætStatus(int boligID, string status)
        {
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE boliger SET  status = @status WHERE boligID = @boligID", con))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@boligID", boligID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Bolig> HentBoligIkkeSolgt()
        {
            List<Bolig> boliger = new List<Bolig>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM boliger WHERE status <> 'solgt'", con))
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

        public List<BoligUdvidet> HentBoligerMedSælger()
        {
            List<BoligUdvidet> boliger = new List<BoligUdvidet>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT boliger.*, sælgere.navn as sælgernavn, sælgere.mail as sælgermail, sælgere.telefonnummer as sælgertelefonnummer, " +
                    "salg.pris as salgspris, salg.salgstidspunkt, ejendomsmæglere.navn as mæglernavn, ejendomsmæglere.mail as mæglermail, " +
                    "ejendomsmæglere.telefonnummer as mæglertelefonnummer, ejendomsmæglere.ejendomsmæglerID from boliger\r\n" +
                    "left join sælgere on sælgere.sælgerID = boliger.sælgerID\r\n" +
                    "left join salg on salg.boligID = boliger.boligID\r\n" +
                    "left join ejendomsmæglere on ejendomsmæglere.ejendomsmæglerID = salg.ejendomsmæglerID", con))

                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                BoligUdvidet bolig = new BoligUdvidet
                                {
                                    BoligID = Convert.ToInt32(reader["boligID"]), // Primarnøgle tildelt fra database (autogenereret)
                                    Adresse = reader["adresse"].ToString(),
                                    Kvadratmeter = Convert.ToInt32(reader["kvadratmeter"]),
                                    Type = reader["type"].ToString(),
                                    Pris = Convert.ToDouble(reader["pris"]),
                                    AfstandTilIndkoeb = Convert.ToDouble(reader["afstandtilindkøb"]),
                                    Område = reader["område"].ToString(),
                                    Status = reader["status"].ToString(),
                                    SaelgerID = Convert.ToInt32(reader["sælgerID"].ToString()),
                                    Sælger = new Saelger { 
                                        Navn = håndterDbNullString(reader["sælgernavn"].ToString()),
                                        Email = håndterDbNullString(reader["sælgermail"].ToString()),
                                        Telefon = håndterDbNullString(reader["sælgertelefonnummer"].ToString()),

                                    },
                                    Mægler = new Ejendomsmaegler
                                    {
                                        Navn = håndterDbNullString(reader["mæglernavn"]),
                                        Email = håndterDbNullString(reader["mæglermail"]),
                                        Telefon = håndterDbNullString(reader["mæglertelefonnummer"])
                                    }
                                };
                                boliger.Add(bolig);
                            }
                        }
                    }
                }
            }
            return boliger;

        }
    }
}

