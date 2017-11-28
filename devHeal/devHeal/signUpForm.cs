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
 
    public partial class signUpForm : Form
    {
        String dob;
        SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=databaseDh;Integrated Security=True");
        public signUpForm()
        {
            InitializeComponent();
        }

        private void signupButton_MouseEnter(object sender, EventArgs e)
        {
            signupButton.Visible = false;
            signupButton1.Visible = true;
        }

        private void signupButton1_MouseLeave(object sender, EventArgs e)
        {
            signupButton1.Visible = false;
            signupButton.Visible = true;
        }

        private void genderCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            genderCombobox.Text = "";
            genderCombobox.ForeColor = Color.Black;
        }

        private void pwdTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pwdTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            pwdTextBox.Clear();
            pwdTextBox.ForeColor = Color.Black;
            pwdTextBox.PasswordChar = '*';
        }

        private void signupButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (fnameTextBox.Text != null && lnameTextBox.Text != null && orgnameTextBox.Text != null && genderCombobox.Text != null && dob != null && phonenoTextBox.Text != null && emailTextBox.Text != null && addressTextBox.Text != null && pwdTextBox.Text != null && rePwdTextBox.Text != null && pwdTextBox.Text == rePwdTextBox.Text)
                {
                    Random d = new Random();
                    int st = d.Next(1000, 9999);
                    string s = "E" + Convert.ToInt64(st);
                    SqlCommand cmd = new SqlCommand("insert into user_table(EID_pT,firstname_pT,lastname_pT,userID_pT,gender_pT,dob_pT,phobeno_pT,emailID_pT,address_pT,password_pT)values(@E_id,@fname,@lname,@U_id,@gender,@dob,@phoneno,@email,@address,@password)", con);
                    cmd.Parameters.Add("@E_id", SqlDbType.VarChar, 10).Value = s;
                    cmd.Parameters.Add("@fname", SqlDbType.Char, 20).Value = fnameTextBox.Text;
                    cmd.Parameters.Add("@lname", SqlDbType.Char, 20).Value = lnameTextBox.Text;
                    cmd.Parameters.Add("@U_id", SqlDbType.Char, 20).Value = orgnameTextBox.Text;
                    cmd.Parameters.Add("@gender", SqlDbType.Char, 1).Value = genderCombobox.Text;
                    cmd.Parameters.Add("@dob", SqlDbType.VarChar, 25).Value = dob;
                    cmd.Parameters.Add("@phoneno", SqlDbType.Int, 50).Value = phonenoTextBox.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = emailTextBox.Text;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 200).Value = addressTextBox.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar, 16).Value = pwdTextBox.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Value inserted successfully. Your ID is " + s);
                }
                else
                {
                    MessageBox.Show("Form is not Appropriate... Try Again");
                }
            }
            catch
            { MessageBox.Show("Added"); }
            con.Close();
            }

        private void signUpForm_Load(object sender, EventArgs e)
        {
        
        }

        private void dateBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        
            dob = dateBirthDateTimePicker.Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        }

        //private void signUpForm_Load(object sender, EventArgs e)
        //{

        //}

        //private void dateBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        //{
        
        //}

       
    }
