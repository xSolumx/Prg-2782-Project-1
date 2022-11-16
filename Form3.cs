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
                try
                {
                    handler.AddStudent(int.Parse(txb_StudentNr.Text), txb_StudentName.Text, txb_StudentSurname.Text, txb_DOB.Text, txb_Gender.Text, txb_PhoneNr.Text, txb_Address.Text, txbModuleCodes.Text);
                    MessageBox.Show("Student added to Database");
                    dgf_StudentData.DataSource = handler.DisplayStudents();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid date");
                    throw;
                }

            }
        }

        private void btn_UpdateStudentData_Click(object sender, EventArgs e)
        {
            if (txb_StudentNr.Text == "")
            {
                MessageBox.Show("Please Fill in all the required details");
            }
            else
            {
                try
                {
                    handler.UpdateStudent(int.Parse(txb_StudentNr.Text), txb_StudentName.Text, txb_StudentSurname.Text, txb_DOB.Text, txb_Gender.Text, txb_PhoneNr.Text, txb_Address.Text, txbModuleCodes.Text);
                    MessageBox.Show("Student details Updated");
                    dgf_StudentData.DataSource = handler.DisplayStudents();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid date");
                    throw;
                }

            }
        }

        private void dgf_StudentData_SelectionChanged(object sender, EventArgs e)
        {
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv != null && dgv.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgv.SelectedRows[0];
                    if (row != null)
                    {
                        txb_StudentNr.Text = row.Cells[0].Value.ToString();
                        txb_StudentName.Text = row.Cells[1].Value.ToString();
                        txb_StudentSurname.Text = row.Cells[2].Value.ToString();
                        txb_DOB.Text = row.Cells[3].Value.ToString();
                        txb_Gender.Text = row.Cells[4].Value.ToString();
                        txb_PhoneNr.Text = row.Cells[5].Value.ToString();
                        txb_Address.Text = row.Cells[6].Value.ToString();
                        txbModuleCodes.Text = row.Cells[7].Value.ToString();


                    }
                }
            }
        }

        private void btn_DeleteStudentData_Click(object sender, EventArgs e)
        {
            try
            {
                handler.DeleteStudent(int.Parse(txb_StudentNr.Text));
                MessageBox.Show("Student has been deleted");
                dgf_StudentData.DataSource = handler.DisplayStudents();

            }
            catch (Exception)
            {

            }
        }
    }

}
