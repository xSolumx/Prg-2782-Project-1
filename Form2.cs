using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg_2782_Project_1
{
    public partial class Form2 : Form
    {
        Filehandler handler = new Filehandler();
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_NavLogin_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Txb_RUsername.Text=="")
            {
                MessageBox.Show("Please enter username");
            }
            else if (txb_RPassword.Text=="")
            {
                MessageBox.Show("please enter password");
            }
            else
            {
                if (txb_RPassword.Text == txb_RpasswordConfirm.Text)
                {
                    handler.writeRedgister(Txb_RUsername.Text, txb_RPassword.Text);
                    
                    
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Pasword does not match");
                    txb_RpasswordConfirm.Clear();
                    txb_RpasswordConfirm.Focus();
                }
            }
            
        }

        private void btn_RegisterClear_Click(object sender, EventArgs e)
        {
            Txb_RUsername.Clear();
            txb_RPassword.Clear();
            txb_RpasswordConfirm.Clear();
        }
    }
}
