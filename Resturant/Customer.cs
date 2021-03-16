using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Customer : UserControl
    {
        static String connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
        SqlConnection con;
        DataTable t;
        public Customer()
        {
            InitializeComponent();
            con = new SqlConnection(connection);
            newCustomer1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
          int phone=  int.Parse(textBox1.Text);
           t = new DataTable();
          string comand = "select * from Customer where Phone="+phone;
          SqlCommand cmd = new SqlCommand(comand,con);
          SqlDataAdapter myadaptar = new SqlDataAdapter(cmd);
          myadaptar.Fill(t);
          if (t.Rows.Count == 1)
          {
              textBox4.Text = t.Rows[0][0]+"";
              textBox3.Text = t.Rows[0][1] + "";
              textBox2.Text = t.Rows[0][3] + "";
          }
          else {
              DialogResult dialogResult = MessageBox.Show("Do you want add new Customer", "Not found", MessageBoxButtons.YesNo);
              if (dialogResult == DialogResult.Yes)
              {
              //    this.Hide();
                  newCustomer1.Visible = true;
              

             
              }
          }
          con.Close();
        }

        private void newCustomer1_Load(object sender, EventArgs e)
        {

        }

        private void Customer_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible== false)
            newCustomer1.Visible = false;

        }
    }
}
