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

namespace multiAdapter
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
            string selectCustomerStr = "select * from Customers";
            string selectOrderStr = "select * from Orders";
            SqlDataAdapter adapter1 = new SqlDataAdapter(selectCustomerStr, conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(selectOrderStr, conn);

            DataSet ds = new DataSet();

            adapter1.Fill(ds, "Customers");
            adapter2.Fill(ds, "Orders");
            DataRelation relation = ds.Relations.Add("Customers_Orders", ds.Tables["Customers"].Columns["CustomerID"], ds.Tables["Orders"].Columns["CustomerID"]);

            DataTable dt = new DataTable("result");
            DataRow row;
            DataColumn col;

            col = new DataColumn();
            col.ColumnName = "CustomerID";
            col.DataType = Type.GetType("System.String");
            dt.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "OrderID";
            col.DataType = Type.GetType("System.Int32");
            dt.Columns.Add(col);

            DataColumn[] PKColumns = new DataColumn[1];
            PKColumns[0] = dt.Columns["CustomerID"];
            dt.PrimaryKey = PKColumns;

            // add table to dataSet
            ds.Tables.Add(dt);

            foreach (DataRow CustomersRow in ds.Tables["Customers"].Rows)
            {
                row = dt.NewRow();
                //Debug.WriteLine(CustomersRow["CustomerID"]);
                row["CustomerID"] = CustomersRow["CustomerID"];
                foreach (DataRow OrdersRow in CustomersRow.GetChildRows(relation))
                {
                    row["OrderID"] = OrdersRow["OrderID"];
                    //Debug.WriteLine($"OrdersRow: {OrdersRow["OrderID"]}");
                }
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = ds.Tables["result"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
