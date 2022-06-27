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
    public class NewsSurvice
    {
        public static List<NewsModel> Get()
        {
            var config = new MapperConfiguration(c =>
              {
                  c.CreateMap<News, NewsModel>();
                  c.CreateMap<Category, CategoryModel>();
                  c.CreateMap<Comment, CommentModel>();
              });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(DataAccess.NewsAccess().Get());
            return data;
        }
        public static void Add(NewsModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            DataAccess.NewsAccess().Add(data);
        }
        public static void Delete(int id)
        {
            DataAccess.NewsAccess().Delete(id);
        }
        public static void Edit(NewsModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            DataAccess.NewsAccess().Edit(data);
        }
    }
}
