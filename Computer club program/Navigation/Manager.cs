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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enter enter = new Enter();
            enter.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm RegForm = new RegForm();
            RegForm.Show();
        }

        private void CompButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompForm CompForm = new CompForm();
            CompForm.Show();
        }
    }
}
