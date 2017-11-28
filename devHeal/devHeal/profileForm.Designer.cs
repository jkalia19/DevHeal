namespace devHeal
{
    partial class profileForm
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
            this.updateButton1 = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.rePwdTextBox = new System.Windows.Forms.TextBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phonenoTextBox = new System.Windows.Forms.TextBox();
            this.genderCombobox = new System.Windows.Forms.ComboBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phLabel = new System.Windows.Forms.Label();
            this.uidLabel = new System.Windows.Forms.Label();
            this.rePwdLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.orgnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.orgNameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.uploadphotoLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.dateBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton1
            // 
            this.updateButton1.BackColor = System.Drawing.Color.LightCyan;
            this.updateButton1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton1.ForeColor = System.Drawing.Color.DarkCyan;
            this.updateButton1.Location = new System.Drawing.Point(464, 405);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(158, 51);
            this.updateButton1.TabIndex = 54;
            this.updateButton1.Text = "Update Record";
            this.updateButton1.UseVisualStyleBackColor = false;
            this.updateButton1.Visible = false;
            this.updateButton1.Click += new System.EventHandler(this.updateButton1_Click);
            this.updateButton1.MouseLeave += new System.EventHandler(this.updateButton1_MouseLeave);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(804, 242);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(225, 58);
            this.addressTextBox.TabIndex = 53;
            // 
            // rePwdTextBox
            // 
            this.rePwdTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePwdTextBox.Location = new System.Drawing.Point(804, 370);
            this.rePwdTextBox.Name = "rePwdTextBox";
            this.rePwdTextBox.PasswordChar = '*';
            this.rePwdTextBox.Size = new System.Drawing.Size(225, 26);
            this.rePwdTextBox.TabIndex = 52;
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTextBox.Location = new System.Drawing.Point(804, 323);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.PasswordChar = '*';
            this.pwdTextBox.Size = new System.Drawing.Size(225, 26);
            this.pwdTextBox.TabIndex = 51;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(804, 196);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(225, 26);
            this.emailTextBox.TabIndex = 50;
            // 
            // phonenoTextBox
            // 
            this.phonenoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenoTextBox.Location = new System.Drawing.Point(804, 152);
            this.phonenoTextBox.Name = "phonenoTextBox";
            this.phonenoTextBox.Size = new System.Drawing.Size(225, 26);
            this.phonenoTextBox.TabIndex = 49;
            // 
            // genderCombobox
            // 
            this.genderCombobox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCombobox.ForeColor = System.Drawing.Color.Silver;
            this.genderCombobox.FormattingEnabled = true;
            this.genderCombobox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderCombobox.Location = new System.Drawing.Point(804, 71);
            this.genderCombobox.Name = "genderCombobox";
            this.genderCombobox.Size = new System.Drawing.Size(225, 27);
            this.genderCombobox.TabIndex = 47;
            this.genderCombobox.Text = "Select Gender";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(598, 242);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(73, 21);
            this.addressLabel.TabIndex = 45;
            this.addressLabel.Text = "Address";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(598, 198);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 21);
            this.emailLabel.TabIndex = 44;
            this.emailLabel.Text = "Email";
            // 
            // phLabel
            // 
            this.phLabel.AutoSize = true;
            this.phLabel.BackColor = System.Drawing.Color.Transparent;
            this.phLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phLabel.Location = new System.Drawing.Point(598, 154);
            this.phLabel.Name = "phLabel";
            this.phLabel.Size = new System.Drawing.Size(90, 21);
            this.phLabel.TabIndex = 43;
            this.phLabel.Text = "Phone No.";
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.BackColor = System.Drawing.Color.Transparent;
            this.uidLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidLabel.Location = new System.Drawing.Point(267, 73);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(69, 21);
            this.uidLabel.TabIndex = 42;
            this.uidLabel.Text = "User ID";
            // 
            // rePwdLabel
            // 
            this.rePwdLabel.AutoSize = true;
            this.rePwdLabel.BackColor = System.Drawing.Color.Transparent;
            this.rePwdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePwdLabel.Location = new System.Drawing.Point(598, 368);
            this.rePwdLabel.Name = "rePwdLabel";
            this.rePwdLabel.Size = new System.Drawing.Size(152, 21);
            this.rePwdLabel.TabIndex = 41;
            this.rePwdLabel.Text = "Re-enter Password";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdLabel.Location = new System.Drawing.Point(598, 323);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(113, 21);
            this.pwdLabel.TabIndex = 40;
            this.pwdLabel.Text = "Set Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Date of Birth";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenderLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(598, 73);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(65, 21);
            this.GenderLabel.TabIndex = 38;
            this.GenderLabel.Text = "Gender";
            // 
            // orgnameTextBox
            // 
            this.orgnameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgnameTextBox.Location = new System.Drawing.Point(271, 370);
            this.orgnameTextBox.Name = "orgnameTextBox";
            this.orgnameTextBox.Size = new System.Drawing.Size(229, 26);
            this.orgnameTextBox.TabIndex = 37;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTextBox.Location = new System.Drawing.Point(271, 325);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(229, 26);
            this.lnameTextBox.TabIndex = 36;
            // 
            // orgNameLabel
            // 
            this.orgNameLabel.AutoSize = true;
            this.orgNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.orgNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgNameLabel.Location = new System.Drawing.Point(60, 368);
            this.orgNameLabel.Name = "orgNameLabel";
            this.orgNameLabel.Size = new System.Drawing.Size(152, 21);
            this.orgNameLabel.TabIndex = 35;
            this.orgNameLabel.Text = "Organization Name";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.Location = new System.Drawing.Point(62, 321);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(90, 21);
            this.lNameLabel.TabIndex = 34;
            this.lNameLabel.Text = "Last Name";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(60, 278);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(92, 21);
            this.fNameLabel.TabIndex = 33;
            this.fNameLabel.Text = "First Name";
            // 
            // uploadphotoLabel
            // 
            this.uploadphotoLabel.AutoSize = true;
            this.uploadphotoLabel.BackColor = System.Drawing.Color.Transparent;
            this.uploadphotoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadphotoLabel.Location = new System.Drawing.Point(267, 206);
            this.uploadphotoLabel.Name = "uploadphotoLabel";
            this.uploadphotoLabel.Size = new System.Drawing.Size(94, 19);
            this.uploadphotoLabel.TabIndex = 31;
            this.uploadphotoLabel.Text = "Upload Photo";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(475, 416);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(136, 31);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.MouseEnter += new System.EventHandler(this.updateButton_MouseEnter);
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextBox.Location = new System.Drawing.Point(271, 280);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(229, 26);
            this.fnameTextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "My Profile";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Image = global::devHeal.Properties.Resources.profile_picture;
            this.profilePictureBox.Location = new System.Drawing.Point(64, 73);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(132, 152);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 32;
            this.profilePictureBox.TabStop = false;
            // 
            // dateBirthDateTimePicker
            // 
            this.dateBirthDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirthDateTimePicker.Location = new System.Drawing.Point(804, 112);
            this.dateBirthDateTimePicker.Name = "dateBirthDateTimePicker";
            this.dateBirthDateTimePicker.Size = new System.Drawing.Size(225, 26);
            this.dateBirthDateTimePicker.TabIndex = 66;
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::devHeal.Properties.Resources.kjhhhh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 468);
            this.Controls.Add(this.dateBirthDateTimePicker);
            this.Controls.Add(this.updateButton1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.rePwdTextBox);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phonenoTextBox);
            this.Controls.Add(this.genderCombobox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phLabel);
            this.Controls.Add(this.uidLabel);
            this.Controls.Add(this.rePwdLabel);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.orgnameTextBox);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.orgNameLabel);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.uploadphotoLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profileForm";
            this.Text = "profileForm";
            this.Load += new System.EventHandler(this.profileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox rePwdTextBox;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phonenoTextBox;
        private System.Windows.Forms.ComboBox genderCombobox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phLabel;
        private System.Windows.Forms.Label uidLabel;
        private System.Windows.Forms.Label rePwdLabel;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox orgnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Label orgNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label uploadphotoLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBirthDateTimePicker;
    }
}