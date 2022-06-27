using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommentSurvice
    {
        public  static void Add(CommentModel cm)
        {
            var config = new MapperConfiguration(c => c.CreateMap<CommentModel, Comment>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Comment>(cm);
            DataAccess.CommentAccess().Add(data);
        }
    }
}
