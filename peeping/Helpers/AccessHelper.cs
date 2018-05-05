using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace peeping.Helpers
{
    public class AccessHelper
    {
        // 使用ace驱动程序，据说能访问各种版本的access
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;";

        public AccessHelper(string dbName, string dbPassword)
        {
            this.connectionString += @"Data Source=" + dbName + ";";
            this.connectionString += @"Jet OleDb:DataBase Password='" + dbPassword + "';";
        }

        public int ExecuteNonQuery(string cmdText, params OleDbParameter[] commandParameters)
        {
            OleDbCommand cmd = new OleDbCommand();

            using (OleDbConnection conn = new OleDbConnection(this.connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }


        public OleDbDataReader ExecuteReader(string cmdText, params OleDbParameter[] commandParameters)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection conn = new OleDbConnection(this.connectionString);

            try
            {
                PrepareCommand(cmd, conn, null, cmdText, commandParameters);
                OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();

                return reader;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        public object ExecuteScalar(string cmdText, params OleDbParameter[] commandParameters)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection connection = new OleDbConnection(this.connectionString))
            {
                PrepareCommand(cmd, connection, null, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }


        private void PrepareCommand(OleDbCommand cmd, OleDbConnection conn, OleDbTransaction trans, string cmdText, OleDbParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
            {
                cmd.Transaction = trans;
            }

            cmd.CommandType = CommandType.Text;

            if (cmdParms != null)
            {
                foreach (OleDbParameter parm in cmdParms)
                {
                    cmd.Parameters.Add(parm);
                }
            }
        }
    }
}
