using System;
//using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class SQLConnection : IDataAccess
    {
        const String ConnectionString = "Data Source=uclprojects.database.windows.net;Integrated Security=false;User ID=serverlogin;Password=1234Login;\r\n\r\n";

        public SQLConnection()
        {

        }
    }
}
