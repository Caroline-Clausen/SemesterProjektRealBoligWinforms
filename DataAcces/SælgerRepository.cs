using Microsoft.Data.SqlClient;
using Projekt1Semester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SælgerRepository : RepositoryBase
    {
        public List<Saelger> HentSælgere()
        {
            List<Saelger> sælgere = new List<Saelger>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM sælgere", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                Saelger bolig = new Saelger
                                {
                                    SaelgerID = Convert.ToInt32(reader["sælgerID"]), // Primarnøgle tildelt fra database (autogenereret)
                                    Navn = reader["navn"].ToString(),
                                    Telefon = reader["telefonnummer"].ToString(),
                                    Email = reader["mail"].ToString(),
                                };
                                sælgere.Add(bolig);
                            }
                        }
                    }
                }
            }
            return sælgere;
        }
    }
}
