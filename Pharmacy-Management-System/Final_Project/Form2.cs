using System.Data;
using System.Data.SqlClient;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(string userName)
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
             dataGridView1.DataSource = dt;
             txt_ID.Select();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_ID.Select();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM user_info", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            BindData();
            txt_ID.Text = "";
            txt_Name.Text = "";
            cbRole.Text = "";
            txt_DOB.Text = "";
            txt_Email.Text = "";
            txt_Mnumber.Text = "";
            txt_UserName.Text = "";
            txt_Password.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO user_info(ID, NAME,USERROLE,DOB,EMAIL,Mobile_Number,USERNAME,PASS) VALUES (@ID, @NAME,@USERROLE,@DOB,@EMAIL,@Mobile_Number,@USERNAME,@PASS)", con);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@NAME", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@USERROLE", cbRole.Text);
                    cmd.Parameters.AddWithValue("@DOB", txt_DOB.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@Mobile_Number", Int64.Parse(txt_Mnumber.Text));
                    cmd.Parameters.AddWithValue("@USERNAME", txt_UserName.Text);
                    cmd.Parameters.AddWithValue("@PASS", txt_Password.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_ID.Text = "";
                    txt_Name.Text = "";
                    cbRole.Text = "";
                    txt_DOB.Text = "";
                    txt_Email.Text = "";
                    txt_Mnumber.Text = "";
                    txt_UserName.Text = "";
                    txt_Password.Text = "";
                    MessageBox.Show("Successfully Added User Information.");
                    BindData();


                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

                    SqlCommand cmd = new SqlCommand("DELETE user_info WHERE ID=@ID", con);

                    cmd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_ID.Text = "";
                    txt_Name.Text = "";
                    cbRole.Text = "";
                    txt_DOB.Text = "";
                    txt_Email.Text = "";
                    txt_Mnumber.Text = "";
                    txt_UserName.Text = "";
                    txt_Password.Text = "";
                    MessageBox.Show("Successfully Deleted User Information.");
                    BindData();
                }
                    

                
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM user_info WHERE ID=@ID", con);
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

                    SqlCommand cmd = new SqlCommand("UPDATE user_info SET NAME=@NAME, USERROLE=@USERROLE,DOB=@DOB,EMAIL=@EMAIL,Mobile_Number=@Mobile_Number,PASS=@PASS  WHERE ID=@ID OR USERNAME=@USERNAME", con);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@NAME", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@USERROLE", cbRole.Text);
                    cmd.Parameters.AddWithValue("@DOB", txt_DOB.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@Mobile_Number", Int64.Parse(txt_Mnumber.Text));
                    cmd.Parameters.AddWithValue("@USERNAME", txt_UserName.Text);
                    cmd.Parameters.AddWithValue("@PASS", txt_Password.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_ID.Text = "";
                    txt_Name.Text = "";
                    cbRole.Text = "";
                    txt_DOB.Text = "";
                    txt_Email.Text = "";
                    txt_Mnumber.Text = "";
                    txt_UserName.Text = "";
                    txt_Password.Text = "";
                    MessageBox.Show("Successfully Updated User Information.");
                    BindData();


                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void txt_ID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                e.Cancel = true;
                txt_ID.Focus();
                errorProvider2.SetError(txt_ID, "Please Enter User ID !");
            }
            else
            {
                errorProvider1.SetError(txt_ID, null);
            }
        }

        private void txt_Name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                e.Cancel = true;
                txt_Name.Focus();
                errorProvider2.SetError(txt_Name, "Please Enter  Name !");
            }
            else
            {
                errorProvider2.SetError(txt_Name, null);
            }
        }

        private void txt_Mnumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Mnumber.Text))
            {
                e.Cancel = true;
                txt_Mnumber.Focus();
                errorProvider3.SetError(txt_Mnumber, "Please Enter User Mobile Number !");
            }
            else
            {
                errorProvider3.SetError(txt_Mnumber, null);
            }
        }

        private void txt_UserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_UserName.Text))
            {
                e.Cancel = true;
                txt_UserName.Focus();
                errorProvider4.SetError(txt_UserName, "Please Enter User Name !");
            }
            else
            {
                errorProvider4.SetError(txt_UserName, null);
            }
        }

        private void cbRole_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbRole.Text))
            {
                e.Cancel = true;
                cbRole.Focus();
                errorProvider5.SetError(cbRole, "Please Enter User Role !");
            }
            else
            {
                errorProvider5.SetError(cbRole, null);
            }
        }

        private void txt_DOB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_DOB.Text))
            {
                e.Cancel = true;
                txt_DOB.Focus();
                errorProvider6.SetError(txt_DOB, "Please Enter User Date of Birth !");
            }
            else
            {
                errorProvider6.SetError(txt_DOB, null);
            }
        }

        private void txt_Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                e.Cancel = true;
                txt_Email.Focus();
                errorProvider7.SetError(txt_Email, "Please Enter User Email Address !");
            }
            else
            {
                errorProvider7.SetError(txt_Email, null);
            }
        }

        private void txt_Password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                e.Cancel = true;
                txt_Password.Focus();
                errorProvider8.SetError(txt_Password, "Please Enter User Password !");
            }
            else
            {
                errorProvider8.SetError(txt_Password, null);
            }
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

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String userName = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            txt_UserName.Text = userName;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String userRole = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            cbRole.Text = userRole;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String pass = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            txt_Password.Text = pass;
        }

        private void lUserName_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(lUserName.Text);
            this.Hide();
            f6.Show();
        }
    }
}
