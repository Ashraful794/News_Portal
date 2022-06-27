using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace BLL
{
    public class CategorySurvice
    {
        public static List<CategoryModel> Get()
        {
            var config = new MapperConfiguration(c =>
              {
                  c.CreateMap<Category, CategoryModel>();
              });
            var mapper = new Mapper(config);
            return mapper.Map<List<CategoryModel>>(DataAccess.CategoryAccess().Get());

        }
        public static List<CategorywithNewsModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategorywithNewsModel>();
                c.CreateMap<News, NewsModel>();
                c.CreateMap<Comment, CommentModel>();
                c.CreateMap<Category, CategoryModel>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CategorywithNewsModel>>(DataAccess.CategoryAccess().Get());

        }
        public static void Add(CategoryModel cat)
        {
            var config = new MapperConfiguration(c => c.CreateMap<CategoryModel, Category>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(cat);
            DataAccess.CategoryAccess().Add(data);
        }
        public static void Delete(int id)
        {
            DataAccess.CategoryAccess().Delete(id);
        }
        public static void Edit(CategoryModel cat)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(cat);
            DataAccess.CategoryAccess().Edit(data);
        }
    }

}
