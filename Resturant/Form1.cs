using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{

    public partial class Form1 : Form
    {
        static String connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
        SqlConnection con;
      
        public Form1()
        {
            con = new SqlConnection(connection);
            InitializeComponent();
            txtpassword.PasswordChar = '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
    

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable t = new DataTable();
            string comand = "select * from Cashier where User_Name= '" + txtusername.Text.Trim() + "' and Password= '" + txtpassword.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(comand, con);
            //cmd.ExecuteNonQuery();
            SqlDataAdapter myadaptar = new SqlDataAdapter(cmd);
            myadaptar.Fill(t);
            if (t.Rows.Count == 1)
            {
               
                 int x= int.Parse(t.Rows[0][0] + "");
                this.Hide();
                Form2 f2 = new Form2();
                f2.user_id = x;
             
                f2.Show();
            }
            else
                MessageBox.Show("Username or Password not correct ☺");
            con.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            DataTable t = new DataTable();
            string comand = "select * from Cashier where User_Name= '" + txtusername.Text.Trim() + "' and Password= '" + txtpassword.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(comand, con);
            //cmd.ExecuteNonQuery();
            SqlDataAdapter myadaptar = new SqlDataAdapter(cmd);
            myadaptar.Fill(t);
            if (t.Rows.Count == 1)
            {

                int x = int.Parse(t.Rows[0][0] + "");
                this.Hide();
                Form2 f2 = new Form2();
                f2.user_id = x;

                f2.Show();
            }
            else
                MessageBox.Show("Username or Password not correct ☺");
            con.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            con.Open();
            DataTable t = new DataTable();
            string comand = "select * from Cashier where User_Name= '" + txtusername.Text.Trim() + "' and Password= '" + txtpassword.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(comand, con);
            //cmd.ExecuteNonQuery();
            SqlDataAdapter myadaptar = new SqlDataAdapter(cmd);
            myadaptar.Fill(t);
            if (t.Rows.Count == 1)
            {

                int x = int.Parse(t.Rows[0][0] + "");
                this.Hide();
                Form2 f2 = new Form2();
                f2.user_id = x;

                f2.Show();
            }
            else
                MessageBox.Show("Username or Password not correct ☺");
            con.Close();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            Close();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
