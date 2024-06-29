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

namespace Final_Project
{
    public partial class Form6 : Form
    {
        public Form6(String userName)
        {
            InitializeComponent();
            lUserName.Text = userName;
        }

        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM user_info", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from user_info where USERNAME = '" +lUserName.Text+ "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txt_Name.Text = dt.Rows[0][1].ToString();
                cbRole.Text = dt.Rows[0][2].ToString();
                txt_DOB.Text = dt.Rows[0][3].ToString();
                txt_Email.Text = dt.Rows[0][4].ToString();
                txt_Mnumber.Text = dt.Rows[0][5].ToString();
                txt_Password.Text = dt.Rows[0][7].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lUserName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form6_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form6_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void bClear_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Form6_Load(this, null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        private void bUpdateUser_Click(object sender, EventArgs e)
        {

            try
            {
                String name = txt_Name.Text;
                string dob = txt_DOB.Text;
                string email = txt_Email.Text;
                string pass = txt_Password.Text;
                Int64 mNumber = Int64.Parse(txt_Mnumber.Text); 
                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE user_info SET NAME='"+ name + "',DOB='"+dob+"',EMAIL='"+email+"',Mobile_Number='"+mNumber+"',PASS='"+pass+"'  WHERE USERNAME='"+lUserName.Text+"'", con);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Updated User Information.");
                BindData();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            if (cbRole.Text == "Admin")
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            else if (cbRole.Text == "Manager")
            {
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();
            }
            else if (cbRole.Text == "Pharmacist")
            {
                Form4 f4 = new Form4();
                this.Hide();
                f4.Show();
            }
        }
    }
}
