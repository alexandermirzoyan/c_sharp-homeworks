using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm {
    public partial class FormLogin : Form {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users.mdf;Integrated Security=True;Connect Timeout=30");

        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users.mdf;Integrated Security=True;Connect Timeout=30";
        public FormLogin() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private bool isLogedIn() {
            string login = TextBoxLogin.Text;
            string password = TextBoxPassowrd.Text;

            string selectQuery = "SELECT login, password FROM UsersTable WHERE login = @login AND password = @password";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();

            SqlDataReader sqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection);

            if (sqlDataReader.Read()) {
                if (connection.State == ConnectionState.Open) {
                    connection.Dispose();
                }
                return true;

            }
            else {
                if (connection.State == ConnectionState.Open) {
                    connection.Dispose();
                }
                return false;
            }
        }

        private void LogIn() {
            LoginSuccessForm loginSuccessForm = new LoginSuccessForm();

            if (isLogedIn()) {
                this.Hide();
                loginSuccessForm.Show();
            }
            else {
                TextBoxLogin.Clear();
                TextBoxPassowrd.Clear();
                CheckBoxShowPassword.Checked = false;
                MessageBox.Show("Invalid Login or Password", "Login failed");
            }
        }

        private void ButtonSignIn_Click(object sender, EventArgs e) {
            LogIn();
        }

        private void LinkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Application.Exit();
        }

        private void LinkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SignUp signUpForm = new SignUp();
            this.Hide();
            signUpForm.Show();
        }

        private void LinkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Info");
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void TextBoxPassowrd_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                LogIn();
            }
        }

        private void LinkLabelClearLoginPassowrd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            TextBoxLogin.Clear();
            TextBoxPassowrd.Clear();
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e) {
            if (CheckBoxShowPassword.Checked) {
                TextBoxPassowrd.PasswordChar = '\0';
            } else {
                TextBoxPassowrd.PasswordChar = '*';
            }
        }

        /*
        as a Placeholder 
        private void TextBoxLogin_Enter(object sender, EventArgs e) {
            if (TextBoxLogin.Text == "Login") {
                TextBoxLogin.Text = "";
                TextBoxLogin.ForeColor = Color.Black;
            }
        }

        private void TextBoxLogin_Leave(object sender, EventArgs e) {
            if (TextBoxLogin.Text == "") {
                TextBoxLogin.Text = "Login";
                TextBoxLogin.ForeColor = Color.Silver;
            }
        }

        private void TextBoxPassowrd_Enter(object sender, EventArgs e) {
            if (TextBoxPassowrd.Text == "Password") {
                TextBoxPassowrd.Text = "";
                TextBoxPassowrd.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassowrd_Leave(object sender, EventArgs e) {
            if (TextBoxPassowrd.Text == "") {
                TextBoxPassowrd.Text = "Password";
                TextBoxPassowrd.ForeColor = Color.Silver;
            }
        }*/
    }
}
