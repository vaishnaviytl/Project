using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ob1 = new Form1();
            ob1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order ob2 = new order();
            ob2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            category ob3 = new category();
            ob3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer ob4 = new Customer();
            ob4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Offers ob5 = new Offers();
               ob5.Show();
        }
    }
}
