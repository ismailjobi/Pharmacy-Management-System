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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                txt_Password.UseSystemPasswordChar = true ;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");


            string query = "Select * from user_info where USERNAME ='" + txt_UserName.Text.Trim() + "' and PASS = '" + txt_Password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (dtbl.Rows.Count == 1)
                {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    String userRole = dtbl.Rows[0][2].ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                    if (userRole == "Admin")
                    {
                        Form2 f2 = new Form2(txt_UserName.Text);
                        this.Hide();
                        f2.Show();
                    }
                    else if (userRole == "Manager")
                    {
                        Form3 f3 = new Form3(txt_UserName.Text);
                        this.Hide();
                        f3.Show();
                    }
                    else if (userRole == "Pharmacist")
                    {
                        Form4 f4 = new Form4(txt_UserName.Text);
                        this.Hide();
                        f4.Show();
                    }

                }

                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
        }

        private void txt_UserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_UserName.Text))
            {
                e.Cancel = true;
                txt_UserName.Focus();
                errorProvider1.SetError(txt_UserName, " Please Enter your User Name !");
            }
            else
            {
                errorProvider1.SetError(txt_UserName, null);
            }
        }

        private void txt_Password_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                e.Cancel = true;
                txt_Password.Focus();
                errorProvider2.SetError(txt_Password, "Please Enter your Password !");
            }
            else
            {
                errorProvider2.SetError(txt_Password, null);
            }
        }

        private void txt_Password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            
            DialogResult Result= MessageBox.Show("Do You Want To Close The Application ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Thanks For Staying With Us.");
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            txt_UserName.Clear();
            txt_Password.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}