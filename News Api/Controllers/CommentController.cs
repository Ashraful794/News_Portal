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
    public class CommentController : ApiController
    {
        [Route("api/comment/add")]
        [HttpPost]
        public void Add(CommentModel cm)
        {
            CommentSurvice.Add(cm);
        }
    }
}
