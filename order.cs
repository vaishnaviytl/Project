using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project3
{
    public partial class order : Form
    {

        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable prod;
        public order()
        {
            InitializeComponent();
        }

        

        private void txtorderid_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtorderid.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");

                txtorderid.Text = "";
            }
        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtpid.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");

                txtpid.Text = "";
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtquantity.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");

                txtquantity.Text = "";
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string pid, orderid, quantity;
            pid = txtpid.Text;
            orderid = txtorderid.Text;
            quantity = txtquantity.Text;

            try
            {

                dr = prod.NewRow();
                dr[0] = int.Parse(pid);
                dr[1] = int.Parse(orderid);
                dr[2] = int.Parse(quantity);


                prod.Rows.Add(dr);
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
            clear();
        }
        private void clear()
        {
            txtpid.Text = "";
            txtorderid.Text = "";
            txtquantity.Text = "";


        }

        private void order_Load(object sender, EventArgs e)
        {
            prod = Generatetable();
            dataGridView1.DataSource = prod;
        }

        DataTable Generatetable()
        {
            dt = new DataTable("orders");
            dc = new DataColumn("pid", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("orderid", typeof(int));
            dt.Columns.Add(dc);
            dc = new DataColumn("quantity", typeof(int));
            dt.Columns.Add(dc);


            return dt;
        }
    }
}
