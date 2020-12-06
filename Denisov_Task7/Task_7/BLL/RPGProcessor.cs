using BLL.Common;
using DAL.Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class RPGProcessor : IProcessable
    {
        private List<User> Users;

        private List<Award> awards;

        private IAccessable dal;

        public RPGProcessor(IAccessable dal)
        {
            this.dal = dal;
        }
        public void addUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool Authenticate(string username, int passwordToCheck)
        {
            Initialize();
            var user = Users.FirstOrDefault(_user => _user.name.ToLower() == username.ToLower());
            var password = dal.GetUserPassword(user.id);
            if(password == passwordToCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<User> GetAllUsers()
        {
            return Users;
        }

        public User GetUserData()
        {
            throw new NotImplementedException();
        }

        private void Initialize()
        {
            Users = dal.GetAllUsers();
            awards = dal.GetAwards();
        }
    }
}
