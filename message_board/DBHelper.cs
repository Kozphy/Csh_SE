using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_board
{
    internal class DBHelper
    {
        string connStr = Properties.Settings.Default.test;
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;


        public DBHelper(string connStr = null) {
            conn = connStr == null ? new SqlConnection(this.connStr) : new SqlConnection(connStr);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
        }

        public DataSet getDataSet(string sqlStr, string dsName) { 
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, dsName);
            return ds;
        }
    }
}
