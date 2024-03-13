using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_club_program.Navigation
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string surname = Surname.Text;
            
            string filePath = "userdata.txt";

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"Name: {name}, Surname: {surname}");
            }

            MessageBox.Show("Client was registrated");

            this.Hide();
            Manager Manager = new Manager();
            Manager.Show();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
