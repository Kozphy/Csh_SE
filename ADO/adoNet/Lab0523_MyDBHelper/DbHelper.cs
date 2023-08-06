using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0523_MyDBHelper
{
    internal class DbHelper
    {

        string connStr = Properties.Settings.Default.AdventureWork2022;
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        public SqlCommandBuilder sqlb = null;
        DataSet ds = null;

        public DbHelper()
        {
            this.conn = new SqlConnection(this.connStr);
            Init();
        }

        public DbHelper(string connStr)
        {
            this.conn = new SqlConnection(connStr);
            Init();
        }
        private void Init()
        {
            this.adapter = new SqlDataAdapter();
            this.sqlb = new SqlCommandBuilder(adapter);
            ds = new DataSet();
        }

        public DataTable getData(string sqlStr, string dataSetName)
        {
            ds.Clear();
            SqlCommand cmd = new SqlCommand(sqlStr, this.conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(this.ds, dataSetName);
            return this.ds.Tables[dataSetName];
        }

        public int getDataV2(string sqlStr, out DataTable dt)
        {
            SqlCommand cmd = new SqlCommand(sqlStr, this.conn);
            adapter.SelectCommand = cmd;
            dt = new DataTable();
            int totalRow = adapter.Fill(dt);
            return totalRow;
        }

        public int insertData(string CurrencyAlternateKey, string CurrencyName)
        {
            conn.Open();
            SqlCommand cmd = sqlb.GetInsertCommand(true);
            adapter.InsertCommand = cmd;
            Debug.WriteLine(cmd.CommandText);
            cmd.Parameters["@CurrencyAlternateKey"].Value = CurrencyAlternateKey;
            cmd.Parameters["@CurrencyName"].Value = CurrencyName;
            int insertRow = adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
            return insertRow;
        }

        // Without SqlCommandBuilder
        public int insertDataV2(string queryString, string CurrencyAlternateKey, string CurrencyName)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryString, this.conn);
            cmd.Parameters.AddWithValue("@CurrencyAlternateKey", CurrencyAlternateKey);
            cmd.Parameters.AddWithValue("@CurrencyName", CurrencyName);
            adapter.InsertCommand = cmd;
            int insertRow = adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
            return insertRow;
        }

        public int insertDataV3(string queryString, Dictionary<string, string> userData)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryString, this.conn);
            foreach(KeyValuePair<string,string> item in userData) { 
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }

            adapter.InsertCommand = cmd;
            int insertRow = adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
            return insertRow;
        }

        public int updateData(string sqlStr, Dictionary<string,string> data)
        {
            this.conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, this.conn);
            foreach(KeyValuePair<string,string> item in data) { 
                cmd.Parameters.AddWithValue(item.Key,item.Value);
            }

            Debug.WriteLine(cmd.CommandText);
            adapter.UpdateCommand = cmd;
            int totalUpdate = adapter.UpdateCommand.ExecuteNonQuery();
            cmd.Cancel();
            this.conn.Close();
            return totalUpdate;
        }
    }
}
