using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace News_Portal.Controllers
{
    public class NewsController : ApiController
    {
        public List<NewsModel> Get()
        {
            return NewsSurvice.Get();
        }
    }
}
