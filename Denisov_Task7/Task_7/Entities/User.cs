using System;
using System.Collections.Generic;

namespace Entities
{
    public class User
    {
        public List<int> awardsIdList;

        public User(int id, string userName, string name, string role, DateTime dateOfBirth, int age)
        {
            this.id = id;
            this.userName = userName;
            this.name = name;
            this.role = role;
            this.dateOfBirth = dateOfBirth;
            this.age = age;
        }

        public int password { get; }

        public int id { get; set; }

        public string userName { get; set; }

        public string name { get; set; }

        public string role { get; set; }

        public DateTime dateOfBirth { get; set; }

        public int age { get; set; }
    }
}
