using Entities;
using System.Collections.Generic;

namespace common
{
    public interface IusersDAL
    {
        void AddNew(User userToAdd, string password); //добавление нового пользователя

        User GetUserData(int wantedUserId); //для получения полных данных о пользователе

        string GetUserPassword(string wantedUserName); //для проверки пароля при авторизации

        void ChangeUserData(User userToChange, string password); //изменение данных

        List<User> GetAllUsers(); //получить список всех пользователей

        List<Award> GetAwards(); //получить список всех возможных наград

        List<Award> GetUserAwards(User wantedUser); //получение списка наград пользователя

        void AddAwardToUser(User userToChange, int awardId); //награждение пользователя

        void RemoveAwardFromUser(User userToChange, int awardId); //убрать награду

        void RemoveUser(User userToDelete);
    } 
}
