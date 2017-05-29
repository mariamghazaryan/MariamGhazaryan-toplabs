using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Signup : Form
    {
        private UserService _userService;
        private FileUserStore _fileUserStore;

        public Signup(UserService userService, FileUserStore fileUserStore)
        {
            InitializeComponent();
            _userService = userService;
            _fileUserStore = fileUserStore;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Password.Text != RetryPassword.Text)
            {
                MessageBox.Show("Yours passwords don't match.Please try again.");
                this.Password.Text = null;
                this.RetryPassword.Text = null;
            }
            else
            {
                _userService.Register(this.Name.Text, this.username.Text, this.Password.Text);
                this.Name.Text = null;
                this.username.Text = null;
                this.Password.Text = null;
                this.RetryPassword.Text = null;
            }                   
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = this.Name.Text,
                Username = this.username.Text,
                Password = this.Password.Text,
            };
            _fileUserStore.AddUser(user);
        }  
        private void button3_Click(object sender, EventArgs e)
        {
            var _users = _fileUserStore.GetUsers();
            int i = 1;
            string allUsers = "";
            foreach (var item in _users)
            {
                allUsers += (i.ToString() + ". " + item.Name.ToString() + "  " +
                    item.Username.ToString() + "  " + item.Password.ToString() + "\n");
                i++;
            }
            MessageBox.Show(allUsers, "User's list");
            this.Close();
        }
    }
}
