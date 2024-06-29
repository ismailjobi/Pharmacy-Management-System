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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(String userName)
        {
            InitializeComponent();
            lUserName.Text = userName;
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

        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM medi_info", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txt_MedicineID.Select();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txt_MedicineID.Select();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM medi_Info", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form4_Click(object sender, EventArgs e)
        {
            BindData();
            txt_MedicineID.Text = "";
            txt_MedicineName.Text = "";
            txt_Medicinenumber.Text = "";
            dtpMDate.Text = "";
            dtpEDate.Text = "";
            txt_Quantity.Text = "";
            txt_Price.Text = "";
            
        }

        private void bAddMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO medi_info(MID, MName,MNumber,MDate,EDate,Quantity,PPUnit) VALUES (@MID, @MName,@MNumber,@MDate,@EDate,@Quantity,@PPUnit)", con);

                    cmd.Parameters.AddWithValue("@MID", int.Parse(txt_MedicineID.Text));
                    cmd.Parameters.AddWithValue("@MName", txt_MedicineName.Text);
                    cmd.Parameters.AddWithValue("@MNumber", Int64.Parse(txt_Medicinenumber.Text));
                    cmd.Parameters.AddWithValue("@MDate", DateTime.Parse(dtpMDate.Text));
                    cmd.Parameters.AddWithValue("@EDate", DateTime.Parse(dtpEDate.Text));
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(txt_Quantity.Text));
                    cmd.Parameters.AddWithValue("@PPUnit", int.Parse(txt_Price.Text));


                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_MedicineID.Text = "";
                    txt_MedicineName.Text = "";
                    txt_Medicinenumber.Text = "";
                    dtpMDate.Text = "";
                    dtpEDate.Text = "";
                    txt_Quantity.Text = "";
                    txt_Price.Text = "";

                    MessageBox.Show(" Medicine Information Successfully Inserted. ");
                    BindData();


                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void bDeleteMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result = MessageBox.Show("Do You Want To Delete Medicine ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE medi_info WHERE MID=@MID", con);

                    cmd.Parameters.AddWithValue("@MID", int.Parse(txt_MedicineID.Text));


                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_MedicineID.Text = "";
                    txt_MedicineName.Text = "";
                    txt_Medicinenumber.Text = "";
                    dtpMDate.Text = "";
                    dtpEDate.Text = "";
                    txt_Quantity.Text = "";
                    txt_Price.Text = "";
                    MessageBox.Show("Medicine Information Successfully Deleted");
                    BindData();
                }
                    
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bSearchMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM medi_info WHERE MID=@MID", con);
                cmd.Parameters.AddWithValue("@MID", int.Parse(txt_MedicineID.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter Medicine ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void bUpdateMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                                        
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE medi_info SET MNumber=@MNumber, MDate=@MDate,EDate=@EDate,Quantity=@Quantity,PPUnit=@PPUnit  WHERE MID=@MID OR MName=@MName", con);

                    cmd.Parameters.AddWithValue("@MID", int.Parse(txt_MedicineID.Text));
                    cmd.Parameters.AddWithValue("@MName", txt_MedicineName.Text);
                    cmd.Parameters.AddWithValue("@MNumber", Int64.Parse(txt_Medicinenumber.Text));
                    cmd.Parameters.AddWithValue("@MDate", DateTime.Parse(dtpMDate.Text));
                    cmd.Parameters.AddWithValue("@EDate", DateTime.Parse(dtpEDate.Text));
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(txt_Quantity.Text));
                    cmd.Parameters.AddWithValue("@PPUnit", int.Parse(txt_Price.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();

                    txt_MedicineID.Text = "";
                    txt_MedicineName.Text = "";
                    txt_Medicinenumber.Text = "";
                    dtpMDate.Text = "";
                    dtpEDate.Text = "";
                    txt_Quantity.Text = "";
                    txt_Price.Text = "";

                    MessageBox.Show("Medicine Information Successfully Updated");
                    BindData();

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txt_MedicineID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MedicineID.Text))
            {
                e.Cancel = true;
                txt_MedicineID.Focus();
                errorProvider1.SetError(txt_MedicineID, " Please Enter Medicine ID !");
            }
            else
            {
                errorProvider1.SetError(txt_MedicineID, null);
            }
        }

        private void txt_MedicineName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MedicineName.Text))
            {
                e.Cancel = true;
                txt_MedicineName.Focus();
                errorProvider2.SetError(txt_MedicineName, " Please Enter Medicine Name !");
            }
            else
            {
                errorProvider2.SetError(txt_MedicineName, null);
            }
        }

        private void txt_Medicinenumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Medicinenumber.Text))
            {
                e.Cancel = true;
                txt_Medicinenumber.Focus();
                errorProvider3.SetError(txt_Medicinenumber, " Please Enter Medicine Number !");
            }
            else
            {
                errorProvider3.SetError(txt_Medicinenumber, null);
            }
        }

        private void dtpMDate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpMDate.Text))
            {
                e.Cancel = true;
                dtpMDate.Focus();
                errorProvider4.SetError(dtpMDate, " Please Enter Manufacturing Date !");
            }
            else
            {
                errorProvider4.SetError(dtpMDate, null);
            }
        }

        private void dtpEDate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpEDate.Text))
            {
                e.Cancel = true;
                dtpEDate.Focus();
                errorProvider5.SetError(dtpEDate, " Please Enter Expire Date !");
            }
            else
            {
                errorProvider5.SetError(dtpEDate, null);
            }
        }

        private void txt_Quantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Quantity.Text))
            {
                e.Cancel = true;
                txt_Quantity.Focus();
                errorProvider6.SetError(txt_Quantity, " Please Enter Medicine Quantity !");
            }
            else
            {
                errorProvider6.SetError(txt_Quantity, null);
            }
        }

        private void txt_Price_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Price.Text))
            {
                e.Cancel = true;
                txt_Price.Focus();
                errorProvider7.SetError(txt_Price, " Please Enter Medicine Price !");
            }
            else
            {
                errorProvider7.SetError(txt_Price, null);
            }
        }

        private void bCheckValidity_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM medi_Info where EDate >= getdate()", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bSellMedicine_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            int mId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            txt_MedicineID.Text = mId.ToString();

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String mName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            txt_MedicineName.Text = mName;

#pragma warning disable CS8604 // Possible null reference argument.
            Int64 mNumber = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            txt_Medicinenumber.Text = mNumber.ToString();

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String mDate = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            dtpMDate.Text = mDate;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String eDate = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            dtpEDate.Text = eDate;

#pragma warning disable CS8604 // Possible null reference argument.
            int quantity = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            txt_Quantity.Text = quantity.ToString();

#pragma warning disable CS8604 // Possible null reference argument.
            int noofUnits = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            txt_Price.Text = noofUnits.ToString();


        }

        private void lUserName_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(lUserName.Text);
            this.Hide();
            f6.Show();
        }

        /*private void bSellMedicine(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }*/
    }
}
