using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CategorywithNewsModel:CategoryModel
    {
        public virtual ICollection<NewsModel> News { get; set; }

    }
}
