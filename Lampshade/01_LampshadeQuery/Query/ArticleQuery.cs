using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Article;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_LampshadeQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;

        public ArticleQuery(BlogContext context)
        {
            _context = context;
        }


        public ArticleQueryModel GetDetails(string slug)
        {
            var article = _context.Articles
                .Where(x => x.PublishDate <= DateTime.Now)
                .Include(x => x.Category)
                .Select(x => new ArticleQueryModel
                {
                    CategoryName = x.Category.Name,
                    CanonicalAddress = x.CanonicalAddress,
                    CategorySlug = x.Category.Slug,
                    Description = x.Description,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),
                    ShortDescription = x.ShortDescription,
                    Slug = x.Slug,
                    Title = x.Title
                }).FirstOrDefault(x => x.Slug == slug);

            article.KeywordList = article.Keywords.Split(",").ToList();

            return article;
        }

        public List<ArticleQueryModel> LatestArticles()
        {
            return _context.Articles
                .Where(x=> x.PublishDate <= DateTime.Now)
                .Include(x => x.Category)
                .Select(x => new ArticleQueryModel
                {
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),
                    ShortDescription = x.ShortDescription,
                    Slug =x.Slug,
                    Title = x.Title
                }).Take(6).ToList();
        }
    }
}
