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
    public partial class Customer : Form

    {

        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable prod;
        public Customer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

            prod = GenerateTable();
            dataGridView1.DataSource = prod;
        }

        DataTable GenerateTable()
        {
            dt = new DataTable("Customers");

            dc = new DataColumn("customerID", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("customerName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("customercontact", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("customeremail", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("customeraddress", typeof(string));
            dt.Columns.Add(dc);

            return dt;


        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            string custid, custname, custcontact, custemail, custaddress;
            custid = txtcustid.Text;
            custname = txtcustname.Text;
            custcontact = txtcustcontact.Text;
            custemail = txtcustemail.Text;
            custaddress = txtcustaddress.Text;
            try
            {
                dr = prod.NewRow();
                dr[0] = int.Parse(custid);
                dr[1] = custname;
                dr[2] = int.Parse(custcontact);
                dr[3] = custemail;
                dr[4] = custaddress;
                prod.Rows.Add(dr);
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
        }
        private void clear()
        {
            txtcustid.Text = "";
            txtcustname.Text = "";
            txtcustcontact.Text = "";
            txtcustemail.Text = "";
            txtcustaddress.Text = "";

        }

        private void txtcustid_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtcustid.Text, "[^0-9]"))
            {
                MessageBox.Show("you should not enter non numeric values");
                txtcustid.Text = "";
            }
        }

        private void txtcustname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcustcontact_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtcustcontact.Text, "[^0-9]"))
            {
                MessageBox.Show("you should not enter non numeric values");
                txtcustcontact.Text = "";
            }
        }
    }
    }

