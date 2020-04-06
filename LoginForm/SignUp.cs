using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm {
    public partial class SignUp : Form {
        public SignUp() {
            InitializeComponent();
        }

        private void LinkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
        }

        private void ButtonSignUp_Click(object sender, EventArgs e) {
            if (TextBoxName.Text == "" || TextBoxLogin.Text == "" || TextBoxSurname.Text == "" || TextBoxPassowrd.Text == "" || TextBoxEmail.Text == "" || TextBoxRepeatPassowrd.Text == "") {
                MessageBox.Show("Please fill all inputs", "Input validation problem");
            }
            else {
                if (TextBoxPassowrd.Text.Length < 6 && TextBoxRepeatPassowrd.Text.Length < 6) {
                    MessageBox.Show("Passwords must have at least 6 characters", "Password problem");
                }
                else {
                    if (TextBoxPassowrd.Text == TextBoxRepeatPassowrd.Text) {
                        string welcomeText = $"Welcome dear {TextBoxName.Text} {TextBoxSurname.Text} to our application \n" +
                        $"Your Login is ::: {TextBoxLogin.Text} \n" +
                        $"Please check your email ::: {TextBoxEmail.Text}";
                        MessageBox.Show(welcomeText, "Welcome! We were waiting you!");
                    }
                    else {
                        MessageBox.Show("Passwords are not identical", "Password problem");
                    }
                }
            }
        }

        private void LinkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
        }

        private void LinkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Info");
        }

        private void ButtonImageUpload_Click(object sender, EventArgs e) {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK) {
                PictureBoxAvatar.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e) {
            FormLogin form = new FormLogin(); //This is SignIn.cs
            this.Hide();
            form.Show();
        }
    }
}
