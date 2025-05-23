﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Projekt1Semester;

namespace DataAccess
{
    public class EjendomsmæglerRepository : RepositoryBase
    {

        public List<Ejendomsmaegler> HentEjendomsmaeglere()
        {
            List<Ejendomsmaegler> ejendomsmæglere = new List<Ejendomsmaegler>();
            using (SqlConnection con = new SqlConnection(ConnString))
            {

                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ejendomsmæglere WHERE navn<> 'slettet'", con))
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
                                    Navn = reader["navn"].ToString(),
                                    Telefon = reader["telefonnummer"].ToString(),
                                    Email = reader["mail"].ToString(),
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
                    cmd.Parameters.AddWithValue("@navn", ejendomsmægler.Navn);
                    cmd.Parameters.AddWithValue("@telefonnummer", ejendomsmægler.Telefon);
                    cmd.Parameters.AddWithValue("@mail", ejendomsmægler.Email);
                    cmd.Parameters.AddWithValue("@brugernavn", ejendomsmægler.EjendomsmaeglerBrugernavn);
                    cmd.Parameters.AddWithValue("@password", ejendomsmægler.EjendomsmaeglerPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void FjernEjendomsmægler(int ejendomsmæglerID)
        {
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE ejendomsmæglere set navn='slettet', telefonnummer='0', mail='slettet', brugernavn='', password='' WHERE ejendomsmæglerID = @ejendomsmæglerID", con)) 
                    //brugernavn og password er tomme for ikke at kunne logge ind med slettet, slettet.
                {
                    cmd.Parameters.AddWithValue("@ejendomsmæglerID", ejendomsmæglerID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
