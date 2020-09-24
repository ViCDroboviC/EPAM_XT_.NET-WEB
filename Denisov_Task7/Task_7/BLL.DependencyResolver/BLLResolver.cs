using BLL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DependencyResolver
{
    public static class BLLResolver
    {
        private static IBLL usersDAL;

        public static IBLL UsersDAL => usersDAL ?? (usersDAL = new RPGLogicLayer());
    }
}
