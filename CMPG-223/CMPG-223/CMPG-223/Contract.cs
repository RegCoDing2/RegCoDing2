using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Net;



namespace CMPG_223
{

    public partial class Contract : Form
    {
        string apart_num = "";
        SqlConnection conn;
        string ApConStr = @"Data Source=LAPTOP-5TBP2DI1;Initial Catalog=Bronze_League;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//<<<< change con str
        SqlCommand comm;
        SqlDataAdapter adap;
        SqlDataReader drCmBox;
        
       

        public Contract()
        {
            InitializeComponent();
        }

        public void fillcombobox(string sqlstr)
        {
            try
            {
                string apnum = @"";
                conn = new SqlConnection(ApConStr);

                conn.Open();

                comm = new SqlCommand(sqlstr, conn);
                drCmBox = comm.ExecuteReader();

                while (drCmBox.Read())
                {
                    cmbAparNum.Items.Add(drCmBox.GetValue(0));
                }

                conn.Close();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//>>>>>>>>>>>>>Button Sign
            string first_name , last_name , chosen_block, apart_num;
            string contact_num;           

            DateTime sign_date = new DateTime();
            DateTime end_date = new DateTime();

            first_name = txtbx_Fname.Text;
            last_name = txtbx_lname.Text;
            contact_num = txtbx_contnum.Text;

            if (rdbtn_A.Checked)
            {
                chosen_block = "Block A";
                apart_num = Convert.ToString(cmbAparNum.SelectedItem);
                lstbx_ViewInfo.Items.Add("Contact number:" + contact_num);
                lstbx_ViewInfo.Items.Add("Apartment number:" + apart_num);
            }

            else if (rdbtn_B.Checked)
            {
                chosen_block = "Block B";
                apart_num = Convert.ToString(cmbAparNum.SelectedItem);
                lstbx_ViewInfo.Items.Add("Contact number:" + contact_num);
                lstbx_ViewInfo.Items.Add("Apartment number :" + apart_num);
            }
            else 
            {
                MessageBox.Show("please indicate block ");
            }
            
            lstbx_ViewInfo.Items.Add("First name:" + first_name);
            lstbx_ViewInfo.Items.Add("Last name:" + last_name);
            lstbx_ViewInfo.Items.Add("Contact number:" + contact_num);
            lstbx_ViewInfo.Items.Add("Signed date:" + sign_date);
            lstbx_ViewInfo.Items.Add("End date:" + end_date);

            try
            {
                conn.Open();

                string sqlDelTenID = $"SELECT Tenant_ID FROM Tenant";
                string sqlDel = $"INSERT INTO Contract()";


            }   catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            SqlCommand comfetch = new SqlCommand();
            SqlCommand command = new SqlCommand("INSERT INTO Contract (First name,Last name,Contact number,Sign date,End date) VALUES ('" + txtbx_Fname.Text + "', '" + txtbx_lname.Text + "', " + " '" + txtbx_contnum.Text + "'" +" '" + sign_date+ "'" + " '" + end_date + "'");
            SqlCommand command1 = new SqlCommand($"INSERT INTO Tenant (Tenant_ID, Contract_ID) VALUES (Contract_ID)");
            SqlCommand command2 = new SqlCommand($"INSERT INTO Apartment (Apartment ID, Tenant ID ,Apartment number) VALUES ('{Convert.ToString(cmbAparNum.SelectedItem)}')");
            conn.Close();


        }

        private void btn_SignDate_Click(object sender, EventArgs e)
        {
            DateTime sign_date = DateTime.Today;
            DateTime end_date = sign_date.AddDays(365);
        }

        private void txtbx_lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(ApConStr);
            //conn.ConnectionString = "Data Source = SNIPESKRULLE; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            conn.Open();
           // SqlCommand command = new SqlCommand("DELETE Last_Name FROM  Contract WHERE Last_Name =" + txtbx_contnum.Text);
            SqlCommand command1 = new SqlCommand("DELETE Tenant_ID FROM Apartment");
            SqlCommand command2 = new SqlCommand("DELETE Contract_ID FROM Contract");
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void rdbtn_A_CheckedChanged(object sender, EventArgs e)
        {
            cmbAparNum.Items.Clear();
            if (rdbtn_A.Checked)
            {
                string sqlstr = ($"SELECT  Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'A%'");
                fillcombobox(sqlstr);   
            }
            else
            {
                string sqlstr = ($"SELECT  Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'B%'");
                fillcombobox(sqlstr);
            }

            conn.Close();
        }

        private void rdbtn_B_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void grpbx_ChooseBlock_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_EndDate_Click(object sender, EventArgs e)
        {

        }

        private void cmbAparNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
