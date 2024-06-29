namespace Final_Project
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bExit = new System.Windows.Forms.Button();
            this.lUserRole = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_MedicineID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Medicinenumber = new System.Windows.Forms.TextBox();
            this.txt_MedicineName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpMDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.bSearchMedicine = new System.Windows.Forms.Button();
            this.bDeleteMedicine = new System.Windows.Forms.Button();
            this.bAddMedicine = new System.Windows.Forms.Button();
            this.bUpdateMedicine = new System.Windows.Forms.Button();
            this.bLogout = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bCheckValidity = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(1016, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(41, 29);
            this.bExit.TabIndex = 0;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lUserRole
            // 
            this.lUserRole.AutoSize = true;
            this.lUserRole.Location = new System.Drawing.Point(960, 9);
            this.lUserRole.Name = "lUserRole";
            this.lUserRole.Size = new System.Drawing.Size(0, 20);
            this.lUserRole.TabIndex = 1;
            this.lUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lUserName
            // 
            this.lUserName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUserName.Image = ((System.Drawing.Image)(resources.GetObject("lUserName.Image")));
            this.lUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lUserName.Location = new System.Drawing.Point(1, 4);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(149, 25);
            this.lUserName.TabIndex = 2;
            this.lUserName.Text = "l";
            this.lUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lUserName.Click += new System.EventHandler(this.lUserName_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Quantity.Location = new System.Drawing.Point(484, 143);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(304, 30);
            this.txt_Quantity.TabIndex = 40;
            this.txt_Quantity.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Quantity_Validating);
            // 
            // txt_MedicineID
            // 
            this.txt_MedicineID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MedicineID.Location = new System.Drawing.Point(130, 83);
            this.txt_MedicineID.Name = "txt_MedicineID";
            this.txt_MedicineID.Size = new System.Drawing.Size(304, 30);
            this.txt_MedicineID.TabIndex = 39;
            this.txt_MedicineID.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MedicineID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Medicine ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Manufacturing Date";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Price.Location = new System.Drawing.Point(484, 208);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(304, 30);
            this.txt_Price.TabIndex = 34;
            this.txt_Price.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Price_Validating);
            // 
            // txt_Medicinenumber
            // 
            this.txt_Medicinenumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Medicinenumber.Location = new System.Drawing.Point(130, 208);
            this.txt_Medicinenumber.Name = "txt_Medicinenumber";
            this.txt_Medicinenumber.Size = new System.Drawing.Size(304, 30);
            this.txt_Medicinenumber.TabIndex = 32;
            this.txt_Medicinenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Medicinenumber_Validating);
            // 
            // txt_MedicineName
            // 
            this.txt_MedicineName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MedicineName.Location = new System.Drawing.Point(130, 143);
            this.txt_MedicineName.Name = "txt_MedicineName";
            this.txt_MedicineName.Size = new System.Drawing.Size(304, 30);
            this.txt_MedicineName.TabIndex = 30;
            this.txt_MedicineName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MedicineName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Price Per Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Medicine Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Medicine Name";
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.Location = new System.Drawing.Point(484, 59);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(86, 20);
            this.U.TabIndex = 25;
            this.U.Text = "Expire Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 261);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dtpMDate
            // 
            this.dtpMDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpMDate.Location = new System.Drawing.Point(130, 273);
            this.dtpMDate.Name = "dtpMDate";
            this.dtpMDate.Size = new System.Drawing.Size(304, 27);
            this.dtpMDate.TabIndex = 42;
            this.dtpMDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpMDate_Validating);
            // 
            // dtpEDate
            // 
            this.dtpEDate.Location = new System.Drawing.Point(484, 83);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(304, 27);
            this.dtpEDate.TabIndex = 43;
            this.dtpEDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEDate_Validating);
            // 
            // bSearchMedicine
            // 
            this.bSearchMedicine.Location = new System.Drawing.Point(832, 200);
            this.bSearchMedicine.Name = "bSearchMedicine";
            this.bSearchMedicine.Size = new System.Drawing.Size(128, 45);
            this.bSearchMedicine.TabIndex = 47;
            this.bSearchMedicine.Text = "Search Medicine";
            this.bSearchMedicine.UseVisualStyleBackColor = true;
            this.bSearchMedicine.Click += new System.EventHandler(this.bSearchMedicine_Click);
            // 
            // bDeleteMedicine
            // 
            this.bDeleteMedicine.Location = new System.Drawing.Point(832, 144);
            this.bDeleteMedicine.Name = "bDeleteMedicine";
            this.bDeleteMedicine.Size = new System.Drawing.Size(128, 45);
            this.bDeleteMedicine.TabIndex = 45;
            this.bDeleteMedicine.Text = "Delete Medicine";
            this.bDeleteMedicine.UseVisualStyleBackColor = true;
            this.bDeleteMedicine.Click += new System.EventHandler(this.bDeleteMedicine_Click);
            // 
            // bAddMedicine
            // 
            this.bAddMedicine.Location = new System.Drawing.Point(832, 84);
            this.bAddMedicine.Name = "bAddMedicine";
            this.bAddMedicine.Size = new System.Drawing.Size(128, 45);
            this.bAddMedicine.TabIndex = 44;
            this.bAddMedicine.Text = "Add Medicine";
            this.bAddMedicine.UseVisualStyleBackColor = true;
            this.bAddMedicine.Click += new System.EventHandler(this.bAddMedicine_Click);
            // 
            // bUpdateMedicine
            // 
            this.bUpdateMedicine.Location = new System.Drawing.Point(832, 256);
            this.bUpdateMedicine.Name = "bUpdateMedicine";
            this.bUpdateMedicine.Size = new System.Drawing.Size(128, 45);
            this.bUpdateMedicine.TabIndex = 48;
            this.bUpdateMedicine.Text = "UpdateMedicine";
            this.bUpdateMedicine.UseVisualStyleBackColor = true;
            this.bUpdateMedicine.Click += new System.EventHandler(this.bUpdateMedicine_Click);
            // 
            // bLogout
            // 
            this.bLogout.Image = ((System.Drawing.Image)(resources.GetObject("bLogout.Image")));
            this.bLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLogout.Location = new System.Drawing.Point(950, 617);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(94, 39);
            this.bLogout.TabIndex = 49;
            this.bLogout.Text = "Logout";
            this.bLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // bCheckValidity
            // 
            this.bCheckValidity.Location = new System.Drawing.Point(660, 256);
            this.bCheckValidity.Name = "bCheckValidity";
            this.bCheckValidity.Size = new System.Drawing.Size(128, 45);
            this.bCheckValidity.TabIndex = 50;
            this.bCheckValidity.Text = "Valid Medicine";
            this.bCheckValidity.UseVisualStyleBackColor = true;
            this.bCheckValidity.Click += new System.EventHandler(this.bCheckValidity_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 51;
            this.button1.Text = "Sell Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bSellMedicine_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCheckValidity);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.bUpdateMedicine);
            this.Controls.Add(this.bSearchMedicine);
            this.Controls.Add(this.bDeleteMedicine);
            this.Controls.Add(this.bAddMedicine);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.dtpMDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_MedicineID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Medicinenumber);
            this.Controls.Add(this.txt_MedicineName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.U);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.lUserRole);
            this.Controls.Add(this.bExit);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist Panel";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Click += new System.EventHandler(this.Form4_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bExit;
        private Label lUserRole;
        private Label lUserName;
        private TextBox txt_Quantity;
        private TextBox txt_MedicineID;
        private Label label1;
        private Label label7;
        private TextBox txt_Price;
        private TextBox txt_Medicinenumber;
        private TextBox txt_MedicineName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label U;
        private DataGridView dataGridView1;
        private DateTimePicker dtpMDate;
        private DateTimePicker dtpEDate;
        private Button bSearchMedicine;
        private Button bDeleteMedicine;
        private Button bAddMedicine;
        private Button bUpdateMedicine;
        private Button bLogout;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private Button bCheckValidity;
        private Button button1;
    }
}