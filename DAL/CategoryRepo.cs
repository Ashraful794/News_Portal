using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo : IRepository<Category, int>
    {
        News_PortalEntities db;
        public CategoryRepo(News_PortalEntities db)
        {
            this.db = db;
        }
        public void Add(Category s)
        {
            db.Categories.Add(s);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Categories.FirstOrDefault(st => st.id == id);
            db.Categories.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Category s)
        {
            var data = db.Categories.FirstOrDefault(st => st.id == s.id);
            db.Entry(data).CurrentValues.SetValues(s);
            db.SaveChanges();
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }
    }
}
