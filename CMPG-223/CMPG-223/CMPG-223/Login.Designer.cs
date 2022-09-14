
namespace CMPG_223
{
    partial class frmLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblLoginHeading = new System.Windows.Forms.Label();
            this.pbLoginBack = new System.Windows.Forms.PictureBox();
            this.btnGuessLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 53);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bronze Leaque";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(412, 476);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(270, 72);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(295, 358);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(171, 38);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(295, 254);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(177, 38);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(514, 358);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(283, 39);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "Ceo@0111";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(514, 254);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(283, 39);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Text = "Ceo111";
            // 
            // lblLoginHeading
            // 
            this.lblLoginHeading.AutoSize = true;
            this.lblLoginHeading.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLoginHeading.Font = new System.Drawing.Font("Book Antiqua", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeading.Location = new System.Drawing.Point(346, 19);
            this.lblLoginHeading.Name = "lblLoginHeading";
            this.lblLoginHeading.Size = new System.Drawing.Size(419, 87);
            this.lblLoginHeading.TabIndex = 10;
            this.lblLoginHeading.Text = "Login Form";
            // 
            // pbLoginBack
            // 
            this.pbLoginBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoginBack.Image = global::CMPG_223.Properties.Resources.istockphoto_1165384568_170667a;
            this.pbLoginBack.Location = new System.Drawing.Point(0, 0);
            this.pbLoginBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLoginBack.Name = "pbLoginBack";
            this.pbLoginBack.Size = new System.Drawing.Size(1098, 751);
            this.pbLoginBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginBack.TabIndex = 9;
            this.pbLoginBack.TabStop = false;
            this.pbLoginBack.Click += new System.EventHandler(this.pbLoginBack_Click);
            // 
            // btnGuessLogin
            // 
            this.btnGuessLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessLogin.Location = new System.Drawing.Point(343, 556);
            this.btnGuessLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuessLogin.Name = "btnGuessLogin";
            this.btnGuessLogin.Size = new System.Drawing.Size(412, 72);
            this.btnGuessLogin.TabIndex = 17;
            this.btnGuessLogin.Text = "Guest Login";
            this.btnGuessLogin.UseVisualStyleBackColor = true;
            this.btnGuessLogin.Click += new System.EventHandler(this.btnGuessLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(427, 636);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(236, 39);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 751);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGuessLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLoginHeading);
            this.Controls.Add(this.pbLoginBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLoginHeading;
        private System.Windows.Forms.PictureBox pbLoginBack;
        private System.Windows.Forms.Button btnGuessLogin;
        private System.Windows.Forms.Button btnClose;
    }
}

