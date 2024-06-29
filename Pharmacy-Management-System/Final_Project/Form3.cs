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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(String userName)
        {
            InitializeComponent();
            lUserName.Text = userName;
        }

        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,NAME,USERROLE,DOB,EMAIL,Mobile_Number,USERNAME FROM user_info WHERE USERROLE = 'Pharmacist'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txt_ID.Select();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do You Want To Close The Application ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Thanks For Staying With Us.");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt_ID.Select();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT ID,NAME,USERROLE,DOB,EMAIL,Mobile_Number,USERNAME FROM user_info WHERE USERROLE = 'Pharmacist'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            BindData();
            txt_ID.Text = "";
            txt_Name.Text = "";
            txt_DOB.Text = "";
            txt_Email.Text = "";
            txt_Mnumber.Text = "";
            
        }

        private void bSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT ID,NAME,USERROLE,DOB,EMAIL,Mobile_Number,USERNAME FROM user_info WHERE ID=@ID AND USERROLE = 'Pharmacist'", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter User ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void bUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE user_info SET NAME=@NAME,DOB=@DOB,EMAIL=@EMAIL,Mobile_Number=@Mobile_Number  WHERE ID=@ID AND USERROLE = 'Pharmacist'", con);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@NAME", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@DOB", txt_DOB.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@Mobile_Number", Int64.Parse(txt_Mnumber.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_ID.Text = "";
                    txt_Name.Text = "";
                    txt_DOB.Text = "";
                    txt_Email.Text = "";
                    txt_Mnumber.Text = "";

                    MessageBox.Show("Successfully Updated Pharmacist Information.");
                    BindData();


                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result = MessageBox.Show("Do You Want To Delete This User ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE user_info WHERE ID=@ID AND USERROLE = 'Pharmacist' ", con);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@NAME", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@DOB", txt_DOB.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@Mobile_Number", Int64.Parse(txt_Mnumber.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_ID.Text = "";
                    txt_Name.Text = "";
                    txt_DOB.Text = "";
                    txt_Email.Text = "";
                    txt_Mnumber.Text = "";

                    MessageBox.Show("Successfully Deleted Pharmacist Information");
                    BindData();
                }
                    
            }
            catch (Exception )
            {
                MessageBox.Show("Please Check User Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_ID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                e.Cancel = true;
                txt_ID.Focus();
                errorProvider1.SetError(txt_ID, " Please Enter Pharmacist ID !");
            }
            else
            {
                errorProvider1.SetError(txt_ID, null);
            }
        }

        private void txt_Name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                e.Cancel = true;
                txt_Name.Focus();
                errorProvider2.SetError(txt_Name, " Please Enter Pharmacist Name !");
            }
            else
            {
                errorProvider2.SetError(txt_Name, null);
            }
        }

        private void txt_Mnumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Mnumber.Text))
            {
                e.Cancel = true;
                txt_Mnumber.Focus();
                errorProvider3.SetError(txt_Mnumber, " Please Enter Pharmacist Mobile Number !");
            }
            else
            {
                errorProvider3.SetError(txt_Mnumber, null);
            }
        }

        private void txt_DOB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_DOB.Text))
            {
                e.Cancel = true;
                txt_DOB.Focus();
                errorProvider4.SetError(txt_DOB, " Please Enter Pharmacist Date of Birth !");
            }
            else
            {
                errorProvider4.SetError(txt_DOB, null);
            }
        }

        private void txt_Email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                e.Cancel = true;
                txt_Email.Focus();
                errorProvider5.SetError(txt_Email, " Please Enter Pharmacist Email Address !");
            }
            else
            {
                errorProvider5.SetError(txt_Email, null);
            }
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do You Want To Logout ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {

            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            int Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            txt_ID.Text = Id.ToString();

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            txt_Name.Text = name;

#pragma warning disable CS8604 // Possible null reference argument.
            Int64 mobileNumber = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            txt_Mnumber.Text = mobileNumber.ToString();

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String dob = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            txt_DOB.Text = dob;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String email = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            txt_Email.Text = email;
        }

        private void lUserName_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(lUserName.Text);
            this.Hide();
            f6.Show();
        }
    }
}
