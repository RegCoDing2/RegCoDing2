//Login Correct 10-09-2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG_223
{
    public partial class frmLogin : Form
    {
        public static int authorityLevel;
        string username, password;

        string chCeoUser = "Ceo111", chSecUser = "Sec123";
        string chCeoPass = "Ceo@0111", chSecPass = "Sec#1023";

        private void btnGuessLogin_Click(object sender, EventArgs e)
        {
            //Client has level 3 authority
            authorityLevel = 3;
            frmMainMenu main = new frmMainMenu();
            main.ShowDialog();
            this.Close();
        }

        private void pbLoginBack_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            username = txtUsername.Text;
            password = txtPassword.Text;

            if ((username == chCeoUser) || (username == chSecUser))
            {
                if (password == chCeoPass)
                {
                    frmMainMenu main = new frmMainMenu();
                    main.ShowDialog();

                    authorityLevel = 1;
                    this.Close();
                }
                else if (password == chSecPass)
                {
                    frmMainMenu Main = new frmMainMenu();
                    Main.ShowDialog();

                    authorityLevel = 2;
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Please enter a password!");
                }

            }
            else
            {
                MessageBox.Show("Username incorrect!");
            }

        }


        public frmLogin()
        {
            InitializeComponent();
        }

        private void apartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApartments newMDIChild = new frmApartments();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
