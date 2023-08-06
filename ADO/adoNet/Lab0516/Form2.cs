using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Web.Configuration;

namespace Lab0516
{
    public partial class Form2 : Form
    {

        AppleCat cat = new AppleCat();
        public Form2()
        {
            InitializeComponent();
            Console.WriteLine("a.pika");
            txtApple.Text += $"a. pika" + Environment.NewLine;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("b.pondin");
            txtApple.Text += $"b.pondin" + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtApple.Text += "pika" + Environment.NewLine;
        }
    }

    class AppleCat
    {
        public AppleCat()
        {
            Console.WriteLine("c. AppleCat");
        }
    }
}
