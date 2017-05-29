using System;
using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApp3
{
    public class FileUserStore : IUserStore
    {
        private InMemoryUserStore _store;

        public FileUserStore(InMemoryUserStore store)
        {
            _store = store;
        }
        public void AddUser(User user)
        {
            string userInformation;         
            foreach (var _user in _store.GetUsers())
            {
                userInformation = _user.Name + "^^TopLabs^^"
                    + _user.Username + "^^TopLabs^^" + _user.Password
                    + "^^TopLabs^^" + Environment.NewLine;
                File.AppendAllText("User.toplabs", userInformation); 
            }
        }
        public List<User> GetUsers()
        {
            List<User> _users = new List<User>();
            StreamReader file = new StreamReader("User.toplabs");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] stringSeparators = new string[] { "^^TopLabs^^" };              
                string[] elements = line.ToString().Split(stringSeparators, StringSplitOptions.None);           

                var _user = new User
                {
                    Name = elements[0],
                    Username = elements[1],
                    Password = elements[2]
                };                
                _users.Add(_user);                              
            }
            int i = 1;
            string allUsers = "";
            foreach (var item in _users)
            { 
                allUsers += (i.ToString() + ". " + item.Name.ToString() + "  " +
                item.Username.ToString() + "  " + item.Password.ToString() + "\n");
                i++;               
            }
           return _users;
        }
    }
}
