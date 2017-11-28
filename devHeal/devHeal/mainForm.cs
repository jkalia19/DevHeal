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
    public partial class mainForm : Form
    {
        loginForm lgf = new loginForm();
        public String Eid="E1000";
        public mainForm()
        {
            InitializeComponent();
        }

        

        private void welcomeButton_MouseHover(object sender, EventArgs e)
        {
            welcomeButton.Visible = false;
            welcomeButton1.Visible = true;
        }

        private void welcomeButton1_MouseLeave(object sender, EventArgs e)
        {
            welcomeButton1.Visible = false;
            welcomeButton.Visible = true;
        }
        

        private void profileButton_MouseHover_1(object sender, EventArgs e)
        {
            profileButton.Visible = false;
            profileButton1.Visible = true;
        }

        private void profileButton1_MouseLeave(object sender, EventArgs e)
        {
            profileButton1.Visible = false;
            profileButton.Visible = true;
        }

        private void addDeviceButton_MouseHover(object sender, EventArgs e)
        {
            addDeviceButton.Visible = false;
            addDeviceButton1.Visible = true;
        }

        private void editDeviceButton_MouseHover(object sender, EventArgs e)
        {
            editDeviceButton.Visible = false;
            editDeviceButton1.Visible = true;
        }

        private void aboutusButton_MouseHover(object sender, EventArgs e)
        {
            aboutusButton.Visible = false;
            aboutUsButton1.Visible = true;
        }

        private void feedbackButton_MouseHover(object sender, EventArgs e)
        {
            feedbackButton.Visible = false;
            feedbackButton1.Visible = true;
        }
      

        private void addDeviceButton1_MouseLeave(object sender, EventArgs e)
        {
            addDeviceButton1.Visible = false;
            addDeviceButton.Visible = true;
        }

        private void editDeviceButton1_MouseLeave(object sender, EventArgs e)
        {
            editDeviceButton1.Visible = false;
            editDeviceButton.Visible = true;
        }

        private void aboutUsButton1_MouseLeave(object sender, EventArgs e)
        {
            aboutUsButton1.Visible = false;
            aboutusButton.Visible = true;
        
        }

        private void feedbackButton1_MouseLeave(object sender, EventArgs e)
        {
            feedbackButton1.Visible = false;
            feedbackButton.Visible = true;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Visible = false;
            closeButton1.Visible = true;
        }

        private void signoutButton_MouseEnter(object sender, EventArgs e)
        {
            signoutButton.Visible = false;
            signoutButton1.Visible = true;
        }

        private void closeButton1_MouseLeave(object sender, EventArgs e)
        {
            closeButton1.Visible = false;
            closeButton.Visible = true;
        }

        private void signoutButton1_MouseLeave(object sender, EventArgs e)
        {
            signoutButton1.Visible = false;
            signoutButton.Visible = true;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
                welcomeOutForm welcomeOutFormObj = new welcomeOutForm();
                welcomeOutFormObj.TopLevel = false;
                formPanel.Controls.Clear();
                formPanel.Controls.Add(welcomeOutFormObj);
                welcomeOutFormObj.Show();
               // Eid = uidLabel.Text = lgf.Eid;
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void signoutButton1_Click(object sender, EventArgs e)
        {
            if (lgf.Eid != " ")
            {
                welcomeOutForm welcomeOutFormObj = new welcomeOutForm();
                welcomeOutFormObj.TopLevel = false;
                formPanel.Controls.Clear();
                formPanel.Controls.Add(welcomeOutFormObj);
                welcomeOutFormObj.Show();
            }
        }

        private void addDeviceButton1_Click(object sender, EventArgs e)
        {
            if (lgf.Eid != " ")
            {
                addDeviceForm addDeviceObj = new addDeviceForm();
                addDeviceObj.TopLevel = false;
                formPanel.Controls.Clear();
                formPanel.Controls.Add(addDeviceObj);
                addDeviceObj.Show();
            }
        }

        private void welcomeButton1_Click(object sender, EventArgs e)
        {
            if (lgf.Eid != " ")
            {
                welcomeInForm welcomeFormObj = new welcomeInForm();
                welcomeFormObj.TopLevel = false;
                formPanel.Controls.Clear();
                formPanel.Controls.Add(welcomeFormObj);
                welcomeFormObj.Show();
            }
            else
              MessageBox.Show("Login FIrst");
        }

        private void profileButton1_Click(object sender, EventArgs e)
        {
            if (lgf.Eid != " ")
            {
                profileForm profileFormObj = new profileForm();
                profileFormObj.TopLevel = false;
                formPanel.Controls.Clear();
                formPanel.Controls.Add(profileFormObj);
                profileFormObj.Show();
            }
            else
                MessageBox.Show("Login FIrst");
        
        }

        private void editDeviceButton1_Click(object sender, EventArgs e)
        {
            if (lgf.Eid != " ")
            {
                editDeviceForm editDeviceObj = new editDeviceForm();
                editDeviceObj.TopLevel = false;
                formPanel.Controls.Clear();
                formPanel.Controls.Add(editDeviceObj);
                editDeviceObj.Show();
            }
            else
                MessageBox.Show("Login FIrst");
        
        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutUsButton1_Click(object sender, EventArgs e)
        {
            About_US abtusFormObj = new About_US();
            abtusFormObj.TopLevel = false;
            formPanel.Controls.Clear();
            formPanel.Controls.Add(abtusFormObj);
            abtusFormObj.Show();
        }

        private void feedbackButton1_Click(object sender, EventArgs e)
        {
            Feedback fdbckObj = new Feedback();
            fdbckObj.TopLevel = false;
            formPanel.Controls.Clear();
            formPanel.Controls.Add(fdbckObj);
            fdbckObj.Show();
        }        
    }
}
