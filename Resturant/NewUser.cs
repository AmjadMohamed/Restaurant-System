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
    public partial class NewUser : UserControl
    {
        static String connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
        SqlConnection con;
        public NewUser()
        {
            InitializeComponent();
            con = new SqlConnection(connection);
            textBox4.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable t = new DataTable();
            SqlCommand command = new SqlCommand("insert into Cashier(User_ID,User_Name,Password)values(@User_ID,@User_Name,@Password)", con);
            SqlCommand command2 = new SqlCommand("select * from Cashier", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            adapter.Fill(t);
            int x = t.Rows.Count + 1;
            command.Parameters.AddWithValue("@User_ID", x);
            command.Parameters.AddWithValue("@User_Name", textBox1.Text);
            command.Parameters.AddWithValue("@Password", textBox4.Text);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add Successfully ");
        }
    }
}
