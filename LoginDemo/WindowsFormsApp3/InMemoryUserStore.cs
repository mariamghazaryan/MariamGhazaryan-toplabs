using System.Collections.Generic;
namespace WindowsFormsApp3
{
    public class InMemoryUserStore : IUserStore
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }
        public List<User> GetUsers()
        {
            return _users;
        }
    }
}
