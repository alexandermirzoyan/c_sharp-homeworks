using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collage_schedule {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            if (buttonSave.Text == "Պահպանել") {
                timer1.Start();
                buttonSave.Text = "Պահպանված";
            } else {
                buttonSave.Text = "Պահպանել";
            }
        }
        private void comboBoxOnClick(object sender, EventArgs e) {
            if (buttonSave.Text == "Պահպանված") {
                buttonSave.Text = "Պահպանել";
            }
        }

        private void clearSchedule() {
            startHour_1.Text = "";
            startMinute_1.Text = "";
            startSecond_1.Text = "";

            endHour_1.Text = "";
            endMinute_1.Text = "";
            endSecond_1.Text = "";

            startHour_2.Text = "";
            startMinute_2.Text = "";
            startSecond_2.Text = "";

            endHour_2.Text = "";
            endMinute_2.Text = "";
            endSecond_2.Text = "";

            startHour_3.Text = "";
            startMinute_3.Text = "";
            startSecond_3.Text = "";

            endHour_3.Text = "";
            endMinute_3.Text = "";
            endSecond_3.Text = "";

            startHour_4.Text = "";
            startMinute_4.Text = "";
            startSecond_4.Text = "";

            endHour_4.Text = "";
            endMinute_4.Text = "";
            endSecond_4.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            currentTime.Text = hour + ":" + minute + ":" + second;

            string startHour_1_text = startHour_1.Text;
            string startHour_2_text = startHour_2.Text;
            string startHour_3_text = startHour_3.Text;
            string startHour_4_text = startHour_4.Text;

            string endHour_1_text = endHour_1.Text;
            string endHour_2_text = endHour_2.Text;
            string endHour_3_text = endHour_3.Text;
            string endHour_4_text = endHour_4.Text;

            string startMinute_1_text = startMinute_1.Text;
            string startMinute_2_text = startMinute_2.Text;
            string startMinute_3_text = startMinute_3.Text;
            string startMinute_4_text = startMinute_4.Text;

            string endMinute_1_text = endMinute_1.Text;
            string endMinute_2_text = endMinute_2.Text;
            string endMinute_3_text = endMinute_3.Text;
            string endMinute_4_text = endMinute_4.Text;

            string startSecond_1_text = startSecond_1.Text;
            string startSecond_2_text = startSecond_2.Text;
            string startSecond_3_text = startSecond_3.Text;
            string startSecond_4_text = startSecond_4.Text;

            string endSecond_1_text = endSecond_1.Text;
            string endSecond_2_text = endSecond_2.Text;
            string endSecond_3_text = endSecond_3.Text;
            string endSecond_4_text = endSecond_4.Text;

            if (startHour_1_text == hour && startMinute_1_text == minute && startSecond_1_text == second ||
                startHour_2_text == hour && startMinute_2_text == minute && startSecond_2_text == second || 
                startHour_3_text == hour && startMinute_3_text == minute && startSecond_3_text == second ||
                startHour_4_text == hour && startMinute_4_text == minute && startSecond_4_text == second ||
                endHour_1_text == hour && endMinute_1_text == minute && endSecond_1_text == second ||
                endHour_2_text == hour && endMinute_2_text == minute && endSecond_2_text == second ||
                endHour_3_text == hour && endMinute_3_text == minute && endSecond_3_text == second ||
                endHour_4_text == hour && endMinute_4_text == minute && endSecond_4_text == second) {
                axWindowsMediaPlayer1.URL = "C:\\Users\\User\\OneDrive\\Рабочий стол\\school-bell-sound.mp3";
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            timer1.Start();
            for (int i = 0; i <= 23; i++) {
                startHour_1.Items.Add(i);
                startHour_2.Items.Add(i);
                startHour_3.Items.Add(i);
                startHour_4.Items.Add(i);

                endHour_1.Items.Add(i);
                endHour_2.Items.Add(i);
                endHour_3.Items.Add(i);
                endHour_4.Items.Add(i);

                startHour.Items.Add(i);
            }

            for (int i = 0; i <= 59; i++) {
                startMinute_1.Items.Add(i);
                startMinute_2.Items.Add(i);
                startMinute_3.Items.Add(i);
                startMinute_4.Items.Add(i);

                startSecond_1.Items.Add(i);
                startSecond_2.Items.Add(i);
                startSecond_3.Items.Add(i);
                startSecond_4.Items.Add(i);

                endMinute_1.Items.Add(i);
                endMinute_2.Items.Add(i);
                endMinute_3.Items.Add(i);
                endMinute_4.Items.Add(i);

                endSecond_1.Items.Add(i);
                endSecond_2.Items.Add(i);
                endSecond_3.Items.Add(i);
                endSecond_4.Items.Add(i);

                startMinute.Items.Add(i);
                startSecond.Items.Add(i);
            }
        }

        private void BellStop_Click(object sender, EventArgs e) {
            if (axWindowsMediaPlayer1.URL != "") {
                axWindowsMediaPlayer1.URL = "";
            }
        }

        private void BellStart_Click(object sender, EventArgs e) {
            if (axWindowsMediaPlayer1.URL == "") {
                axWindowsMediaPlayer1.URL = "C:\\Users\\User\\OneDrive\\Рабочий стол\\school-bell-sound.mp3";
            }
        }

        private void Confirm_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Ցանկանում եք դաշտերը լրացնել Երևանի ինֆորմատիկայի պետական քոլեջի ժամատախտակին համապատասխան?", "Հաստատում", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                // SOME HARDCODES PARTS ARE HARDCODE, BUT WORKS FINE!!!

                string firstLessonStartHour = startHour.Text;
                string firstLessonStartMinute = startMinute.Text;
                string firstLessonStartSecond = startSecond.Text;
                /*int breakTime = 10;
                int lessonTime = 70;*/

                startHour_1.Text = "9";
                startMinute_1.Text = "0";
                startSecond_1.Text = "0";

                endHour_1.Text = Convert.ToString(Convert.ToInt32(startHour_1.Text) + 1);
                endMinute_1.Text = Convert.ToString(Convert.ToInt32(startMinute_1.Text) + 10);
                endSecond_1.Text = "0";

                startHour_2.Text = Convert.ToString(Convert.ToInt32(endHour_1.Text) + 1);
                startMinute_2.Text = Convert.ToString(Convert.ToInt32(endMinute_1.Text) + 10);
                startSecond_2.Text = "0";

                endHour_2.Text = Convert.ToString(Convert.ToInt32(startHour_2.Text) + 1);
                endMinute_2.Text = Convert.ToString(Convert.ToInt32(startMinute_2.Text) + 10);
                endSecond_2.Text = "0";

                startHour_3.Text = endHour_2.Text;
                startMinute_3.Text = Convert.ToString(Convert.ToInt32(endMinute_2.Text) + 20);
                startSecond_3.Text = "0";

                endHour_3.Text = Convert.ToString(Convert.ToInt32(startHour_3.Text) + 1);
                endMinute_3.Text = "0";
                endSecond_3.Text = "0";

                startHour_4.Text = endHour_3.Text;
                startMinute_4.Text = Convert.ToString(Convert.ToInt32(endMinute_3.Text) + 10);
                startSecond_4.Text = "0";

                endHour_4.Text = Convert.ToString(Convert.ToInt32(startHour_4.Text) + 1);
                endMinute_4.Text = Convert.ToString(Convert.ToInt32(startMinute_4.Text) + 10);
                endSecond_4.Text = "0";
            }
            else {
                MessageBox.Show("Խնդրում ենք լրացնել դաշտերը ձեռքով։");
                clearSchedule();
            }
        }

        private void InfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Այս ժամատախտակի ավտոմատ լրացումը պատրաստված է Երևանի ինֆորմատիկայի պետական քոլեջի դասերին համապատասխան");
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            clearSchedule();
        }
    }
}
