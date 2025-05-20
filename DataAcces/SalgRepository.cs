using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Projekt1Semester;

namespace DataAccess
{
    public class SalgRepository : RepositoryBase
    {
        public Salg? HentSalg(int boligId)
        {
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM salg wher boligID = @boligID", con)
                command.Parameters.AddWithValue("@boligID", boligId.ToString());
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader == null)
                    {
                        return null;
                    }
                    while (reader.Read())
                    {
                        Salg salg = new Salg
                        {
                            SalgID = Convert.ToInt32(reader["salgsID"]), 
                            SaelgerID = Convert.ToInt32(reader["sælgerID"]),
                            EjendomsmaeglerID = Convert.ToInt32(reader["ejendomsmæglerID"]),
                            KoeberID = Convert.ToInt32(reader["køberID"]),
                            Salgsdato = Convert.ToDateTime(reader["salgstidspunkt"]),
                            Salgspris = Convert.ToInt32(reader["pris"])
                        };
                        return salg;
                    }
                }
            }

            return null;
        }

        public void OpretSalg(Salg salg)
        {
            using (SqlConnection con = new SqlConnection(ConnString))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO salg (ejendomsmæglerID, køberID, boligID, pris, salgstidspunkt, sælgerID) VALUES (@ejendomsmæglerID, @køberID, @boligID, @pris, @salgstidspunkt, @sælgerID)", con))
                {
                    cmd.Parameters.AddWithValue("@boligID", salg.BoligID);
                    cmd.Parameters.AddWithValue("@køberID", salg.KoeberID);
                    cmd.Parameters.AddWithValue("@ejendomsmæglerID", salg.EjendomsmaeglerID);
                    cmd.Parameters.AddWithValue("@pris", salg.Salgspris);
                    cmd.Parameters.AddWithValue("@salgstidspunkt", salg.Salgsdato);
                    cmd.Parameters.AddWithValue("@sælgerID", salg.SaelgerID);
                    cmd.ExecuteNonQuery();

                }
            }

        }
    }

}