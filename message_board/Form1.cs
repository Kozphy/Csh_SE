using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace message_board
{
    public partial class Form1 : Form
    {
        DBHelper testdb;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            testdb = new DBHelper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getTestData();
            getTalkData();
            ds.Relations.Add("Relation_TT",
                ds.Tables["test"].Columns["id"],
                ds.Tables["test_talk"].Columns["test_id"]
            );
            //dataGridView1.DataSource = ds.Tables["test"];
            //dataGridView1.DataSource = ds.Tables["test_talk"];
            StringBuilder str = new StringBuilder();

            foreach (DataRow testRow1 in ds.Tables["test"].Rows) 
            {
                str.Append(testRow1["id"].ToString() + "\t");
                str.Append(testRow1["title"].ToString());

                foreach (DataRow talkRow2 in testRow1.GetChildRows(ds.Relations["Relation_TT"])) 
                {
                    str.Append(talkRow2["id"].ToString());
                    str.Append(talkRow2["test_id"].ToString());
                    str.Append(talkRow2["article"].ToString());
                }
            }
            textBox1.Text = str.ToString();
        }

        private void getTestData() { 
            string selectStrTest = "select id, title from test";
            ds = testdb.getDataSet(selectStrTest, "test");
        }
        private void getTalkData() { 
            string selectStrTalk = "select id, test_id, article from test_talk";
            ds = testdb.getDataSet(selectStrTalk, "test_talk");
        }
    }
}
