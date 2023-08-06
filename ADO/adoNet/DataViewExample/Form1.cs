using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.northwind);
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlStr = "select * from Customers";
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            DataSet ds  = new DataSet();

            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Customers");
            DataView CustomersView = new DataView(ds.Tables["Customers"],"CustomerID IN ('ALFKI', 'ANATR')", "ContactName DESC",DataViewRowState.CurrentRows);
            // table to ViewTable
            DataView defaultViewInDs = ds.Tables["Customers"].DefaultView;
            defaultViewInDs.Sort = "CompanyName ASC";

            int rowIndex = defaultViewInDs.Find("The Cracker Box");

            if(rowIndex == -1) {
                Debug.WriteLine("Can't find keyword");
            }
            else {
                Debug.WriteLine(defaultViewInDs[rowIndex]["CustomerID"].ToString());
                Debug.WriteLine(defaultViewInDs[rowIndex]["CompanyName"].ToString());
            }

            dataGridView1.DataSource = defaultViewInDs;
        }
    }
}
