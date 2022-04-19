using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageEnigma
{
    public partial class CredentialsForm : Form
    {
        public bool exitValue = false;

        public CredentialsForm()
        {
            InitializeComponent();
        }

        private void Submit(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Equals("password"))
            {
                exitValue = true;
                Close();
            }
        }
    }
}
