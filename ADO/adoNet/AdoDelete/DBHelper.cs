using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDelete
{
    internal class DBHelper : IDbHelper
    {

        string connStr = Properties.Settings.Default.northwind;
        string tableName = null;
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public DBHelper()
        {
            conn = new SqlConnection(connStr);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
        }

        public DataSet SelectData(string sqlStr, string dsTableName)
        {
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, dsTableName);
            tableName = dsTableName; 
            return ds;
        }

        public string GetScalarValue(string sqlStr)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            adapter.SelectCommand = cmd;
            string res = adapter.SelectCommand.ExecuteScalar().ToString();
            conn.Close();
            return res;
        }

        public int InsertData(string sqlStr, Dictionary<string, string> data) { 
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            adapter.InsertCommand = cmd;
            foreach(KeyValuePair<string, string> kv in data)
            {
                cmd.Parameters.AddWithValue(kv.Key, kv.Value);
            }
            int insertedNum = adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
            return insertedNum;
        }

        public int UpdateData(string sqlStr, Dictionary<string,string> data) { 
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            adapter.UpdateCommand = cmd;
            foreach(KeyValuePair<string, string> kv in data)
            {
                cmd.Parameters.AddWithValue(kv.Key, kv.Value);
            }
            int rowAffected = adapter.UpdateCommand.ExecuteNonQuery();
            conn.Close();
            return  rowAffected;
        }

        public int DeleteData(string sqlStr, Dictionary<string,string> data)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            adapter.DeleteCommand = cmd;
            foreach(KeyValuePair<string, string> kv in data)
            {
                cmd.Parameters.AddWithValue(kv.Key, kv.Value);
            }
            int rowAffected = adapter.DeleteCommand.ExecuteNonQuery();
            conn.Close();

            return  rowAffected;
        }
        public int DeleteDataThroughDs(string sqlStr, Dictionary<string, string> data, int rowIndex)
        {
            if (ds == null || ds.Tables[tableName] == null) {
                MessageBox.Show("Please click select data first");
            }
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            adapter.DeleteCommand = cmd;
            foreach(KeyValuePair<string, string> kv in data)
            {
                cmd.Parameters.AddWithValue(kv.Key, kv.Value);
            }
            //Debug.WriteLine(rowIndex);

            //ds.Tables["Customer"].Rows[rowIndex].Delete();
            //int rowAffected = adapter.Update(ds, "Customer");
            //return rowAffected;
            return 1;
        }

    }
}
