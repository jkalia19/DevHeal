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
    public partial class forgotPasswordFrom : Form
    {
        public forgotPasswordFrom()
        {
            InitializeComponent();
        }

        private void recoverButton_MouseEnter(object sender, EventArgs e)
        {
            recoverButton.Visible = false;
            recoverButton1.Visible = true;
        }

        private void recoverButton1_MouseLeave(object sender, EventArgs e)
        {
            recoverButton1.Visible = false;
            recoverButton.Visible = true;
        }
    }
}
