using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class UserService
    {
        private InMemoryUserStore _store;
        private FileUserStore _fileStore;

        public UserService(InMemoryUserStore store,FileUserStore fileStore)
        {
            _store = store;
            _fileStore = fileStore;
        }
        public User Register(string name, string username, string password)
        {
            var user = new User()
            {
                Name = name,
                Password = password,
                Username = username
            };         
            MessageBox.Show("You're registered!");
            _store.AddUser(user);          
            return user;
        }
        public bool Check(string username, string password)
        {
            var user = _fileStore.GetUsers()
                .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefault();
            return user != null;
        }
    }
}
