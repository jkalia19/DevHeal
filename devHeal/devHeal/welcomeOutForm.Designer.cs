namespace devHeal
{
    partial class welcomeOutForm
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
            this.signupButton1 = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.loginButton1 = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signupButton1
            // 
            this.signupButton1.BackColor = System.Drawing.Color.LightCyan;
            this.signupButton1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton1.ForeColor = System.Drawing.Color.DarkCyan;
            this.signupButton1.Location = new System.Drawing.Point(605, 380);
            this.signupButton1.Name = "signupButton1";
            this.signupButton1.Size = new System.Drawing.Size(159, 50);
            this.signupButton1.TabIndex = 28;
            this.signupButton1.Text = "Register";
            this.signupButton1.UseVisualStyleBackColor = false;
            this.signupButton1.Visible = false;
            this.signupButton1.Click += new System.EventHandler(this.signupButton1_Click);
            this.signupButton1.MouseLeave += new System.EventHandler(this.signupButton1_MouseLeave);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.signupButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(617, 384);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(136, 42);
            this.signupButton.TabIndex = 27;
            this.signupButton.Text = "Register";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.MouseEnter += new System.EventHandler(this.signupButton_MouseEnter);
            // 
            // loginButton1
            // 
            this.loginButton1.BackColor = System.Drawing.Color.LightCyan;
            this.loginButton1.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton1.ForeColor = System.Drawing.Color.DarkCyan;
            this.loginButton1.Location = new System.Drawing.Point(378, 380);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(163, 50);
            this.loginButton1.TabIndex = 30;
            this.loginButton1.Text = "Login";
            this.loginButton1.UseVisualStyleBackColor = false;
            this.loginButton1.Visible = false;
            this.loginButton1.Click += new System.EventHandler(this.loginButton1_Click);
            this.loginButton1.MouseLeave += new System.EventHandler(this.loginButton1_MouseLeave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(387, 384);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(140, 42);
            this.loginButton.TabIndex = 29;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            // 
            // welcomeOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::devHeal.Properties.Resources.kjhhhh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 468);
            this.Controls.Add(this.loginButton1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signupButton1);
            this.Controls.Add(this.signupButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "welcomeOutForm";
            this.Text = "welcomeOutForm";
            this.Load += new System.EventHandler(this.welcomeOutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signupButton1;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button loginButton1;
        private System.Windows.Forms.Button loginButton;
    }
}