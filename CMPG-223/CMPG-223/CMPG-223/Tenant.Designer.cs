
namespace CMPG_223
{
    partial class frmTenant
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
            this.pbBaclground = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAddTenant = new System.Windows.Forms.Button();
            this.btnUpdateTenat = new System.Windows.Forms.Button();
            this.btnDelTenant = new System.Windows.Forms.Button();
            this.gbSurname = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbTenInfo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaclground)).BeginInit();
            this.gbSurname.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBaclground
            // 
            this.pbBaclground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBaclground.Location = new System.Drawing.Point(0, 0);
            this.pbBaclground.Name = "pbBaclground";
            this.pbBaclground.Size = new System.Drawing.Size(748, 599);
            this.pbBaclground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBaclground.TabIndex = 0;
            this.pbBaclground.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(224, 33);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(266, 38);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Maintain Tenants";
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTenant.Location = new System.Drawing.Point(65, 307);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(175, 58);
            this.btnAddTenant.TabIndex = 2;
            this.btnAddTenant.Text = "Add Tenant";
            this.btnAddTenant.UseVisualStyleBackColor = true;
            this.btnAddTenant.Click += new System.EventHandler(this.btnAddTenant_Click);
            // 
            // btnUpdateTenat
            // 
            this.btnUpdateTenat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTenat.Location = new System.Drawing.Point(65, 390);
            this.btnUpdateTenat.Name = "btnUpdateTenat";
            this.btnUpdateTenat.Size = new System.Drawing.Size(175, 58);
            this.btnUpdateTenat.TabIndex = 3;
            this.btnUpdateTenat.Text = "Update Tenant";
            this.btnUpdateTenat.UseVisualStyleBackColor = true;
            // 
            // btnDelTenant
            // 
            this.btnDelTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTenant.Location = new System.Drawing.Point(65, 476);
            this.btnDelTenant.Name = "btnDelTenant";
            this.btnDelTenant.Size = new System.Drawing.Size(175, 58);
            this.btnDelTenant.TabIndex = 4;
            this.btnDelTenant.Text = "Delete Tenant";
            this.btnDelTenant.UseVisualStyleBackColor = true;
            this.btnDelTenant.Click += new System.EventHandler(this.btnDelTenant_Click);
            // 
            // gbSurname
            // 
            this.gbSurname.Controls.Add(this.lblName);
            this.gbSurname.Controls.Add(this.lblSurname);
            this.gbSurname.Controls.Add(this.comboBox1);
            this.gbSurname.Controls.Add(this.cmbTenInfo);
            this.gbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSurname.Location = new System.Drawing.Point(65, 110);
            this.gbSurname.Name = "gbSurname";
            this.gbSurname.Size = new System.Drawing.Size(342, 169);
            this.gbSurname.TabIndex = 5;
            this.gbSurname.TabStop = false;
            this.gbSurname.Text = "Select Tenant Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(29, 46);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(98, 25);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // cmbTenInfo
            // 
            this.cmbTenInfo.FormattingEnabled = true;
            this.cmbTenInfo.Location = new System.Drawing.Point(131, 46);
            this.cmbTenInfo.Name = "cmbTenInfo";
            this.cmbTenInfo.Size = new System.Drawing.Size(180, 33);
            this.cmbTenInfo.TabIndex = 0;
            // 
            // frmTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 599);
            this.Controls.Add(this.gbSurname);
            this.Controls.Add(this.btnDelTenant);
            this.Controls.Add(this.btnUpdateTenat);
            this.Controls.Add(this.btnAddTenant);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pbBaclground);
            this.Name = "frmTenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenant";
            this.Load += new System.EventHandler(this.frmTenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaclground)).EndInit();
            this.gbSurname.ResumeLayout(false);
            this.gbSurname.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBaclground;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAddTenant;
        private System.Windows.Forms.Button btnUpdateTenat;
        private System.Windows.Forms.Button btnDelTenant;
        private System.Windows.Forms.GroupBox gbSurname;
        private System.Windows.Forms.ComboBox cmbTenInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
    }
}