using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Admin" && this.textBox2.Text == "Admin")
            {
                MessageBox.Show("Your Username and Password are correct.");
            }
            else
            {
                MessageBox.Show("Wrong input!");
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }
    }
}
