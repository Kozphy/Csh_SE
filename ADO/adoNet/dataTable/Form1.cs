using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataTable
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private void MakeParentTable() { 
            DataTable table = new DataTable("ParentTable");
            DataColumn column;
            DataRow row;
            // column 1
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName="id";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            // column 2
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName="ParentItem";
            column.AutoIncrement = false;
            column.Caption = "ParentItem";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            // create PrimaryKey 
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["id"];
            table.PrimaryKey = PrimaryKeyColumns;

            // add table to dataSet
            DataSet ds = new DataSet();
            ds.Tables.Add(table);

            // add rows
            for(int i =0; i < 2; i++) { 
                row = table.NewRow(); 
                row["id"] = i;
                row["ParentItem"] = "ParentItem " + i;
                table.Rows.Add(row);
            }
            dataGridView1.DataSource = ds.Tables["ParentTable"] ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeParentTable();
        }
    }
}
