using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class User
    {


        public List<int> awardsIdList;

        public User(int id, string userName, string name, string role, DateTime dateOfBirth, int age)
        {
            password = null;
            this.id = id;
            this.userName = userName;
            this.name = name;
            this.role = role;
            this.dateOfBirth = dateOfBirth;
            this.age = age;
        }

        public User(int id, string userName, string name, string role, DateTime dateOfBirth, int age, string password)
        {
            this.password = password;
            this.id = id;
            this.userName = userName;
            this.name = name;
            this.role = role;
            this.dateOfBirth = dateOfBirth;
            this.age = age;
        }

        public string password { get; }

        public int id { get; set; }

        public string userName { get; set; }

        public string name { get; set; }

        public string role { get; set; }

        public DateTime dateOfBirth { get; set; }

        public int age { get; set; }

        public void AddAward(int awardId)
        {
            awardsIdList.Append(awardId);
        }

        public void AddAward(List<int> awardsToAdd)
        {
            foreach(int award in awardsToAdd)
            {
                awardsIdList.Append(award);
            }
        }
    }
}
