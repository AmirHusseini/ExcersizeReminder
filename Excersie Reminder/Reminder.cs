using System;
using System.Drawing;
using System.Windows.Forms;

namespace Excersie_Reminder
{
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
        }
        string currenttime;
        string messagetime;
        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currenttime = DateTime.Now.ToString("HH:mm");
            label1.Text = currenttime;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            messagetime = maskedTextBox1.Text;
            label4.Text = "Reminder set for: " + messagetime;
            if (currenttime == messagetime)
            {
                timer2.Stop();
                MessageBox.Show(textBox1.Text);
                button1.Enabled = true;
                button2.Enabled = false;

                label4.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
            label4.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tim = 5000;
            notifyIcon1.Visible = true;
            this.Hide();
            notifyIcon1.ShowBalloonTip(tim);
            notifyIcon1.Icon = SystemIcons.Application;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible=false;
        }

        
       
    }
}
