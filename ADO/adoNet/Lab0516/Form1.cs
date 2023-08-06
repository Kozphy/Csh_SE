using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0516
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("pika");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bee_Click(object sender, EventArgs e)
        {
            // running 5 time
            foreach (Control control in this.Controls)
            {
                Console.WriteLine(control.Name);
                this.listBox1.Items.Add("pondi");
            }
        }
    }
}
