using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace devHeal
{
    public partial class welcomeOutForm : Form
    {
        mainForm mf = new mainForm();
        public welcomeOutForm()
        {
            InitializeComponent();
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.Visible = false;
            loginButton1.Visible = true;
        }

        private void signupButton_MouseEnter(object sender, EventArgs e)
        {
            signupButton.Visible = false;
            signupButton1.Visible = true;
        }

        private void loginButton1_MouseLeave(object sender, EventArgs e)
        {
            loginButton1.Visible = false;
            loginButton.Visible = true;
        }

        private void signupButton1_MouseLeave(object sender, EventArgs e)
        {
            signupButton1.Visible = false;
            signupButton.Visible = true;
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            loginForm loginFormObj = new loginForm();
            welcomeOutForm wcmoutObj = new welcomeOutForm();
            loginFormObj.TopLevel = true;

            //mf.formPanel.Controls.Clear();
            //mf.formPanel.Controls.Add(loginFormObj);
            loginFormObj.Show();
            signUpForm sgnobj = new signUpForm();
            sgnobj.Dispose();
        }

        private void welcomeOutForm_Load(object sender, EventArgs e)
        {

        }

        private void signupButton1_Click(object sender, EventArgs e)
        {
            signUpForm sgnupoj = new signUpForm();
            welcomeOutForm wcmoutobj = new welcomeOutForm();
            sgnupoj.TopLevel = true;
            sgnupoj.Show();
            loginForm lgnobj = new loginForm();
            lgnobj.Dispose();
        }
    }
}
