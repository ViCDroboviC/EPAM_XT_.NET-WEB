﻿using Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Common
{
    public interface IBLL
    {
        void addUser(User user);

        List<User> GetAllUsers();

        void Authorize(string username, string password);

        User GetUserData();
    }
}
