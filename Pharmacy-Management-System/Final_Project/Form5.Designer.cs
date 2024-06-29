namespace Final_Project
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.list_of_Medicine = new System.Windows.Forms.ListBox();
            this.txt_MedicineID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MedicineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MedicinePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_No_of_Units = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Medicine_Total_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bAdd_to_cart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRemove = new System.Windows.Forms.Button();
            this.lTotal_Amount = new System.Windows.Forms.Label();
            this.bPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 219);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 27);
            this.dateTimePicker1.TabIndex = 58;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bReturn
            // 
            this.bReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bReturn.Image = ((System.Drawing.Image)(resources.GetObject("bReturn.Image")));
            this.bReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReturn.Location = new System.Drawing.Point(959, 1);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(94, 37);
            this.bReturn.TabIndex = 49;
            this.bReturn.Text = "Return  ";
            this.bReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(12, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 27);
            this.txtSearch.TabIndex = 51;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // list_of_Medicine
            // 
            this.list_of_Medicine.FormattingEnabled = true;
            this.list_of_Medicine.ItemHeight = 20;
            this.list_of_Medicine.Location = new System.Drawing.Point(12, 107);
            this.list_of_Medicine.Name = "list_of_Medicine";
            this.list_of_Medicine.Size = new System.Drawing.Size(231, 504);
            this.list_of_Medicine.TabIndex = 52;
            this.list_of_Medicine.SelectedValueChanged += new System.EventHandler(this.list_of_Medicine_SelectedValueChanged);
            // 
            // txt_MedicineID
            // 
            this.txt_MedicineID.ForeColor = System.Drawing.Color.Black;
            this.txt_MedicineID.Location = new System.Drawing.Point(289, 56);
            this.txt_MedicineID.Name = "txt_MedicineID";
            this.txt_MedicineID.ReadOnly = true;
            this.txt_MedicineID.Size = new System.Drawing.Size(318, 27);
            this.txt_MedicineID.TabIndex = 54;
            this.txt_MedicineID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(289, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Medicine ID";
            // 
            // txt_MedicineName
            // 
            this.txt_MedicineName.ForeColor = System.Drawing.Color.Black;
            this.txt_MedicineName.Location = new System.Drawing.Point(289, 133);
            this.txt_MedicineName.Name = "txt_MedicineName";
            this.txt_MedicineName.ReadOnly = true;
            this.txt_MedicineName.Size = new System.Drawing.Size(318, 27);
            this.txt_MedicineName.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(289, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Medicine Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(289, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Expire Date";
            // 
            // txt_MedicinePrice
            // 
            this.txt_MedicinePrice.ForeColor = System.Drawing.Color.Black;
            this.txt_MedicinePrice.Location = new System.Drawing.Point(694, 56);
            this.txt_MedicinePrice.Name = "txt_MedicinePrice";
            this.txt_MedicinePrice.ReadOnly = true;
            this.txt_MedicinePrice.Size = new System.Drawing.Size(318, 27);
            this.txt_MedicinePrice.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(694, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Price per unit";
            // 
            // txt_No_of_Units
            // 
            this.txt_No_of_Units.ForeColor = System.Drawing.Color.Black;
            this.txt_No_of_Units.Location = new System.Drawing.Point(694, 133);
            this.txt_No_of_Units.Name = "txt_No_of_Units";
            this.txt_No_of_Units.Size = new System.Drawing.Size(318, 27);
            this.txt_No_of_Units.TabIndex = 64;
            this.txt_No_of_Units.TextChanged += new System.EventHandler(this.txt_No_of_Units_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(694, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "No of Units";
            // 
            // txt_Medicine_Total_price
            // 
            this.txt_Medicine_Total_price.ForeColor = System.Drawing.Color.Black;
            this.txt_Medicine_Total_price.Location = new System.Drawing.Point(694, 221);
            this.txt_Medicine_Total_price.Name = "txt_Medicine_Total_price";
            this.txt_Medicine_Total_price.ReadOnly = true;
            this.txt_Medicine_Total_price.Size = new System.Drawing.Size(318, 27);
            this.txt_Medicine_Total_price.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(694, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Total Price";
            // 
            // bAdd_to_cart
            // 
            this.bAdd_to_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd_to_cart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bAdd_to_cart.Image = ((System.Drawing.Image)(resources.GetObject("bAdd_to_cart.Image")));
            this.bAdd_to_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAdd_to_cart.Location = new System.Drawing.Point(888, 265);
            this.bAdd_to_cart.Name = "bAdd_to_cart";
            this.bAdd_to_cart.Size = new System.Drawing.Size(124, 52);
            this.bAdd_to_cart.TabIndex = 67;
            this.bAdd_to_cart.Text = "Add to Cart";
            this.bAdd_to_cart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAdd_to_cart.UseVisualStyleBackColor = true;
            this.bAdd_to_cart.Click += new System.EventHandler(this.bAdd_to_cart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(289, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(723, 254);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medicine Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Expire Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price Per Units";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No of Units";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // bRemove
            // 
            this.bRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bRemove.Image = ((System.Drawing.Image)(resources.GetObject("bRemove.Image")));
            this.bRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRemove.Location = new System.Drawing.Point(289, 604);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(124, 52);
            this.bRemove.TabIndex = 69;
            this.bRemove.Text = "Remove     ";
            this.bRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // lTotal_Amount
            // 
            this.lTotal_Amount.BackColor = System.Drawing.Color.White;
            this.lTotal_Amount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTotal_Amount.Location = new System.Drawing.Point(584, 609);
            this.lTotal_Amount.Name = "lTotal_Amount";
            this.lTotal_Amount.Size = new System.Drawing.Size(142, 40);
            this.lTotal_Amount.TabIndex = 70;
            this.lTotal_Amount.Text = "00 Taka";
            this.lTotal_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTotal_Amount.Click += new System.EventHandler(this.lTotal_Amount_Click);
            // 
            // bPurchase
            // 
            this.bPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPurchase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bPurchase.Image = ((System.Drawing.Image)(resources.GetObject("bPurchase.Image")));
            this.bPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPurchase.Location = new System.Drawing.Point(888, 604);
            this.bPurchase.Name = "bPurchase";
            this.bPurchase.Size = new System.Drawing.Size(124, 52);
            this.bPurchase.TabIndex = 71;
            this.bPurchase.Text = "Purchase   ";
            this.bPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPurchase.UseVisualStyleBackColor = true;
            this.bPurchase.Click += new System.EventHandler(this.bPurchase_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 668);
            this.Controls.Add(this.bPurchase);
            this.Controls.Add(this.lTotal_Amount);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bAdd_to_cart);
            this.Controls.Add(this.txt_Medicine_Total_price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_No_of_Units);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_MedicinePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MedicineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MedicineID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_of_Medicine);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReturn);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Medicine";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button bReturn;
        private Label label1;
        private TextBox txtSearch;
        private ListBox list_of_Medicine;
        private TextBox txt_MedicineID;
        private Label label2;
        private TextBox txt_MedicineName;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_MedicinePrice;
        private Label label6;
        private TextBox txt_No_of_Units;
        private Label label7;
        private TextBox txt_Medicine_Total_price;
        private Label label8;
        private Button bAdd_to_cart;
        private DataGridView dataGridView1;
        private Button bRemove;
        private Label lTotal_Amount;
        private Button bPurchase;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}