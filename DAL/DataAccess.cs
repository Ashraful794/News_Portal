using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        static News_PortalEntities db;
        static DataAccess()
        {
            db = new News_PortalEntities();
        }
        public static IRepository<News,int> NewsAccess()
        {
            IRepository<News, int> obj = new NewsRepo(db);
            return obj;
        }

        public static IRepository<Category,int> CategoryAccess()
        {
            IRepository<Category, int> obj = new CategoryRepo(db);
            return obj;
        }

        public static IRepository<Comment,int> CommentAccess()
        {
            IRepository<Comment, int> obj = new CommentRepo(db);
            return obj;
        }

    }
}
