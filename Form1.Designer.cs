
namespace Prg_2782_Project_1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_ClearLogin = new System.Windows.Forms.Button();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_NavRedgister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(138, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(102, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(105, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Login.Location = new System.Drawing.Point(105, 259);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(222, 40);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_ClearLogin
            // 
            this.btn_ClearLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ClearLogin.Location = new System.Drawing.Point(105, 304);
            this.btn_ClearLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ClearLogin.Name = "btn_ClearLogin";
            this.btn_ClearLogin.Size = new System.Drawing.Size(222, 40);
            this.btn_ClearLogin.TabIndex = 4;
            this.btn_ClearLogin.Text = "Clear";
            this.btn_ClearLogin.UseVisualStyleBackColor = true;
            this.btn_ClearLogin.Click += new System.EventHandler(this.btn_ClearLogin_Click);
            // 
            // txb_Username
            // 
            this.txb_Username.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_Username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txb_Username.Location = new System.Drawing.Point(105, 148);
            this.txb_Username.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(226, 23);
            this.txb_Username.TabIndex = 5;
            this.txb_Username.Text = "admin";
            // 
            // txb_Password
            // 
            this.txb_Password.BackColor = System.Drawing.SystemColors.Menu;
            this.txb_Password.Location = new System.Drawing.Point(105, 210);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(222, 23);
            this.txb_Password.TabIndex = 6;
            this.txb_Password.Text = "1234";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(125, 379);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Don\'t have an acount";
            // 
            // btn_NavRedgister
            // 
            this.btn_NavRedgister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_NavRedgister.BackgroundImage = global::Prg_2782_Project_1.Properties.Resources.download;
            this.btn_NavRedgister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_NavRedgister.FlatAppearance.BorderSize = 0;
            this.btn_NavRedgister.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NavRedgister.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NavRedgister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NavRedgister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NavRedgister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_NavRedgister.Location = new System.Drawing.Point(144, 402);
            this.btn_NavRedgister.Name = "btn_NavRedgister";
            this.btn_NavRedgister.Size = new System.Drawing.Size(131, 28);
            this.btn_NavRedgister.TabIndex = 9;
            this.btn_NavRedgister.Text = "Register";
            this.btn_NavRedgister.UseVisualStyleBackColor = false;
            this.btn_NavRedgister.Click += new System.EventHandler(this.btn_NavRedgister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(430, 542);
            this.Controls.Add(this.btn_NavRedgister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.btn_ClearLogin);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_ClearLogin;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.TextBox txb_Password;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_NavRedgister;
    }
}

