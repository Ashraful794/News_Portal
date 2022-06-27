using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NewsModel
    {
        public int id { get; set; }
        public int Category_id { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public virtual CategoryModel Category { get; set; }
        public virtual ICollection<CommentModel> Comments { get; set; }
    }
}
