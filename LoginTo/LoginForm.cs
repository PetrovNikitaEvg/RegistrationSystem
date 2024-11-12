namespace LoginTo;

using System;

public partial class LoginForm : Form
{
    public string LoginUserName = "";
    public LoginForm()
    {
        InitializeComponent();

        if (Properties.Settings.Default.Username != null)
        {
            UsernameTextBox.Text = Properties.Settings.Default.Username;
            PasswordTextBox.Text = Properties.Settings.Default.Password;
        }
        RememberMeButton.Checked = false;
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        var RegisterForm = new RegisterForm();
        RegisterForm.Closed += (s, args) => this.Close();
        RegisterForm.Show();
    }

    private void UsernameText_TextChanged(object sender, EventArgs e)
    {

    }

    private void PasswordText_TextChanged(object sender, EventArgs e)
    {
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        TextFile textfile = new TextFile();
        textfile.username = UsernameTextBox.Text;
        textfile.password = PasswordTextBox.Text;
        LoginUserName = UsernameTextBox.Text;

        MessageBox.Show(textfile.LoginTxtFiles());

        if (textfile.isVerified) 
        {
            textfile.GetData(UsernameTextBox.Text);
            textfile.ChangePassword();
            Properties.Settings.Default.Username = UsernameTextBox.Text;
            this.Hide();
            var MenuForm = new MenuForm();
            MenuForm.Closed += (s, args) => this.Close();
            MenuForm.Show();
        }
    }

    private void RememberMeButton_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
    {
        if (RememberMeButton.Checked)
        {
            Properties.Settings.Default.Username = UsernameTextBox.Text;
            Properties.Settings.Default.Password = PasswordTextBox.Text;
            Properties.Settings.Default.Save();
        }
        else
        {
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();
        }
    }
}
