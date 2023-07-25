using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int a = 0; a < 24; a++)
            {
                comboBox1.Items.Add(a);
            }
            for (int a = 0; a < 61; a++)
            {
                comboBox2.Items.Add(a);
            }



            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
         timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();



            int saat =Convert.ToInt32(DateTime.Now.Hour);
            int asaat = Convert.ToInt32(comboBox1.Text);
            int dakika = Convert.ToInt32(DateTime.Now.Minute);
            int akika = Convert.ToInt32(comboBox2.Text);
            label4.Text = (saat - asaat).ToString(); ;
            label5.Text = (dakika - akika).ToString();

            if (comboBox1.Text == label1.Text && comboBox2.Text == label2.Text)
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL =textBox1.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            textBox1.Text=  openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
        }
    }
}
