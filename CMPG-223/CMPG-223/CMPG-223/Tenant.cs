using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CMPG_223
{
    public partial class frmTenant : Form
    {
        SqlConnection conn;
        SqlCommand commName, commSurname;
        SqlDataReader drName, drSurname;
        public string sqlStrSurname, sqlStrName;

        string connStr = @"";//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<Insert SQl Connection Path
        


        public frmTenant()
        {
            InitializeComponent();
        }

        public void fillComboBoxSurname(string sqlStrSurname)
        {
            try
            {                
                commSurname = new SqlCommand(sqlStrSurname, conn);

                drSurname = commSurname.ExecuteReader();

                while (drSurname.Read())
                {
                    cmbTenInfo.Items.Add(drSurname.GetValue(4));
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }                  
        }

        //fill combo box with names sorted by surname slected in surname combo box 
        public void fillComboBoxName(string sqlStrName)
        {
            try
            {
                commName = new SqlCommand(sqlStrName, conn);               
                drName = commName.ExecuteReader();

                //populate combo box
                while (drName.Read())
                {
                    cmbTenInfo.Items.Add(drName.GetValue(3));
                }
            }
            catch (SqlException ex)//SQlException handler
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Delete tenant selected
       private void btnDelTenant_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);

            string sqlTenConID = $"SELECT Contract_ID FROM Contract WHERE Last_Name ='" + sqlStrSurname + "' AND First_Name = '" + sqlStrName + "'";

            string sqlDelTenant = $"DELETE Tenant_ID FROM Tenant WHERE Contract_ID = '" + sqlTenConID + "'";
        }


        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HII");
        }

        //Populate combo boxes
        private void frmTenant_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);

            conn.Open();
            sqlStrSurname = $"SELECT Last_Name FROM Contract";
            sqlStrName = $"SELECT First_Name FROM Contract WHERE Last_Name = '" + sqlStrSurname +"'";           
            conn.Close();

            //Call fillcombobox methods
            fillComboBoxSurname(sqlStrSurname);
            fillComboBoxName(sqlStrName);
        }
    }
}
