﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void ButtonSignIn_Click(object sender, EventArgs e) {
            LoginSuccessForm loginSuccessForm = new LoginSuccessForm();

            if ((TextBoxLogin.Text == "admin") && (TextBoxPassowrd.Text == "admin")) {
                //this.Hide();
                loginSuccessForm.Show();
            }
            else {
                MessageBox.Show("Invalid Login or Password", "Login failed");
            }
        }

        private void LinkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
        }

        private void LinkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
        }

        private void LinkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Info");
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
