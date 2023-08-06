using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Understand_DataSet
{
    public partial class Form1 : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }
        DataTable GetEmployeeTable()
        {
            dt = new DataTable("Employee");
            #region Employee DataTable

            // Adding Columns
            dc = new DataColumn("EmpId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("EmpName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("DeptId", typeof(int));
            dt.Columns.Add(dc);

            // Adding Rows
            dr = dt.NewRow();
            dr[0] = 101;
            dr[1] = "Anadi";
            dr[2] = 10;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 102;
            dr[1] = "Mohit";
            dr[2] = 10;

            dt.Rows.Add(dr);
            #endregion
            return dt;
        }

        DataTable GetDeparmentTable()
        {
            dt = new DataTable("Department");

            #region Department DataTable
            // Adding Columns
            dc = new DataColumn("DeptId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("DeptName", typeof(string));
            dt.Columns.Add(dc);

            // Adding Rows
            dr = dt.NewRow();
            dr[0] = 10;
            dr[1] = "Administration";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 20;
            dr[1] = "Human Resources";
            dt.Rows.Add(dr);
            #endregion

            return dt;
        }

        DataSet GenerateDataSet()
        {
            DataTable emp = GetEmployeeTable();
            DataTable dept = GetDeparmentTable();

            ds = new DataSet("MyDS");
            ds.Tables.Add(emp); // 0, we can use ds.Table[0] to get Department Table, and ds.Table[1].Columns[0] to get column
            ds.Tables.Add(dept); // 1, we can use ds.Table[1] to get Employee Table, and ds.Table[1].Columns[0]

            DataColumn col_pk = ds.Tables["Department"].Columns["DeptId"];
            DataColumn col_fk = ds.Tables["Employee"].Columns["DeptId"];
            // Foregin key Table_Primary key Table
            DataRelation drel = new DataRelation("Emp_Dept_Rel", col_pk, col_fk);
            ds.Relations.Add(drel);

            return ds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet MyDs = GenerateDataSet();
            dataGridView1.DataSource = MyDs.Tables["Employee"];
            dataGridView2.DataSource = MyDs.Tables["Department"];
        }
    }
}
