using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0517_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=DESKTOP-BO1NJFV;Database=northwind;User ID=zixsa;Password=0270453;Connect Timeout=30;Encrypt=False;";

            //string sql = "select * from Categories";
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            //DataSet ds = new DataSet();
            //con.Open();
            //dataadapter.Fill(ds, "Categories");
            //con.Close();
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "Categories";

            this.dataGridView1.Columns[0].HeaderText = "類別";
            this.dataGridView1.Columns[1].HeaderText = "類別名稱";
            this.dataGridView1.Columns[2].HeaderText = "描述";
            this.dataGridView1.Columns[3].HeaderText = "圖片";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList titles = new ArrayList(){ "類別", "類別名稱", "描述", "圖片"};
            for (int i =0; i< this.dataGridView1.ColumnCount; i++) {
                this.dataGridView1.Columns[i].HeaderText = titles[i].ToString();
            }
        }

    }
}
