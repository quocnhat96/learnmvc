using AutoMapper;
using LearnMVC.Model.Models;
using LearnMVC.WebView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMVC.WebView.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}