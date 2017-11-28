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
    
    public partial class loginForm : Form
    {
       public String Eid;
       SqlConnection con = new SqlConnection(Program.connectn);
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.Visible = false;
            loginButton1.Visible = true;
        }

        private void loginButton1_MouseLeave(object sender, EventArgs e)
        {
            loginButton1.Visible = false;
            loginButton.Visible = true;
        }

        private void forgotPasswordLinkLabel_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null && textBox2.Text != null)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from [Table] where EID_pT=@Eid", con);
                    cmd.Parameters.Add("@Eid", SqlDbType.VarChar, 10).Value = textBox1.Text;
                    //cmd.Parameters.Add("@password", SqlDbType.VarChar, 16).Value = textBox2.Text;
                    //string pwd= cmd.Parameters.Add("@U_password", SqlDbType.NVarChar, 50).Value;
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        if (textBox2.Text == dr.GetValue(9).ToString())
                        {
                            Eid = textBox1.Text;
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password" + Eid);
                            Eid = "E1000";
                        }
                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("your user  name or pwd is wrong");
                    }
                }
            }
            catch
            { 
                Eid="E1000";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
