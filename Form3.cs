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
    public partial class Form3 : Form
    {
        DataHandler handler = new DataHandler();
        BindingSource bs = new BindingSource();
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn_Nav_ModuleData_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void txt_Gender_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_viewStudentData_Click(object sender, EventArgs e)
        {
            dgf_StudentData.DataSource = handler.DisplayStudents();
        }

        private void txb_StudentNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_SaveStudent_Click(object sender, EventArgs e)
        {
            dgf_StudentData.DataSource = handler.SearchStudent(int.Parse(txbSearchStudent.Text));
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            if (txb_StudentNr.Text == "")
            {
                MessageBox.Show("Please Fill in all the required details");
            }
            else
            {
                handler.Add
            }
        }
    }
}
