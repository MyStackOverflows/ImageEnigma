using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CredentialsCheck
{
    public partial class CredentialsForm : Form
    {
        #region GUIs
        //To add to a different project, press <Ctrl + Shift + A> and create a new
        //Windows Form. Name it 'CredentialsForm.cs' and then save & close the project.
        //Go to the project directory and delete the 'CredentialsForm.cs' & the
        //'CredentialsForm.Designer.cs' file. Then, copy the three 'CredentialsForm*' files
        //from this project's directory to the one that you are adding this project.
        //Add an 'Application.Run(new CredentialsCheck.CredentialsForm());' to the beginning
        //of the place where all the other 'Application.Run(*)' entries are in 'Program.cs'
        //of your target program. Then you need to choose the '491.ico' file as the icon
        //for the CredentialsForm. This icon file is in:
        //'C:\Code\C#\Windows\All Icons\491.ico'
        //Then...You're done! Yay! :-)
        public bool exitValue = false;

        public CredentialsForm()
        {
            InitializeComponent();
        }

        public void submit()
        {
            string enteredPassword = PasswordTextBox.Text;

            if (enteredPassword.Equals("fishy15"))
            {
                exitValue = true;
                Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exitValue)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string enteredPassword = PasswordTextBox.Text;

            if (enteredPassword.Equals("fishy15"))
            {
                exitValue = true;
                Close();
            }
        }
        #endregion

        #region Console
        //To add to a different project, add the folowing two methods
        //to the <Program.cs> file. Then, add the following loop to the
        //beginning of your Main() method:
        //
        //bool CorrectPassword = false;
        //while (CorrectPassword.Equals(false))
        //    CorrectPassword = PasswordCheck();
        //Console.Clear();
        //
        //Then...You're done! Yay! :-)

        static bool PasswordCheck()
        {
            Console.Clear();
            Console.Title = "Credentials Check";
            LinkedList<string> passwords = new LinkedList<string>();
            int passwordIndex = 0;
            int num = 1;
            passwords.AddLast("fishy15");
            passwords.AddLast("solo15");
            passwords.AddLast("765615");
            passwords.AddLast("3474915");
            string password = passwords.ElementAt<string>(passwordIndex);
            Console.Write("Please type the password (" + num + "): ");
            string enteredPassword = ReadPassword();
            while (enteredPassword != password)
            {
                if (enteredPassword.Equals(password))
                    break;
                else
                {
                    if (passwordIndex < 3)
                    {
                        passwordIndex += 1;
                        num = passwordIndex + 1;
                    }
                    else
                    {
                        passwordIndex = 0;
                        num = passwordIndex + 1;
                    }
                    password = passwords.ElementAt<string>(passwordIndex);
                    Console.Clear();
                    Console.Write("Please type the password (" + num + "): ");
                    enteredPassword = ReadPassword();
                }
            }
            return true;
        }

        static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length - 1);
                    }
                }
                info = Console.ReadKey(true);
            }
            return password;
        }

        #endregion
    }
}
