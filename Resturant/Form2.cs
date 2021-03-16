using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Form2 : Form
    {
       public int user_id;
        public Form2()
        {
            
            InitializeComponent();
           customer1.Show();
           order1.Hide();
            bill1.Hide();
            options2.Hide();
            newUser1.Hide();
            newCustomer1.Visible=false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            customer1.Visible = true;
            order1.Hide();
            bill1.Hide();
            options2.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void customer1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order1.Visible = true;
            order1.user_ID(user_id);
          //  order1.BringToFront();
            newUser1.Hide();
            newCustomer1.Hide();
            options2.Hide();
            customer1.Hide();
            bill1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bill1.Visible=true;
          //  bill1.BringToFront();
            order1.Hide();
            options2.Hide();
               newCustomer1.Hide();
            customer1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            options2.Visible = !options2.Visible;
          
        }

        private void options1_Load(object sender, EventArgs e)
        {
            newUser1.Hide();
            bill1.Hide();
            order1.Hide();
            customer1.Hide();
            options2.Hide();
        }

        private void newCustomer1_Load(object sender, EventArgs e)
        {

        }

        private void options1_Load_1(object sender, EventArgs e)
        {
            //newUser1.BringToFront();
            bill1.Hide();
            order1.Hide();
            customer1.Hide();
        }

        private void newUser1_Load(object sender, EventArgs e)
        {

        }

        private void order1_Load(object sender, EventArgs e)
        {

        }

        private void order1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void options1_Load_2(object sender, EventArgs e)
        {

        }

        private void options2_Load(object sender, EventArgs e)
        {
            newUser1.Hide();
            bill1.Hide();
            order1.Hide();
            customer1.Hide();
        }

        private void options2_VisibleChanged(object sender, EventArgs e)
        {
            if (options2.Visible == true)
            {
                newUser1.Hide();
                bill1.Hide();
                order1.Hide();
                customer1.Hide();
            }
        }

    }

}
