using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginTo
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            TextFile textfile = new TextFile();
            textfile.username = UsernameTextBox.Text;
            textfile.password = PasswordTextBox.Text;
            textfile.name = NameTextBox.Text;
            textfile.birthPlace = BirthPlaceTextBox.Text;
            textfile.phoneNumber = PhoneNumberTextBox.Text;

            MessageBox.Show(textfile.SaveTxtFiles());

            this.Hide();
            var LoginForm = new LoginForm();
            LoginForm.Closed += (s, args) => this.Close();
            LoginForm.Show();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LoginForm = new LoginForm();
            LoginForm.Closed += (s, args) => this.Close();
            LoginForm.Show();
        }
    }
}
