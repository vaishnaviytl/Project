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
    public partial class Form1 : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable prod;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prod = Generatetable();
            dataGridView1.DataSource = prod;
        }
        DataTable Generatetable()
        {
            dt = new DataTable("product");
            dc = new DataColumn("pid", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("productname", typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("productprice", typeof(float));
            dt.Columns.Add(dc);
            dc = new DataColumn("productdescription", typeof(string));
            dt.Columns.Add(dc);

            


            return dt;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string pid,pname,price,pdesc;
            pid = txtpid.Text;
            pname = txtpname.Text;
            price = txtprice.Text;
            pdesc = txtdesc.Text;

            try
            {

                dr = prod.NewRow();
                dr[0] = int.Parse(pid);
                dr[1] = pname;
                dr[2] = float.Parse(price);
                dr[3] = pdesc;


        
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
            txtpname.Text = "";
            txtprice.Text = "";
            txtdesc.Text = "";



        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtpid.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");

                txtpid.Text = "";
            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtprice.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric vals");

                txtprice.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
