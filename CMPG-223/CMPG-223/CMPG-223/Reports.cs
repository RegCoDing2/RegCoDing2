using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //Including Client to use Sql

namespace CMPG_223
{
    public partial class frmReports : Form
    {
        private //Creation of field to store radiobutton choice for data ordering
            string sOrderBy, sTableName, sHeading;
            bool asc = false, multi = false;

        string sql;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5TBP2DI1;Initial Catalog=Bronze_League;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataReader reader;
            SqlCommand comm;

        public frmReports()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes the form
        }

        private void rbSpecial_CheckedChanged_1(object sender, EventArgs e) //Makes the following radiobuttons visible
        {
            if (rbSpecial.Checked)
            {
                rbTenantPerApartment.Visible = true;
                gbReportTypes.Visible = false;
            }
            else
            {
                gbReportTypes.Visible = true;

                rbTenantPerApartment.Visible = false;
            }            
        }

        private void rbApartmentDetails_CheckedChanged(object sender, EventArgs e)
        {
            if(rbApartmentDetails.Checked)
            {
                lblOrderBy.Visible = true;
                cbOrderBy.Visible = true;

                cbOrderBy.Items.Clear();

                multi = false;
                sTableName = "Apartment";

                sHeading = "Apartment Details";

                sql = "SELECT * FROM Apartment";

                cbOrderBy.Items.Add("Apartment_ID");
                cbOrderBy.Items.Add("Contract_ID");
                cbOrderBy.Items.Add("Apartment_Num");
            }
            else if(rbContractDetails.Checked)
            {
                lblOrderBy.Visible = true;
                cbOrderBy.Visible = true;

                cbOrderBy.Items.Clear();

                multi = false;

                sTableName = "Contract";

                sHeading = "Contract Details";

                sql = "SELECT * FROM Contract";

                cbOrderBy.Items.Add("Contract_ID");
                cbOrderBy.Items.Add("Sign_Date");
                cbOrderBy.Items.Add("End_Date");
                cbOrderBy.Items.Add("First_Name");
                cbOrderBy.Items.Add("Last_Name");
                cbOrderBy.Items.Add("Contact_Num");
            }
            else if(rbFacilityDeatils.Checked)
            {
                lblOrderBy.Visible = true;
                cbOrderBy.Visible = true;

                cbOrderBy.Items.Clear();

                multi = false;

                sTableName = "Facility";

                sHeading = "Facility Details";

                sql = "SELECT * FROM Facility";

                cbOrderBy.Items.Add("Facility_ID");
                cbOrderBy.Items.Add("Facility_Name");
            }
            else if(rbFacilityInApartment.Checked)
            {
                lblOrderBy.Visible = true;
                cbOrderBy.Visible = true;

                cbOrderBy.Items.Clear();

                multi = false;

                sTableName = "Facility_in_Apartment";

                sHeading = "Facility_in_Apartment Details";

                sql = "SELECT * FROM Facility_in_Apartment";

                cbOrderBy.Items.Add("Apartment_ID");
                cbOrderBy.Items.Add("Facility_ID");
            }
        }

        private void rbASC_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbASC.Checked)
            {
                asc = true;

                btnGenerate.Visible = true;

                sql += " ASC";
            }
            else
            {

                asc = false;

                btnGenerate.Visible = true;

                sql += " DESC";
            }
        }

        private void btnAnother_Click(object sender, EventArgs e)
        {
            
        }

        private void cbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            sOrderBy = cbOrderBy.SelectedItem.ToString();

            sql += " ORDER BY " + sOrderBy;

            rbASC.Visible = true;
            rbDESC.Visible = true;
        }

        private void rbTenantPerApartment_CheckedChanged_1(object sender, EventArgs e)
        {
            lblOrderBy.Visible = true;
            rbASC.Visible = true;
            rbDESC.Visible = true;

            gbReportTypes.Visible = false;

            multi = true;

            sHeading = "Tenant per Apartment";

            cbOrderBy.Items.Add("Contract_ID");
            cbOrderBy.Items.Add("First_Name");
            cbOrderBy.Items.Add("Last_Name");
            cbOrderBy.Items.Add("Apartment_Num");
        }

        private void btnGenerate_Click(object sender, EventArgs e)  //Button that generates the report
        {
            if (multi)
            {
                try
                {
                    lbOutput.Items.Add("\t\t\t\t" + sHeading);
                    lbOutput.Items.Add(DateTime.Today.ToString("yyyy/mm/dd"));
                    lbOutput.Items.Add("Page 1 of 1");
                    lbOutput.Items.Add("\n");

                    con.Open();

                    SqlCommand comm = new SqlCommand("SELECT c.Contract_ID, c.First_Name, c.Last_Name, a.Apartment_Num FROM Contract c, Apartment a WHERE c.Contract_ID = a.Contract_ID", con);

                    reader = comm.ExecuteReader();

                    while(reader.Read())
                    {
                        lbOutput.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t"+ reader.GetValue(2) + "\t" + reader.GetValue(2));
                    }

                    lbOutput.Items.Add("\n");
                    lbOutput.Items.Add("\t\t\t\tXXXEND OF REPORTXXX");

                    con.Close();

                    btnAnother.Visible = true;
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                try
                {
                    lbOutput.Items.Add("\t\t\t\t" + sHeading);
                    lbOutput.Items.Add(DateTime.Today.ToString("yyyy/mm/dd"));
                    lbOutput.Items.Add("Page 1 of 1");
                    lbOutput.Items.Add("\n");

                    con.Open();

                    SqlCommand comm = new SqlCommand(sql, con);

                    reader = comm.ExecuteReader();

                    if (sTableName == "Apartment")
                    {
                        lbOutput.Items.Add("\nApartment ID\tContract ID\t\tApartment Num");

                        while (reader.Read())
                        {
                            lbOutput.Items.Add(reader.GetValue(0) + "\t\t" + reader.GetValue(1) + "\t\t" + reader.GetValue(2));
                        }
                    }
                    else if(sTableName == "Contract")
                    {
                        lbOutput.Items.Add("\nContract ID\tSign Date\t\tEnd Date\t\tFirst Name\tLast Name\tContact Number");

                        while (reader.Read())
                        {
                            lbOutput.Items.Add(reader.GetValue(0) + "\t\t" + reader.GetValue(1).ToString() + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3) + "\t" + reader.GetValue(4) + "\t" + reader.GetValue(5));
                        }
                    }
                    else if(sTableName == "Facility")
                    {
                        lbOutput.Items.Add("\nFacility ID\t\tFacility Name");

                        while (reader.Read())
                        {
                            lbOutput.Items.Add(reader.GetValue(0) + "\t\t" + reader.GetValue(1));
                        }
                    }
                    else if(sTableName == "Facility_in_Apartment")
                    {
                        lbOutput.Items.Add("\nApartment ID\tFacility ID");

                        while (reader.Read())
                        {
                            lbOutput.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1));
                        }
                    }

                    lbOutput.Items.Add("\n");
                    lbOutput.Items.Add("\t\t\t\tXXXEND OF REPORTXXX");
                    con.Close();

                    btnAnother.Visible = true;
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            
        }
    }
}
