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
    public partial class LoginSuccessForm : Form {
        public LoginSuccessForm() {
            InitializeComponent();
        }

        private void LoginSuccessForm_FormClosed(object sender, FormClosedEventArgs e) {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }
    }
}
