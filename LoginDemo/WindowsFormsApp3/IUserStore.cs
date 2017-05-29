using System.Collections.Generic;

namespace WindowsFormsApp3
{
    public interface IUserStore
    {
        void AddUser(User user);
        List<User> GetUsers();
    }
}
