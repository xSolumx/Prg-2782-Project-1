
namespace Prg_2782_Project_1
{
    partial class Form4
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
            this.txb_ResouceLinks = new System.Windows.Forms.TextBox();
            this.txb_ModuleDesciption = new System.Windows.Forms.TextBox();
            this.txbModuleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ModuleCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SaveModuleData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvModule = new System.Windows.Forms.DataGridView();
            this.txb_SearchModuleData = new System.Windows.Forms.TextBox();
            this.btn_SearchModuleData = new System.Windows.Forms.Button();
            this.btn_ViewModuleData = new System.Windows.Forms.Button();
            this.btn_UpdateModuleData = new System.Windows.Forms.Button();
            this.btn_DeleteModuleData = new System.Windows.Forms.Button();
            this.btn_Nav_Students = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txb_ResouceLinks);
            this.panel1.Controls.Add(this.txb_ModuleDesciption);
            this.panel1.Controls.Add(this.txbModuleName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_ModuleCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_SaveModuleData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 655);
            this.panel1.TabIndex = 0;
            // 
            // txb_ResouceLinks
            // 
            this.txb_ResouceLinks.Location = new System.Drawing.Point(131, 379);
            this.txb_ResouceLinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ResouceLinks.Name = "txb_ResouceLinks";
            this.txb_ResouceLinks.Size = new System.Drawing.Size(263, 22);
            this.txb_ResouceLinks.TabIndex = 28;
            // 
            // txb_ModuleDesciption
            // 
            this.txb_ModuleDesciption.Location = new System.Drawing.Point(131, 316);
            this.txb_ModuleDesciption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ModuleDesciption.Name = "txb_ModuleDesciption";
            this.txb_ModuleDesciption.Size = new System.Drawing.Size(263, 22);
            this.txb_ModuleDesciption.TabIndex = 27;
            // 
            // txbModuleName
            // 
            this.txbModuleName.Location = new System.Drawing.Point(131, 251);
            this.txbModuleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbModuleName.Name = "txbModuleName";
            this.txbModuleName.Size = new System.Drawing.Size(263, 22);
            this.txbModuleName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(125, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Resource links";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(125, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Module description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(125, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Module Name";
            // 
            // txb_ModuleCode
            // 
            this.txb_ModuleCode.Location = new System.Drawing.Point(131, 186);
            this.txb_ModuleCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ModuleCode.Name = "txb_ModuleCode";
            this.txb_ModuleCode.Size = new System.Drawing.Size(263, 22);
            this.txb_ModuleCode.TabIndex = 22;
            this.txb_ModuleCode.TextChanged += new System.EventHandler(this.txb_ModuleCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(125, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Module code";
            // 
            // btn_SaveModuleData
            // 
            this.btn_SaveModuleData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SaveModuleData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveModuleData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SaveModuleData.Location = new System.Drawing.Point(179, 436);
            this.btn_SaveModuleData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SaveModuleData.Name = "btn_SaveModuleData";
            this.btn_SaveModuleData.Size = new System.Drawing.Size(145, 46);
            this.btn_SaveModuleData.TabIndex = 20;
            this.btn_SaveModuleData.Text = "Save Data";
            this.btn_SaveModuleData.UseVisualStyleBackColor = false;
            this.btn_SaveModuleData.Click += new System.EventHandler(this.btn_SaveModuleData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(173, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Module Data";
            // 
            // dgvModule
            // 
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Location = new System.Drawing.Point(555, 94);
            this.dgvModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.RowHeadersWidth = 51;
            this.dgvModule.RowTemplate.Height = 24;
            this.dgvModule.Size = new System.Drawing.Size(507, 327);
            this.dgvModule.TabIndex = 2;
            // 
            // txb_SearchModuleData
            // 
            this.txb_SearchModuleData.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txb_SearchModuleData.Location = new System.Drawing.Point(555, 26);
            this.txb_SearchModuleData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_SearchModuleData.Multiline = true;
            this.txb_SearchModuleData.Name = "txb_SearchModuleData";
            this.txb_SearchModuleData.Size = new System.Drawing.Size(264, 45);
            this.txb_SearchModuleData.TabIndex = 4;
            // 
            // btn_SearchModuleData
            // 
            this.btn_SearchModuleData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SearchModuleData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchModuleData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SearchModuleData.Location = new System.Drawing.Point(909, 26);
            this.btn_SearchModuleData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SearchModuleData.Name = "btn_SearchModuleData";
            this.btn_SearchModuleData.Size = new System.Drawing.Size(144, 46);
            this.btn_SearchModuleData.TabIndex = 5;
            this.btn_SearchModuleData.Text = "Search";
            this.btn_SearchModuleData.UseVisualStyleBackColor = false;
            this.btn_SearchModuleData.Click += new System.EventHandler(this.btn_SearchModuleData_Click);
            // 
            // btn_ViewModuleData
            // 
            this.btn_ViewModuleData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ViewModuleData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewModuleData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ViewModuleData.Location = new System.Drawing.Point(573, 444);
            this.btn_ViewModuleData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ViewModuleData.Name = "btn_ViewModuleData";
            this.btn_ViewModuleData.Size = new System.Drawing.Size(133, 62);
            this.btn_ViewModuleData.TabIndex = 6;
            this.btn_ViewModuleData.Text = "View Data";
            this.btn_ViewModuleData.UseVisualStyleBackColor = false;
            this.btn_ViewModuleData.Click += new System.EventHandler(this.btn_ViewModuleData_Click);
            // 
            // btn_UpdateModuleData
            // 
            this.btn_UpdateModuleData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_UpdateModuleData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateModuleData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_UpdateModuleData.Location = new System.Drawing.Point(733, 444);
            this.btn_UpdateModuleData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UpdateModuleData.Name = "btn_UpdateModuleData";
            this.btn_UpdateModuleData.Size = new System.Drawing.Size(133, 62);
            this.btn_UpdateModuleData.TabIndex = 8;
            this.btn_UpdateModuleData.Text = "Update";
            this.btn_UpdateModuleData.UseVisualStyleBackColor = false;
            this.btn_UpdateModuleData.Click += new System.EventHandler(this.btn_UpdateModuleData_Click);
            // 
            // btn_DeleteModuleData
            // 
            this.btn_DeleteModuleData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DeleteModuleData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteModuleData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteModuleData.Location = new System.Drawing.Point(897, 444);
            this.btn_DeleteModuleData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteModuleData.Name = "btn_DeleteModuleData";
            this.btn_DeleteModuleData.Size = new System.Drawing.Size(133, 62);
            this.btn_DeleteModuleData.TabIndex = 9;
            this.btn_DeleteModuleData.Text = "Delete";
            this.btn_DeleteModuleData.UseVisualStyleBackColor = false;
            this.btn_DeleteModuleData.Click += new System.EventHandler(this.btn_DeleteModuleData_Click);
            // 
            // btn_Nav_Students
            // 
            this.btn_Nav_Students.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nav_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nav_Students.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Nav_Students.Location = new System.Drawing.Point(676, 511);
            this.btn_Nav_Students.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Nav_Students.Name = "btn_Nav_Students";
            this.btn_Nav_Students.Size = new System.Drawing.Size(251, 62);
            this.btn_Nav_Students.TabIndex = 11;
            this.btn_Nav_Students.Text = "Edit Student Data";
            this.btn_Nav_Students.UseVisualStyleBackColor = false;
            this.btn_Nav_Students.Click += new System.EventHandler(this.btn_Nav_Students_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 609);
            this.Controls.Add(this.btn_Nav_Students);
            this.Controls.Add(this.btn_DeleteModuleData);
            this.Controls.Add(this.btn_UpdateModuleData);
            this.Controls.Add(this.btn_ViewModuleData);
            this.Controls.Add(this.btn_SearchModuleData);
            this.Controls.Add(this.txb_SearchModuleData);
            this.Controls.Add(this.dgvModule);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvModule;
        private System.Windows.Forms.TextBox txb_SearchModuleData;
        private System.Windows.Forms.Button btn_SearchModuleData;
        private System.Windows.Forms.Button btn_ViewModuleData;
        private System.Windows.Forms.Button btn_UpdateModuleData;
        private System.Windows.Forms.Button btn_DeleteModuleData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SaveModuleData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_ResouceLinks;
        private System.Windows.Forms.TextBox txb_ModuleDesciption;
        private System.Windows.Forms.TextBox txbModuleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_ModuleCode;
        private System.Windows.Forms.Button btn_Nav_Students;
    }
}