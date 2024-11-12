using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTo
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            string UserNameForData = Properties.Settings.Default.Username;
            InitializeComponent();

            TextFile textfile = new TextFile();

            string[] MyArray = textfile.GetData(UserNameForData);

            UserDBView.ColumnCount = 5;
            UserDBView.Columns[0].Name = "Username";
            UserDBView.Columns[1].Name = "Password in DB";
            UserDBView.Columns[2].Name = "Full Name";
            UserDBView.Columns[3].Name = "Birth Place";
            UserDBView.Columns[4].Name = "Phone Number";
            string? Name = textfile.name;

            UserDBView.Rows.Add(MyArray[0],
                MyArray[1],
                MyArray[2],
                MyArray[3],
                MyArray[4]);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LoginForm = new LoginForm();
            LoginForm.Closed += (s, args) => this.Close();
            LoginForm.Show();
        }
    }
}
