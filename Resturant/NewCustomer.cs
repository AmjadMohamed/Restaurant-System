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
    public partial class NewCustomer : UserControl
    {
        static String connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
        SqlConnection con;
      
        public NewCustomer()
        {
            InitializeComponent();
            con = new SqlConnection(connection);

        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable t = new DataTable();
            SqlCommand command = new SqlCommand("insert into Customer(Customer_ID,Name,Phone,Address)values(@Customer_ID,@Name,@Phone,@Address)", con);
            SqlCommand command2 = new SqlCommand("select * from Customer", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            adapter.Fill(t);
            int x = t.Rows.Count+1;
            command.Parameters.AddWithValue("@Customer_ID", x);
            command.Parameters.AddWithValue("@Name", textBox2.Text);
            command.Parameters.AddWithValue("@Phone", int.Parse(textBox1.Text));
            command.Parameters.AddWithValue("@Address", textBox3.Text);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add Successfully ");
        }
    }
}
