using System;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int s, m, h;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --s;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if (h == -1)
            {
                h = h - 1;
                m = 59;
            }
            label1.Text = h + " : " + m + " : " + s;
            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло");
                Application.Exit();
            }
            progressBar1.PerformStep();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            h = (int)this.numericUpDown3.Value;
            m = (int)this.numericUpDown2.Value;
            s = (int)this.numericUpDown1.Value + 1;

            timer1.Start();
            button2.Enabled = true;

            progressBar1.Maximum = h * 60 + m * 60 + (s - 1);
            progressBar1.Value = h * 60 + m * 60 + (s - 1);

            progressBar1.Step = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
