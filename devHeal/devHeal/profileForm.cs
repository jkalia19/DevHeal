﻿using System;
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
    
       
    public partial class profileForm : Form
    {
        public profileForm()
        {
            InitializeComponent();
        }

        private void updateButton_MouseEnter(object sender, EventArgs e)
        {
            updateButton.Visible = false;
            updateButton1.Visible = true;
        }

        private void updateButton1_MouseLeave(object sender, EventArgs e)
        {
            updateButton1.Visible = false;
            updateButton.Visible = true;
        }

        
        

        private void profileForm_Load(object sender, EventArgs e)
        {

        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added");
        }
    }
}
                                                                                