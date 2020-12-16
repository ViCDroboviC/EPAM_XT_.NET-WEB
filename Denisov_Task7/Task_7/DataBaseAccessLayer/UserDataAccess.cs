using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccessLayer
{
    internal class UserDataAccess : AbstractAccess
    {
        public UserDataAccess(string coonectionString) : base(coonectionString)
        {
        }

        internal IEnumerable<User> GetUsersList()
        {
            using (connection = new SqlConnection(connectionString))
            {
                var storedProcedure = "dbo.UsersWRolenames_GetAll";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = (int)reader["id"];
                    var userName = reader["username"] as string;
                    var name = reader["Name"] as string;
                    var dateOfBirth = reader.GetDateTime(3);
                    var age = (int)reader["Age"];
                    var role = reader["role"] as string;

                    yield return new User(id, userName, name, role, dateOfBirth, age);
                }
            }
        }

        internal int GetPassword(int id)
        {
            using (connection = new SqlConnection(connectionString))
            {
                var storedProcedure = "dbo.Users_GetPassword";

                var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                var wantedId = new SqlParameter("@id", SqlDbType.Int)
                {
                    Value = id
                };

                command.Parameters.Add(wantedId);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var password = (int)reader["password"];
                    return password;
                }
                return 0;
            }
        }
    }
}
