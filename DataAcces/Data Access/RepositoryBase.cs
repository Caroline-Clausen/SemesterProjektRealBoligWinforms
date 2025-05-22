using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Abstract betyder at klassen ikke kan bruges direkte men den skal nedarves
    public abstract class RepositoryBase
    {
        // Connection string
        protected const string ConnString =
          "Server=tcp:uclprojects.database.windows.net,1433;" +
          "Initial Catalog=SemesterProjekt2025;" +
          "User ID=serverlogin;Password=1234Login;" +
          "Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public string? håndterDbNullString(object dbValue)
        {
            // Hvis dbValue er null, returner en tom streng
            if (dbValue == DBNull.Value)
            {
                return null;
            }
            else
            {
                // Ellers returner værdien som en streng
                return dbValue.ToString();
            }
        }

        public int? håndterDbNullInt(object dbValue)
        {
            // Hvis dbValue er null, returner en tom streng
            if (dbValue == DBNull.Value)
            {
                return null;
            }
            else
            {
                // Ellers returner værdien som en streng
                return Convert.ToInt32(dbValue);
            }
        }
    }
}
