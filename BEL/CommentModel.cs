using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CommentModel
    {
        public int id { get; set; }
        public string description { get; set; }
        public Nullable<int> news_id { get; set; }
    }
}
