using BLL.Common;
using DAL.Common;
using Entities;
using System;
using System.Collections.Generic;

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

        public void Authorize(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            return Users;
        }

        public User GetUserData()
        {
            throw new NotImplementedException();
        }
    }
}
