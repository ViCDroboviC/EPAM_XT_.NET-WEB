using DAL.Common;
using DataBaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DependencyResolver
{
    public static class DALResolver
    {
        private static IusersDAL usersDAL;

        public static IusersDAL UsersDAL => usersDAL ?? (usersDAL = new DataBaseAccessHelper());
    }
}
