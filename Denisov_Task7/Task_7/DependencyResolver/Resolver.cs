using BLL;
using BLL.Common;
using DAL.Common;
using DataBaseAccessLayer;

namespace DependencyResolver
{
    public static class Resolver
    {
        public static IAccessable dal { get; private set; }
        public static IProcessable bll { get; private set; }

        static Resolver()
        {
            dal = new DataBaseAccess();
            bll = new RPGProcessor(dal);
        }
    }
}
