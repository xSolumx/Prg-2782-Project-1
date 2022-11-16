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
    public partial class Form4 : Form
    {
        DataHandler handler = new DataHandler();
        BindingSource bs = new BindingSource();
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_NavM_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nav_Students_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void btn_ViewModuleData_Click(object sender, EventArgs e)
        {
            dgvModule.DataSource = handler.DisplayModule();
        }

        private void btn_SaveModuleData_Click(object sender, EventArgs e)
        {
            if (txb_ModuleCode.Text == "" || txb_ModuleDesciption.Text == "" || txbModuleName.Text == "")
            {
                MessageBox.Show("Please enter all required details");
            }
            else
            {
                handler.AddModule(txb_ModuleCode.Text, txbModuleName.Text, txb_ModuleDesciption.Text, txb_ResouceLinks.Text);
                MessageBox.Show("Module has been added succesfully");
                dgvModule.ClearSelection();
                handler.DisplayModule();
            }
          
        }

        private void btn_DeleteModuleData_Click(object sender, EventArgs e)
        {
            handler.DeleteModule(txb_ModuleCode.Text);
            MessageBox.Show("Module has been deleted");
            
        }

        private void btn_UpdateModuleData_Click(object sender, EventArgs e)
        {
            handler.UpdateModule(txb_ModuleCode.Text, txbModuleName.Text, txb_ModuleDesciption.Text, txb_ResouceLinks.Text);
            MessageBox.Show("Module has been updated");
        }

        private void btn_SearchModuleData_Click(object sender, EventArgs e)
        {
            dgvModule.DataSource = handler.SearchModule(txb_SearchModuleData.Text);
        }

        private void txb_ModuleCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
