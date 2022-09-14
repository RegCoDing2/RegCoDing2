
namespace CMPG_223
{
    partial class frmMainMenu
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.msApartment = new System.Windows.Forms.ToolStripMenuItem();
            this.msFacilities = new System.Windows.Forms.ToolStripMenuItem();
            this.msBookFac = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainFacil = new System.Windows.Forms.ToolStripMenuItem();
            this.msReport = new System.Windows.Forms.ToolStripMenuItem();
            this.msContract = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLogout,
            this.msApartment,
            this.msFacilities,
            this.msReport,
            this.msContract});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(976, 28);
            this.MainMenuStrip.TabIndex = 9;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // msLogout
            // 
            this.msLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.msLogout.Name = "msLogout";
            this.msLogout.Size = new System.Drawing.Size(73, 24);
            this.msLogout.Text = "Logout";
            this.msLogout.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // msApartment
            // 
            this.msApartment.Name = "msApartment";
            this.msApartment.Size = new System.Drawing.Size(100, 24);
            this.msApartment.Text = "Apartments";
            this.msApartment.Click += new System.EventHandler(this.apartmentsToolStripMenuItem_Click);
            // 
            // msFacilities
            // 
            this.msFacilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msBookFac,
            this.msMainFacil});
            this.msFacilities.Name = "msFacilities";
            this.msFacilities.Size = new System.Drawing.Size(79, 24);
            this.msFacilities.Text = "Facilities";
            // 
            // msBookFac
            // 
            this.msBookFac.Name = "msBookFac";
            this.msBookFac.Size = new System.Drawing.Size(199, 26);
            this.msBookFac.Text = "Book Facility";
            this.msBookFac.Click += new System.EventHandler(this.msBookFac_Click);
            // 
            // msMainFacil
            // 
            this.msMainFacil.Name = "msMainFacil";
            this.msMainFacil.Size = new System.Drawing.Size(199, 26);
            this.msMainFacil.Text = "Maintain Facility";
            this.msMainFacil.Click += new System.EventHandler(this.msMainFacil_Click);
            // 
            // msReport
            // 
            this.msReport.Name = "msReport";
            this.msReport.Size = new System.Drawing.Size(68, 24);
            this.msReport.Text = "Report";
            this.msReport.Click += new System.EventHandler(this.msReport_Click);
            // 
            // msContract
            // 
            this.msContract.Name = "msContract";
            this.msContract.Size = new System.Drawing.Size(79, 24);
            this.msContract.Text = "Contract";
            this.msContract.Click += new System.EventHandler(this.msContract_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 601);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        private System.Windows.Forms.ToolStripMenuItem msApartment;
        private System.Windows.Forms.ToolStripMenuItem msFacilities;
        private System.Windows.Forms.ToolStripMenuItem msReport;
        private System.Windows.Forms.ToolStripMenuItem msContract;
        private System.Windows.Forms.ToolStripMenuItem msBookFac;
        private System.Windows.Forms.ToolStripMenuItem msMainFacil;
    }
}