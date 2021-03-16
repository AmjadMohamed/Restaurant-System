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
    public partial class Bill : UserControl
    {
        int user_id;
        public string my;
        static String connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
        SqlConnection con;
        DataTable t;
        public Bill()
        {
            InitializeComponent();
            con = new SqlConnection(connection);
        }
     
        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            kara_sama();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void kara_sama() {
            con.Open();
            try
            {
                //   DateTimePicker dateTimePicker = new DateTimePicker();
                //  label2.Text = dateTimePicker.Value.Date+""; 
                string query_name = "select Name,Price from Product where Product_ID in(select Product_ID from Order_Details  where Sell_ID =(select top 1 Sell_ID from  Order_Details order by Sell_ID desc ))";
                string query_num = "select Quantity from Order_Details where Product_ID in(select Product_ID from Product )and Sell_ID =(select top 1 Sell_ID from  Order_Details order by Sell_ID desc )";
                DataTable c_name = new DataTable();
                SqlCommand command_cus = new SqlCommand("select Name from Customer", con);
                SqlDataAdapter adapter4 = new SqlDataAdapter(command_cus);
                adapter4.Fill(c_name);

                DataTable dt_name = new DataTable();
                DataTable dt_quantity = new DataTable();
                SqlCommand command_name = new SqlCommand(query_name, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command_name);
                adapter.Fill(dt_name);
                SqlCommand command_quantity = new SqlCommand(query_num, con);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command_quantity);
                adapter2.Fill(dt_quantity);
                textBox1.Text = " اسم العميل :" + c_name.Rows[c_name.Rows.Count - 1][0] + "\n\r";
                textBox2.Text = "\r\n";
                textBox3.Text = "\r\n";


                for (int i = 0; i < dt_quantity.Rows.Count; i++)
                {
                    textBox1.Text +=" "+ dt_name.Rows[i][0] + "\r\n ";
                    textBox2.Text += dt_quantity.Rows[i][0] + "\r\n ";
                    textBox3.Text += dt_name.Rows[i][1] + "\r\n ";

                }
                DataTable bill = new DataTable();
                SqlCommand command_bill = new SqlCommand("select * from bill", con);
                SqlDataAdapter adapter3 = new SqlDataAdapter(command_bill);
                adapter3.Fill(bill);
                num_order.Text = "num order :" + bill.Rows[bill.Rows.Count - 1][0] + "";
                date.Text = bill.Rows[bill.Rows.Count - 1][4] + "";
                label1.Text = "total :" + bill.Rows[bill.Rows.Count - 1][3] + "";
            }
            catch (Exception kara)
            {
            }
            con.Close();
        }
        private void Bill_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible==true)
            kara_sama();
        
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }
    }
}
