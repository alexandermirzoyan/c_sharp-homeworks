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

namespace DatabaseTest {
    public partial class Form1 : Form {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Students.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1() {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            if (isFieldsValid()) {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string fathername = txtFathername.Text;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                SqlCommand command = new SqlCommand("INSERT INTO StudentsTable values(@id, @name, @surname, @fathername, @address, @phone)", con);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@id", 1265848);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@fathername", fathername);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@phone", phone);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Տվյալները ավելացան");

            } else {
                MessageBox.Show("Անուն, Ազգանուն, Հայրանուն դաշտերը պարտադիր են");
            }
        }

        private bool isFieldsValid() {
            if (txtName.Text != "" && txtSurname.Text != "" && txtFathername.Text != "") {
                return true;
            }
            else {
                return false;
            }
        }

        private void developmentPart(object sender, EventArgs e) {
            MessageBox.Show("In a development part");
        }

        private void Form1_Load(object sender, EventArgs e) {
            SqlCommand command = new SqlCommand("SELECT * FROM StudentsTable", con);

            con.Open();
            DataTable dataTable = new DataTable();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }
    }
}
