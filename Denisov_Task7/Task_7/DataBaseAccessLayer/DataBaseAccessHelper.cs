using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Common;
using Entities;

namespace DataBaseAccessLayer
{
    public class DataBaseAccessHelper : IusersDAL
    {

        private static SqlConnection connection = new SqlConnection(_connectionString);
        //в случае проблем с подсоединением к БД проверять это место в первую очередь

        public DataBaseAccessHelper() { }

        private static string _connectionString => ConfigurationManager.ConnectionStrings["DefaultDB"].ConnectionString;

        public void AddAwardToUser(User userToChange, int awardId)
        {
            AddAwardToUser(userToChange.id, awardId);
        }

        public void AddNew(User userToAdd, string password)
        {
            AddUser(userToAdd, password);
        }

        public void ChangeUserData(User userToChange, string password)
        {
            UpdateUserData(userToChange, password);
        }

        public List<User> GetAllUsers()
        {
            List<User> userList = new List<User>(GetUsersList());
            return userList;
        }

        public List<Award> GetAwards()
        {
            List<Award> awardsList = new List<Award>(GetAllAwards());
            return awardsList;
        }

        public List<Award> GetUserAwards(User wantedUser)
        {
            List<Award> userAwardsList = new List<Award>();
            foreach(int awardId in wantedUser.awardsIdList)
            {
                userAwardsList.Add(GetAwardById(awardId));
            }
            return userAwardsList;
        }

        public User GetUserData(int wantedUserId)
        {
            User WantedUser = GetUserById(wantedUserId);
            List<int> UserAwards = new List<int>(GetUserAwardsList(wantedUserId));
            WantedUser.AddAward(UserAwards);
            return WantedUser;
        }
               
        public string GetUserPassword(string wantedUserName)
        {
            //Вызывается при авторизации при вводе никнейма и пароля
            //Первым этапом пользователь находится в БД, затем возвращается его пароль для верификации

            User wantedUser = GetByUserName(wantedUserName);
            return wantedUser.password;
        }

        public void RemoveAwardFromUser(User userToChange, int awardId)
        {
            DeleteAwardFromUser(awardId, userToChange.id);
        }

        public void RemoveUser(User userToDelete)
        {
            DeleteUser(userToDelete.id);
            DeleteUserFromRes(userToDelete.id);
        }

        private IEnumerable<User> GetUsersList()
        {
            using (connection) //действительно ли нужен юзинг, если соединение=константа
            {
                var storedProcedure = "dbo.Users_GetAll";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //реализовать нормальный парсинг из базы
                    var id = (int)reader["id"];
                    var userName = reader["username"] as string;
                    var name = reader["Name"] as string;
                    var dateOfBirth = (DateTime)reader["DateOfBirth"];
                    var age = (int)reader["Age"];
                    var role = reader["role"] as string;

                    yield return new User(id, userName, name, role, dateOfBirth, age);
                }
            }
        }

        private User GetUserById(int wantedId)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Users_GetById";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", wantedId);

                connection.Open();

                var reader = command.ExecuteReader();

                var id = (int)reader["id"];
                var userName = reader["username"] as string;
                var name = reader["Name"] as string;
                var dateOfBirth = (DateTime)reader["DateOfBirth"];
                var age = (int)reader["Age"];
                var role = reader["role"] as string;

                return new User(id, userName, name, role, dateOfBirth, age);

            }
        }

        private void DeleteUser(int idToDelete)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Users_DeleteById";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", idToDelete);

                connection.Open();

                var reader = command.ExecuteReader();
            }
        }

        private void AddUser(User userToAdd, string password)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Users_AddUser";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@username", userToAdd.userName);
                command.Parameters.AddWithValue("@Name", userToAdd.name);
                command.Parameters.AddWithValue("@DateOfBirth", userToAdd.dateOfBirth);
                command.Parameters.AddWithValue("@Age", userToAdd.age);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", userToAdd.role);

                connection.Open();

                var reader = command.ExecuteReader();
            }
        }

        private User GetByUserName(string wantedUserName)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Users_GetByUsername";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@userName", wantedUserName);

                connection.Open();

                var reader = command.ExecuteReader();

                var id = (int)reader["id"];
                var userName = reader["username"] as string;
                var name = reader["Name"] as string;
                var dateOfBirth = (DateTime)reader["DateOfBirth"];
                var age = (int)reader["Age"];
                var role = reader["role"] as string;

                return new User(id, userName, name, role, dateOfBirth, age);

            }
        }

        private string GetPassword(User wantedUser)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Users_GetByUsername";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@userName", wantedUser.userName);

                connection.Open();

                var reader = command.ExecuteReader();

                var password = reader["password"] as string;

                return password;

            }
        }

        private void UpdateUserData(User userToChange, string password)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Users_UpdateUserById";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@username", userToChange.userName);
                command.Parameters.AddWithValue("@Name", userToChange.name);
                command.Parameters.AddWithValue("@DateOfBirth", userToChange.dateOfBirth);
                command.Parameters.AddWithValue("@Age", userToChange.age);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", userToChange.role);
                command.Parameters.AddWithValue("@id", userToChange.id);

                connection.Open();

                var reader = command.ExecuteReader();
            }
        }

        private IEnumerable<Award> GetAllAwards()
        {
            using (connection)
            {
                var storedProcedure = "dbo.Awards_GetAll";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //реализовать нормальный парсинг из базы
                    var id = (int)reader["id"];
                    var title = reader["title"] as string;

                    yield return new Award(id, title);
                }
            }
        }

        private Award GetAwardById(int wantedId)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Awards_GetById";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", wantedId);

                connection.Open();

                var reader = command.ExecuteReader();

                //реализовать нормальный парсинг из базы
                var id = (int)reader["id"];
                var title = reader["title"] as string;

                return new Award(id, title);
            }
        }

        private void AddAwardToUser(int wantedAwardId, int wantedUserId)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Result_AddAwardToUser";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@userId", wantedAwardId);
                command.Parameters.AddWithValue("@AwardId", wantedUserId);

                connection.Open();

                var reader = command.ExecuteReader();
            }
        }

        private void DeleteAwardFromUser(int wantedAwardId, int wantedUserId)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Result_AddAwardToUser";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@userId", wantedAwardId);
                command.Parameters.AddWithValue("@AwardId", wantedUserId);

                connection.Open();

                var reader = command.ExecuteReader();
            }
        }

        private void DeleteUserFromRes(int wantedUserId)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Result_DeleteUser";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", wantedUserId);

                connection.Open();

                var reader = command.ExecuteReader();
            }
        }

        private IEnumerable<int> GetUserAwardsList(int wantedUserId)
        {
            using (connection)
            {
                var storedProcedure = "dbo.Result_GetUserAwards";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", wantedUserId);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = (int)reader["AwardId"];

                    yield return id;
                }
            }
        }
    }
}
