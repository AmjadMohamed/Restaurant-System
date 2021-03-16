namespace Resturant
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.options1 = new Resturant.Options();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bill1 = new Resturant.Bill();
            this.options2 = new Resturant.Options();
            this.newUser1 = new Resturant.NewUser();
            this.newCustomer1 = new Resturant.NewCustomer();
            this.customer1 = new Resturant.Customer();
            this.order1 = new Resturant.Order();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.options1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 491);
            this.panel1.TabIndex = 0;
            // 
            // options1
            // 
            this.options1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.options1.Location = new System.Drawing.Point(160, 297);
            this.options1.Name = "options1";
            this.options1.Size = new System.Drawing.Size(137, 163);
            this.options1.TabIndex = 0;
            this.options1.Load += new System.EventHandler(this.options1_Load_2);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(3, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 44);
            this.button5.TabIndex = 1;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(3, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 44);
            this.button4.TabIndex = 1;
            this.button4.Text = "Options";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(3, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "Bill";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(3, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(3, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 25);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bill1
            // 
            this.bill1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bill1.Location = new System.Drawing.Point(319, 40);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(333, 439);
            this.bill1.TabIndex = 4;
            // 
            // options2
            // 
            this.options2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.options2.Location = new System.Drawing.Point(160, 297);
            this.options2.Name = "options2";
            this.options2.Size = new System.Drawing.Size(137, 163);
            this.options2.TabIndex = 9;
            this.options2.Load += new System.EventHandler(this.options2_Load);
            this.options2.VisibleChanged += new System.EventHandler(this.options2_VisibleChanged);
            // 
            // newUser1
            // 
            this.newUser1.BackColor = System.Drawing.Color.White;
            this.newUser1.Location = new System.Drawing.Point(251, 135);
            this.newUser1.Name = "newUser1";
            this.newUser1.Size = new System.Drawing.Size(528, 356);
            this.newUser1.TabIndex = 8;
            this.newUser1.Load += new System.EventHandler(this.newUser1_Load);
            // 
            // newCustomer1
            // 
            this.newCustomer1.BackColor = System.Drawing.Color.White;
            this.newCustomer1.Location = new System.Drawing.Point(193, 58);
            this.newCustomer1.Name = "newCustomer1";
            this.newCustomer1.Size = new System.Drawing.Size(528, 356);
            this.newCustomer1.TabIndex = 6;
            this.newCustomer1.Load += new System.EventHandler(this.newCustomer1_Load);
            // 
            // customer1
            // 
            this.customer1.BackColor = System.Drawing.Color.White;
            this.customer1.Location = new System.Drawing.Point(202, 51);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(550, 363);
            this.customer1.TabIndex = 2;
            this.customer1.Load += new System.EventHandler(this.customer1_Load);
            // 
            // order1
            // 
            this.order1.BackColor = System.Drawing.Color.White;
            this.order1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order1.Location = new System.Drawing.Point(160, 27);
            this.order1.Name = "order1";
            this.order1.Size = new System.Drawing.Size(681, 464);
            this.order1.TabIndex = 3;
            this.order1.Load += new System.EventHandler(this.order1_Load_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 491);
            this.Controls.Add(this.bill1);
            this.Controls.Add(this.options2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newUser1);
            this.Controls.Add(this.newCustomer1);
            this.Controls.Add(this.customer1);
            this.Controls.Add(this.order1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Order order1;
        private Bill bill1;
        private Customer customer1;
        private NewCustomer newCustomer1;
        private NewUser newUser1;
        private Options options1;
        private Options options2;
    }
}