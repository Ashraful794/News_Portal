using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommentRepo : IRepository<Comment, int>
    {
        News_PortalEntities db;

        public CommentRepo(News_PortalEntities db)
        {
            this.db = db;
        }


        public void Add(Comment s)
        {
            db.Comments.Add(s);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Comments.FirstOrDefault(s => s.id == id);
            db.Comments.Remove(data);
            db.SaveChanges();

        }

        public void Edit(Comment s)
        {
            var data = db.Comments.FirstOrDefault(c => c.id == s.id);
            db.Entry(data).CurrentValues.SetValues(s);
            db.SaveChanges();

        }

        public List<Comment> Get()
        {
            return db.Comments.ToList();
        }
    }
}
