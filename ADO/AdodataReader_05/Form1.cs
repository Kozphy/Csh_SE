using System.Data.SqlClient;
using System.Web;

namespace AdodataReader_05
{
    public partial class Form1 : Form
    {
        string connStr = Properties.Settings.Default.northwind;
        SqlConnection Conn = null;
        SqlDataAdapter adapter = null;
        int total = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection(connStr);
            //adapter = new SqlDataAdapter();
            try
            {
                Conn.Open();
                string queryString = "select CategoryID from Categories";
                SqlCommand cmd = new SqlCommand(queryString, Conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                comboBox1.Items.Add(dr.GetValue(i));
                            }
                        }
                    }
                }
                cmd.Cancel();
                Conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Generic Exception: {ex.ToString()}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("@" + comboBox1.SelectedItem.ToString());

            total += 1;
            label6.Text = total.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                total -= 1;
                label6.Text = total.ToString();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}