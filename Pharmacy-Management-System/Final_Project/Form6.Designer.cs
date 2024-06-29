namespace Final_Project
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.txt_DOB = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Mnumber = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lUserName = new System.Windows.Forms.Label();
            this.bUpdateUser = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DOB
            // 
            this.txt_DOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DOB.Location = new System.Drawing.Point(586, 240);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.Size = new System.Drawing.Size(417, 30);
            this.txt_DOB.TabIndex = 40;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.Location = new System.Drawing.Point(586, 464);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(415, 30);
            this.txt_Password.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Password";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.Location = new System.Drawing.Point(586, 305);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(417, 30);
            this.txt_Email.TabIndex = 34;
            // 
            // txt_Mnumber
            // 
            this.txt_Mnumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Mnumber.Location = new System.Drawing.Point(586, 388);
            this.txt_Mnumber.Name = "txt_Mnumber";
            this.txt_Mnumber.Size = new System.Drawing.Size(417, 30);
            this.txt_Mnumber.TabIndex = 32;
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Pharmacist"});
            this.cbRole.Location = new System.Drawing.Point(586, 105);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(417, 30);
            this.cbRole.TabIndex = 31;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Name.Location = new System.Drawing.Point(586, 174);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(417, 30);
            this.txt_Name.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mobile Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "DOB (Date of Birth)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name";
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.Location = new System.Drawing.Point(586, 82);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(72, 20);
            this.U.TabIndex = 25;
            this.U.Text = "User Role";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lUserName.Location = new System.Drawing.Point(248, 384);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(59, 23);
            this.lUserName.TabIndex = 42;
            this.lUserName.Text = "label1";
            this.lUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lUserName.Click += new System.EventHandler(this.lUserName_Click);
            // 
            // bUpdateUser
            // 
            this.bUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bUpdateUser.Location = new System.Drawing.Point(631, 528);
            this.bUpdateUser.Name = "bUpdateUser";
            this.bUpdateUser.Size = new System.Drawing.Size(103, 45);
            this.bUpdateUser.TabIndex = 43;
            this.bUpdateUser.Text = "Updat User";
            this.bUpdateUser.UseVisualStyleBackColor = true;
            this.bUpdateUser.Click += new System.EventHandler(this.bUpdateUser_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.White;
            this.bClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bClear.Image = ((System.Drawing.Image)(resources.GetObject("bClear.Image")));
            this.bClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClear.Location = new System.Drawing.Point(852, 526);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(103, 45);
            this.bClear.TabIndex = 44;
            this.bClear.Text = "Reset";
            this.bClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bReturn
            // 
            this.bReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bReturn.Image = ((System.Drawing.Image)(resources.GetObject("bReturn.Image")));
            this.bReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReturn.Location = new System.Drawing.Point(960, 3);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(94, 37);
            this.bReturn.TabIndex = 50;
            this.bReturn.Text = "Return  ";
            this.bReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 668);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bUpdateUser);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_DOB);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Mnumber);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.U);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Panel";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.Click += new System.EventHandler(this.Form6_Click);
            this.Enter += new System.EventHandler(this.Form6_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_DOB;
        private TextBox txt_Password;
        private Label label8;
        private TextBox txt_Email;
        private TextBox txt_Mnumber;
        private ComboBox cbRole;
        private TextBox txt_Name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label U;
        private PictureBox pictureBox1;
        private Label lUserName;
        private Button bUpdateUser;
        private Button bClear;
        private Button bReturn;
    }
}