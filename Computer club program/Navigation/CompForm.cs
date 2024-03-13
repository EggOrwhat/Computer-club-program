using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_club_program.Navigation
{
    public partial class CompForm : Form
    {
      
        public CompForm()
        {
            InitializeComponent();
        }

        private void CompForm_Load(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager Manager = new Manager();
            Manager.Show();
        }
        TimeSpan timeLeft = new TimeSpan(0, 0, 14, 0);
        private void Computertimer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
            timeLabel.Text = timeLeft.ToString(@"hh\:mm\:ss");
        }

        private void setTimerButton_Click(object sender, EventArgs e)
        {
            int enteredMinutes = Int32.Parse(timeTextBox.Text);
            timeLeft = new TimeSpan(0, 0, enteredMinutes, 0);
            timeLabel.Text = timeLeft.ToString(@"hh\:mm\:ss");
            Computertimer.Start();
        }
      

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
