﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Common
{
    public interface IAccessable
    {
        void AddAwardToUser(User userToChange, int awardId);

        void AddNew(User userToAdd, string password);

        void ChangeUserData(User userToChange, string password);

        List<User> GetAllUsers();

        List<Award> GetAwards();

        List<Award> GetUserAwards(User wantedUser);

        User GetUserData(int wantedUserId);

        int GetUserPassword(int wantedUserName);

        void RemoveAwardFromUser(User userToChange, int awardId);

        void RemoveUser(User userToDelete);
    }
}
