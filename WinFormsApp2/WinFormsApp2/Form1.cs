using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            btnXirdala.Click += btnXirdala_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnXirdala_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            if (string.IsNullOrWhiteSpace(mtxtMebleg.Text))
            {
                errorProvider1.SetError(mtxtMebleg, "Məbləğ daxil edin");
                return;
            }

            errorProvider1.SetError(mtxtMebleg, "");

            if (!int.TryParse(mtxtMebleg.Text, out int mebleg))
            {
                MessageBox.Show(
                    "Düzgün məbləğ daxil edin",
                    "Diqqət",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (mebleg <= 0)
            {
                MessageBox.Show(
                    "Mənfi və ya sıfır məbləğ xırdalanmaz",
                    "Diqqət",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int qaliq = mebleg;

            int say500 = qaliq / 500;
            qaliq %= 500;

            int say200 = qaliq / 200;
            qaliq %= 200;

            int say100 = qaliq / 100;
            qaliq %= 100;

            int say50 = qaliq / 50;
            qaliq %= 50;

            int say20 = qaliq / 20;
            qaliq %= 20;

            int say10 = qaliq / 10;
            qaliq %= 10;

            int say5 = qaliq / 5;
            qaliq %= 5;

            int say1 = qaliq;

            if (say1 > 0)
            {
                pictureBox1.Visible = true;
                label1.Visible = true;
                label1.Text = say1.ToString();
            }

            if (say5 > 0)
            {
                pictureBox2.Visible = true;
                label2.Visible = true;
                label2.Text = say5.ToString();
            }

            if (say10 > 0)
            {
                pictureBox3.Visible = true;
                label3.Visible = true;
                label3.Text = say10.ToString();
            }

            if (say20 > 0)
            {
                pictureBox4.Visible = true;
                label4.Visible = true;
                label4.Text = say20.ToString();
            }

            if (say50 > 0)
            {
                pictureBox5.Visible = true;
                label5.Visible = true;
                label5.Text = say50.ToString();
            }

            if (say100 > 0)
            {
                pictureBox6.Visible = true;
                label6.Visible = true;
                label6.Text = say100.ToString();
            }

            if (say200 > 0)
            {
                pictureBox7.Visible = true;
                label7.Visible = true;
                label7.Text = say200.ToString();
            }

            if (say500 > 0)
            {
                pictureBox8.Visible = true;
                label8.Visible = true;
                label8.Text = say500.ToString();
            }
        }
    }
}