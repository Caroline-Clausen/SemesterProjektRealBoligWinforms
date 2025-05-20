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