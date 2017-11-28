using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace devHeal
{
    public partial class welcomeInForm : Form
    {
        SqlConnection con = new SqlConnection(Program.connectn);
        mainForm mf = new mainForm();
        public String Eid="E1000";
        public welcomeInForm()
        {
            InitializeComponent();
        }


        private void welcomeInForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [Table] where EID_pT=@E_id", con);
            cmd.Parameters.Add("@E_id", SqlDbType.VarChar, 10).Value = mf.Eid;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                uidLabel.Text = dr.GetValue(1).ToString();
                devicePendingShowLabel.Text = dr.GetValue(10).ToString();
                totalDeviceShowLabel.Text = dr.GetValue(11).ToString();
                //    author_t.Text = dr.GetValue(2).ToString();
                //    pages_t.Text = dr.GetValue(3).ToString();
                //    publisher_t.Text = dr.GetValue(4).ToString();
                //    cost_t.Text = dr.GetValue(5).ToString();
                //    info_t.Text = dr.GetValue(6).ToString();
                //    sanction_t.Text = dr.GetValue(7).ToString();
                //}

                dr.Dispose();
                cmd.Dispose();
                con.Close();

            }
        }
        private void addDeviceButton_MouseEnter(object sender, EventArgs e)
        {
            addDeviceButton1.Visible = true;
            addDeviceButton.Visible = false;
            
        }

        private void addDeviceButton1_MouseLeave(object sender, EventArgs e)
        {
            addDeviceButton.Visible = true;
            addDeviceButton1.Visible = false;
            
        }

        private void profileButton_MouseEnter(object sender, EventArgs e)
        {
            profileButton.Visible = false;
            profileButton1.Visible = true;
        }


        private void profileButton1_MouseLeave_1(object sender, EventArgs e)
        {
            profileButton1.Visible = false;
            profileButton.Visible = true;
        }

        private void addDeviceButton1_Click(object sender, EventArgs e)
        {
            addDeviceForm addDeviceObj = new addDeviceForm();
            addDeviceObj.Show();
            this.Hide();
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.ForeColor = Color.Black;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void profileButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
