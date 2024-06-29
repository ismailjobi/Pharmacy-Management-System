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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM medi_info", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            list_of_Medicine.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select MName from medi_info where EDate>= getdate() and Quantity > '0'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                list_of_Medicine.Items.Add(dt.Rows[i][0].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            list_of_Medicine.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select MName from medi_info where MName like '"+txtSearch.Text+"%'and EDate>= getdate() and Quantity > '0'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                list_of_Medicine.Items.Add(dt.Rows[i][0].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            }
        }

        private void list_of_Medicine_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                txt_No_of_Units.Clear();
                String Name = list_of_Medicine.GetItemText(list_of_Medicine.SelectedItem);
                txt_MedicineName.Text = Name;

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select MID,EDate,PPUnit from medi_info where MName = '" + Name + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txt_MedicineID.Text = dt.Rows[0][0].ToString();
                dateTimePicker1.Text = dt.Rows[0][1].ToString();
                txt_MedicinePrice.Text = dt.Rows[0][2].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_No_of_Units_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txt_No_of_Units.Text != "" )
                {
                    Int64 unitPrice = Int64.Parse(txt_MedicinePrice.Text);
                    Int64 noofUnits = Int64.Parse(txt_No_of_Units.Text);

                    Int64 totalAmount = unitPrice * noofUnits;
                    txt_Medicine_Total_price.Text = totalAmount.ToString();
                }
                else
                {
                    txt_Medicine_Total_price.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected int n, totalAmount = 0;
        protected int quantity, newQuantity;

        

        private void bAdd_to_cart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MedicineID.Text != "")
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("select Quantity from medi_info where MID = '" + txt_MedicineID.Text + "' ", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

#pragma warning disable CS8604 // Possible null reference argument.
                    quantity = int.Parse(dt.Rows[0][0].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
                    newQuantity = quantity - int.Parse(txt_No_of_Units.Text);

                    if (newQuantity >= 0)
                    {
                        n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = txt_MedicineID.Text;
                        dataGridView1.Rows[n].Cells[1].Value = txt_MedicineName.Text;
                        dataGridView1.Rows[n].Cells[2].Value = dateTimePicker1.Text;
                        dataGridView1.Rows[n].Cells[3].Value = txt_MedicinePrice.Text;
                        dataGridView1.Rows[n].Cells[4].Value = txt_No_of_Units.Text;
                        dataGridView1.Rows[n].Cells[5].Value = txt_Medicine_Total_price.Text;

                        totalAmount = totalAmount + int.Parse(txt_Medicine_Total_price.Text);
                        lTotal_Amount.Text = totalAmount.ToString() + " Taka";

                        SqlConnection lon = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                        lon.Open();
                        SqlCommand cm = new SqlCommand("update medi_info set Quantity = '" + newQuantity + "'where MID = '" + txt_MedicineID.Text + "'", lon);
                        cm.ExecuteNonQuery();
                        lon.Close();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                        Form5_Load(this, null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

                        txt_MedicineID.Text = "";
                        txt_MedicineName.Text = "";
                        dateTimePicker1.Text = "";
                        txt_MedicinePrice.Text = "";
                        txt_No_of_Units.Text = "";
                        txt_Medicine_Total_price.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Medicine is out of stock.\n only " + quantity + " left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Select Medicine First . ", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Your Given Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        int valueAmount = 0;
        String valueID ="";


        protected int noofunits;

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
#pragma warning disable CS8604 // Possible null reference argument.
                valueAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8601 // Possible null reference assignment.
                valueID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8604 // Possible null reference argument.
                noofunits = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
#pragma warning restore CS8604 // Possible null reference argument.

            }
            catch (Exception )
            {

            }

        }

        private void lTotal_Amount_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (valueID != null)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

                }
                catch (Exception)
                {

                }
                finally
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("select Quantity from medi_info where MID = '" + valueID + "' ", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
#pragma warning disable CS8604 // Possible null reference argument.
                    quantity = int.Parse(dt.Rows[0][0].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
                    newQuantity = quantity + noofunits;

                    SqlConnection lon = new SqlConnection("Data Source=DESKTOP-QF5VJA9;Initial Catalog=PHARMACY;Integrated Security=True");
                    lon.Open();
                    SqlCommand cm = new SqlCommand("update medi_info set Quantity = '" + newQuantity + "'where MID = '" + valueID + "'", lon);
                    cm.ExecuteNonQuery();
                    lon.Close();

                    MessageBox.Show("Medicine Remove From Cart .");
                    totalAmount = totalAmount - valueAmount;
                    lTotal_Amount.Text = totalAmount.ToString() + " Taka";
                    
                }
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                Form5_Load(this, null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.


            }

        }

        private void bPurchase_Click(object sender, EventArgs e)
        {
            totalAmount = 0;
            lTotal_Amount.Text = "00 Taka";
            dataGridView1.DataSource = 0;

            MessageBox.Show(" Medicine Purchase .");

        }
    }
}
