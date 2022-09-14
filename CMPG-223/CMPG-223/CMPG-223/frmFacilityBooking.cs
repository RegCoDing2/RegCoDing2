//frmFacility Correct
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
using System.Data;

namespace CMPG_223
{

    public partial class frmFacilityBooking : Form
    {
        string facility = "";
        string APConStr = @"Data Source=LAPTOP-5TBP2DI1;Initial Catalog=Bronze_League;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//<<<<<<<<<<<<<<<<<<<<<<<<<< add con string
        SqlConnection APCon = new SqlConnection(@"Data Source=LAPTOP-5TBP2DI1;Initial Catalog=Bronze_League;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader drCmbBox, drFac, reader;

        //fill method to populate combo box
        public void fillComboBox(string sqlstr)
        {         
            try
            {
                APCon = new SqlConnection(APConStr);
                APCon.Open();

                comm = new SqlCommand(sqlstr, APCon);
                drCmbBox = comm.ExecuteReader();

                //fill ComboBox combo box with filtered data
                while (drCmbBox.Read())
                {
                    cmbApartNum.Items.Add(drCmbBox.GetValue(0));//<<<<<<<<Change num
                }

                APCon.Close();
            }
            catch (SqlException ex)//Sql Exception catch
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbApartNum.Items.Clear();
            if (rbBlokA.Checked)
            {             
                // Filter for Blok A Apartment
                string sqlstr = $"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'A%'";
                fillComboBox(sqlstr);                    
                
            }
            else
            {              
                // Filter for Blok B Apartment
                string sqlstr = $"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'B%'";
                fillComboBox(sqlstr);                
            }
        }

        private void rbSwimmingPool_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmFacilityBooking_Load(object sender, EventArgs e)
        {
            try
            {
                APCon.Open();

                comm = new SqlCommand("SELECT Facility_name FROM Facility", APCon);

                reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    cbFacilities.Items.Add(reader.GetValue(0));
                }

                APCon.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cbFacilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            facility = cbFacilities.SelectedItem.ToString();
        }

        public frmFacilityBooking()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string apartNum;

            apartNum = cmbApartNum.SelectedItem.ToString();


            // Apartment Connection
            string apnum = "";
            APCon = new SqlConnection(APConStr);
            APCon.Open();
            string sqlApartIDstr = $"SELECT Apartment_ID FROM Apartment WHERE Apartment_Num = " + apartNum +"";

            APCon.Close();

            // Facility Connection
            SqlConnection FACon = new SqlConnection(APConStr);

            string sqlFacStr = "";
            try
            {               
                FACon.Open();
                sqlFacStr = $"SELECT Facility_ID FROM Facility WHERE Facility_Name = " + facility;
                FACon.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            //Facility in Apartment
            SqlConnection FAInAPCon = new SqlConnection(APConStr);
            FAInAPCon.Open();

            string sqlInsert = $"INSERT INTO Facility_in_Apartment (Apartment_ID, Facility_ID) VALUES ({sqlApartIDstr}, {sqlFacStr}) ";

            comm = new SqlCommand(sqlInsert, FAInAPCon);
            comm.ExecuteNonQuery();

            FAInAPCon.Close();

            MessageBox.Show("Facility has been booked");
            

        }
    }
}
