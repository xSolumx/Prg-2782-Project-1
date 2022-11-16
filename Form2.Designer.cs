
namespace Prg_2782_Project_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_RUsername = new System.Windows.Forms.TextBox();
            this.txb_RPassword = new System.Windows.Forms.TextBox();
            this.txb_RpasswordConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_RegisterClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_NavLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(134, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // Txb_RUsername
            // 
            this.Txb_RUsername.BackColor = System.Drawing.SystemColors.Menu;
            this.Txb_RUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_RUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txb_RUsername.Location = new System.Drawing.Point(109, 128);
            this.Txb_RUsername.Name = "Txb_RUsername";
            this.Txb_RUsername.Size = new System.Drawing.Size(206, 27);
            this.Txb_RUsername.TabIndex = 2;
            // 
            // txb_RPassword
            // 
            this.txb_RPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_RPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_RPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txb_RPassword.Location = new System.Drawing.Point(109, 192);
            this.txb_RPassword.Name = "txb_RPassword";
            this.txb_RPassword.Size = new System.Drawing.Size(206, 27);
            this.txb_RPassword.TabIndex = 3;
            // 
            // txb_RpasswordConfirm
            // 
            this.txb_RpasswordConfirm.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_RpasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_RpasswordConfirm.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txb_RpasswordConfirm.Location = new System.Drawing.Point(109, 255);
            this.txb_RpasswordConfirm.Name = "txb_RpasswordConfirm";
            this.txb_RpasswordConfirm.Size = new System.Drawing.Size(206, 27);
            this.txb_RpasswordConfirm.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(105, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(108, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(105, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(109, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_RegisterClear
            // 
            this.btn_RegisterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegisterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_RegisterClear.Location = new System.Drawing.Point(109, 362);
            this.btn_RegisterClear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RegisterClear.Name = "btn_RegisterClear";
            this.btn_RegisterClear.Size = new System.Drawing.Size(206, 40);
            this.btn_RegisterClear.TabIndex = 9;
            this.btn_RegisterClear.Text = "Clear";
            this.btn_RegisterClear.UseVisualStyleBackColor = true;
            this.btn_RegisterClear.Click += new System.EventHandler(this.btn_RegisterClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(148, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "I have an acount";
            // 
            // btn_NavLogin
            // 
            this.btn_NavLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_NavLogin.BackgroundImage = global::Prg_2782_Project_1.Properties.Resources.download;
            this.btn_NavLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_NavLogin.FlatAppearance.BorderSize = 0;
            this.btn_NavLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NavLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NavLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NavLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NavLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_NavLogin.Location = new System.Drawing.Point(151, 434);
            this.btn_NavLogin.Name = "btn_NavLogin";
            this.btn_NavLogin.Size = new System.Drawing.Size(110, 30);
            this.btn_NavLogin.TabIndex = 11;
            this.btn_NavLogin.Text = "Login";
            this.btn_NavLogin.UseVisualStyleBackColor = false;
            this.btn_NavLogin.Click += new System.EventHandler(this.btn_NavLogin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(417, 547);
            this.Controls.Add(this.btn_NavLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_RegisterClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_RpasswordConfirm);
            this.Controls.Add(this.txb_RPassword);
            this.Controls.Add(this.Txb_RUsername);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_RUsername;
        private System.Windows.Forms.TextBox txb_RPassword;
        private System.Windows.Forms.TextBox txb_RpasswordConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_RegisterClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_NavLogin;
    }
}