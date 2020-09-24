using BLL.Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RPGLogicLayer : IBLL
    {
        private List<User> UserList;

        public RPGLogicLayer()
        {
            UserList = new List<User>();
            UserList.Add(new User(1, "Vic", "Viktor", "admin", DateTime.Now, 5));
            UserList.Add(new User(2, "Andrew", "Viktor", "admin", DateTime.Now, 5));
            UserList.Add(new User(3, "Roman", "Viktor", "admin", DateTime.Now, 5));
        }
        public void addUser(User user)
        {
            throw new NotImplementedException();
        }

        public void Authorize(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            return UserList;
        }

        public User GetUserData()
        {
            throw new NotImplementedException();
        }
    }
}
