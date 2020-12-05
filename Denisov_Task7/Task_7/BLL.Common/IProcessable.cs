using Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Common
{
    public interface IProcessable
    {
        void addUser(User user);

        List<User> GetAllUsers();

        bool Authenticate(string username, int password);

        User GetUserData();
    }
}
