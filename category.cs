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
    public partial class category : Form
    {

        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable prod;
        public category()
        {
            InitializeComponent();
        }



        private void category_Load(object sender, EventArgs e)
        {

            prod = GenerateTable();
            dataGridView1.DataSource = prod;
        }
        DataTable GenerateTable()
        {
            dt = new DataTable("categories");

            dc = new DataColumn("categoryid", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("categoryname", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("categorydescription", typeof(string));
            dt.Columns.Add(dc);

            return dt;


        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            string cid, cname, cdesc;
            cid = txtcid.Text;
            cname = txtcname.Text;
            cdesc = txtdesc.Text;
            try
            {
                dr = prod.NewRow();
                dr[0] = int.Parse(cid);
                dr[1] = cname;
                dr[2] = cdesc;
                prod.Rows.Add(dr);
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }


        }
        private void clear()
        {
            txtcid.Text = "";
            txtcname.Text = "";
            txtdesc.Text = "";
        }

        private void txtcid_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtcid.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric values");
                txtcid.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

