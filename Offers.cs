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
    public partial class Offers : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable prod;
        public Offers()
        {
            InitializeComponent();
        }


        private void Offers_Load(object sender, EventArgs e)
        {
            prod = Generatetable();
            dataGridView1.DataSource = prod;
        }

        DataTable Generatetable()
        {
            dt = new DataTable("Offer");
            dc = new DataColumn("OfferId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("Discount%", typeof(float));
            dt.Columns.Add(dc);
            dc = new DataColumn("Promosource", typeof(string));
            dt.Columns.Add(dc);


            return dt;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            string oid, Discount, Promosource;
            oid = txtoid.Text;
            Discount = txtoffer.Text;
            Promosource = txtpsource.Text;
            try
            {
                dr = prod.NewRow();
                dr[0] = int.Parse(oid);
                dr[1] = float.Parse(Discount);
                dr[2] = Promosource;

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
            txtoid.Text = "";
            txtoffer.Text = "";
            txtpsource.Text = "";

        
    }

        private void txtoid_TextChanged(object sender, EventArgs e)
        {


            if (Regex.IsMatch(txtoid.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");

                txtoid.Text = "";
            }
        }

        private void txtoffer_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtoffer.Text, "[^0-9]%"))
            {
                MessageBox.Show("do not enter non numeric vals");

                txtoffer.Text = "";
            }
        }
    }
}
