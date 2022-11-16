using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prg_2782_Project_1
{
    
    public partial class Form1 : Form
    {
        Filehandler handler = new Filehandler();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_NavRedgister_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txb_Username.Text=="")
            {
                MessageBox.Show("Please enter username");
            }
            else if (txb_Password.Text == "")
            {
                MessageBox.Show("Please enter password");
            }
            else
            {
                try
                {
                   
                    
                    if (txb_Username.Text!="Admin"& txb_Password.Text!="1234")
                    {
                        MessageBox.Show("Username or password is incorrect");
                        txb_Username.Clear();
                        txb_Password.Clear();
                        txb_Username.Focus();
                     
                    }
                    else
                    {
                        
                        Form3 f3 = new Form3();
                        f3.Show();
                        this.Hide();
                    }
                }

                catch (Exception f)
                {

                    MessageBox.Show(f.Message);
                }
            }

       
            
        }

        private void btn_ClearLogin_Click(object sender, EventArgs e)
        {
            txb_Username.Clear();
            txb_Password.Clear();

            txb_Username.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
