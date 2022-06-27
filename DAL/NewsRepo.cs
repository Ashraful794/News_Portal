using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsRepo : IRepository<News, int>
    {
        News_PortalEntities db;
        public NewsRepo(News_PortalEntities db)
        {
            this.db = db;
        }
        public void Add(News s)
        {
            db.News.Add(s);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            News data=db.News.FirstOrDefault(s => s.id == id);
            db.News.Remove(data);
            db.SaveChanges();
        }

        public void Edit(News s)
        {
            News data = db.News.FirstOrDefault(d => d.id == s.id);
            db.Entry(data).CurrentValues.SetValues(s);
            db.SaveChanges();
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }
    }
}
