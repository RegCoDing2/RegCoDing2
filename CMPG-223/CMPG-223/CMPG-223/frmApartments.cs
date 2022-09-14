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
    public partial class frmApartments : Form
    {
        SqlConnection conn;
        SqlDataAdapter adap;
        SqlCommand comm;
        SqlDataReader dr;
        string block;

        public frmApartments()
        {
            InitializeComponent();
        }

        public void fillComboBox(string sql)
        {
            cmbApartNumDel.Items.Clear();

            conn.Open();

            comm = new SqlCommand(sql, conn);

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cmbApartNumDel.Items.Add(dr.GetValue(0));//0 specifiy table colomb
            }

            conn.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApartments_Load(object sender, EventArgs e)
        {
            string conStr = @"Data Source=LAPTOP-5TBP2DI1;Initial Catalog=Bronze_League;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(conStr);

            cmbApartNum.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            cmbApartNumDel.Visible = false;
            btnAddApart.Visible = false;
            btnDelApart.Visible = false;



        }

        private void rbBlockA_CheckedChanged(object sender, EventArgs e)
        {
            string sqlSearchBlock = "";
            

            if (rbBlockA.Checked)
            {
                // Filter for Blok A Apartment
                sqlSearchBlock = $"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'A%'";
                fillComboBox(sqlSearchBlock);
                btnAddApart.Visible = true;
                btnDelApart.Visible = true;
                block = "A";
            }
            else
            {
                // Filter for Blok B Apartment
                sqlSearchBlock = $"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE 'B%'";
                fillComboBox(sqlSearchBlock);
                btnAddApart.Visible = true;
                btnDelApart.Visible = true;
                block = "B";
            }
        }

        private void btnAddApart_Click(object sender, EventArgs e)
        {

            cmbApartNum.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = false;
            cmbApartNumDel.Visible = false;
        }

        private void pbBackground_Click(object sender, EventArgs e)
        {

        }

        private void btnDelApart_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            cmbApartNumDel.Visible = true;
            cmbApartNum.Visible = false;
            btnAdd.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string apartNum = block + cmbApartNum.SelectedItem.ToString();
            string sqlSearch = "";

            try
            {
                

                conn.Open();

                comm = new SqlCommand($"SELECT Apartment_Num FROM Apartment WHERE Apartment_Num LIKE %'{apartNum}'%", conn);

                SqlDataReader reader;

                reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    sqlSearch = reader.GetValue(2).ToString();
                }
         
                conn.Close();

                if (apartNum == sqlSearch)
                {
                    MessageBox.Show("Apartment already exists. Please pick another Apartment Number.");

                }
                else
                {
                    conn.Open();
                    string sqlInsertNew = $"INSERT INTO Apartment (Apartment_Num) VALUES ('{apartNum}')";
                    comm = new SqlCommand(sqlInsertNew, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Apartment successfully added.");
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                comm = new SqlCommand($"SELECT Apartment_ID FROM Apartment WHERE Apartment_Num = '" + cmbApartNumDel.SelectedItem.ToString() + "'", conn);

                SqlDataReader reader;

                reader = comm.ExecuteReader();

                string sqlFind = reader.GetValue(0).ToString();

                string sqlDeleteApart = $"DELETE FROM  Apartment WHERE  Apartment_Num = '" + sqlFind + "'";

                comm = new SqlCommand(sqlDeleteApart,conn);

                adap = new SqlDataAdapter();

                adap.DeleteCommand = comm;
                adap.DeleteCommand.ExecuteNonQuery();
                

                conn.Close();
                MessageBox.Show("Apartment successfully Deleted.");


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdApart_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            cmbApartNumDel.Visible = false;
            cmbApartNum.Visible = false;
            btnAdd.Visible = false;

        }
    
    }
}
