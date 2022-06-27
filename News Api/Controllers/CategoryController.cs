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
    public class CategoryController : ApiController
    {
        public List<CategoryModel> Get()
        {
            return CategorySurvice.Get();
        }
        [Route("api/category/getall")]
        public List<CategorywithNewsModel> GetAll()
        {
            return CategorySurvice.GetAll();
        }
        [Route("api/category/add")]
        public void Add(CategoryModel nm)
        {
            CategorySurvice.Add(nm);
        }
        [Route("api/category/delete")]
        [HttpPost]
        public void Delete(int id)
        {
            CategorySurvice.Delete(id);
        }
        [Route("api/category/edit")]
        public void Edit(CategoryModel cm)
        {
            CategorySurvice.Edit(cm);
        }
        
    }
}
