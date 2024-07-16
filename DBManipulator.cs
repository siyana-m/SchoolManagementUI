using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace ProjectAAS
{
    public class DBManipulator
    {
        private SqlConnection connection;
        private SqlCommand command;
        public DBManipulator()
        {
            this.connection = new
           SqlConnection(ConfigurationManager.ConnectionStrings["ProjectAAS.mssql"].ToString());
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }
        public SqlConnection GetConnection()
        {
            return this.connection;
        }
        public SqlCommand GetCommand()
        {
            this.command.Parameters.Clear();
            return this.command;
        }
    }
}
