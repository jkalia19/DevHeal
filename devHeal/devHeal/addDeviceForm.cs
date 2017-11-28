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
    public partial class addDeviceForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:/Users/GOD/Documents/databaseDh.mdf;Integrated Security=True;Connect Timeout=30");
        String dos, dod; 
        public addDeviceForm()
        {
            InitializeComponent();
        }

        private void dateofsubmissionTextBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dateofdiliveryTextBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void addDeviceForm_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EID_pT");
            try
            {
                con.Open();
                if (nameTextBox.Text != null || phonenoTextBox.Text != null || emailTextBox.Text != null || deviceTextbox.Text != null || brandTextbox.Text != null || modelTextBox.Text != null || faultTextBox.Text != null || dos != null || dod != null)
                {
                    Random d = new Random();
                    int st = d.Next(1000, 9999);
                    string s = "D" + Convert.ToInt64(st);
                    SqlCommand cmd = new SqlCommand("insert into user_table(DID_dT,cName_dT,cPhone_dT,c_Email_dT,dName_dT,dBrand_dT,dModel_dT,dFault_dT,dDos_dT,dDod_dT)values(@D_id,@cname,@cphone,@cemail,@dname,@dbrand,@dmodel,@dfault,@ddos,@ddod", con);
                    cmd.Parameters.Add("@D_id", SqlDbType.VarChar, 10).Value = s;
                    cmd.Parameters.Add("@cname", SqlDbType.Char, 30).Value = nameTextBox.Text;
                    cmd.Parameters.Add("@cphone", SqlDbType.Int, 10).Value = phonenoTextBox.Text;
                    cmd.Parameters.Add("@cemail", SqlDbType.VarChar, 50).Value = emailTextBox.Text;
                    cmd.Parameters.Add("@dname", SqlDbType.VarChar, 25).Value = deviceTextbox.Text;
                    cmd.Parameters.Add("@dbrand", SqlDbType.VarChar, 25).Value = brandTextbox.Text;
                    cmd.Parameters.Add("@dmodel", SqlDbType.VarChar, 25).Value = modelTextBox.Text;
                    cmd.Parameters.Add("@dfault", SqlDbType.VarChar, 150).Value = faultTextBox.Text;
                    cmd.Parameters.Add("@ddos", SqlDbType.VarChar, 25).Value = dos;
                    cmd.Parameters.Add("@ddod", SqlDbType.VarChar, 25).Value = dod;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Value inserted successfully. Your ID is " + s);
                }
                else
                {
                    MessageBox.Show("Form is not Appropriate... Try Again");
                }
            }
            catch { MessageBox.Show("Added"); }
            con.Close();
        }

        private void dateSubmissionDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dos=dateSubmissionDateTimePicker.Value.ToString();
        }

        private void dateDiliveryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dod=dateDiliveryDateTimePicker.Value.ToString();
        }
    }
}
