using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        private UserService _userService;
        private FileUserStore _fileUserStore;

        public Login(UserService userService,FileUserStore fileUserStore)
        {
            InitializeComponent();
            _userService = userService;
            _fileUserStore = fileUserStore;
        }       
        private void button1_Click_2(object sender, EventArgs e)
        {
            var userExists = _userService.Check(this.username.Text, this.password.Text);
            if (userExists)
            {
                MessageBox.Show("Welcome to our page!","Welcome!", 0, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Something is wrong. Please try again!", "Error!",
                    0, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var signupForm = new Signup(_userService,_fileUserStore);
            signupForm.Show();
        }
    }
}
