using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab0522_form
{
    public class reuseDBInit
    {
        public SqlConnection conn = null;
        public SqlDataAdapter adapter = null;
        SqlCommandBuilder SqlBuilder = null;
        private DataSet ds { get; set; }

        string connStr = Properties.Settings.Default.AdventureWork2022;

        public reuseDBInit() { 
           conn = new SqlConnection(connStr);
           adapter = new SqlDataAdapter();
           ds = new DataSet();
           SqlBuilder =  new SqlCommandBuilder(adapter);
        }

        
        public DataSet getData(string queryString, string dataSetName) {
            ds.Clear();
            SqlCommand cmd = new SqlCommand(queryString, conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(this.ds, dataSetName);
            return this.ds;
        }
        
    }
}
