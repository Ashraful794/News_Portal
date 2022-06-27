using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace News_Api.Controllers
{
    public class NewsController : ApiController
    {
        public List<NewsModel> Get()
        {
            return NewsSurvice.Get();
        }
        [Route("api/news/{id}")]
        public NewsModel Get(int id)
        {
            return NewsSurvice.Get().Where(st=>st.id==id).FirstOrDefault();
        }

        [Route("api/news/add")]
        public void Add(NewsModel nm)
        {
            NewsSurvice.Add(nm);
        }
        [Route("api/news/delete")]
        [HttpPost]
        public void Delete(int id)
        {
            NewsSurvice.Delete(id);
        }
        [Route("api/news/edit")]
        public void Edit(NewsModel cm)
        {
            NewsSurvice.Edit(cm);
        }

        public List<NewsModel> Get(DateTime date)
        {
            return NewsSurvice.Get().Where(st => st.Date == date).ToList();
        }
        public List<NewsModel> Get(DateTime date,int id)
        {
            return NewsSurvice.Get().Where(st => st.Date == date && st.Category_id==id).ToList();
        }

    }
}
