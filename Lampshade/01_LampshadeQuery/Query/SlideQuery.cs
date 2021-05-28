using System;
using System.Collections.Generic;
using System.Linq;
using _01_LampshadeQuery.Contracts.Slide;
using ShopManagement.Infrastructure.EFCore;

namespace _01_LampshadeQuery.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly ShopContext _context;

        public SlideQuery(ShopContext context)
        {
            _context = context;
        }

        public List<SlideQueryModel> GetSlides()
        {
            return _context.Slides.Where(x => !x.IsRemoved)
                .Select(x => new SlideQueryModel
                {
                    Picture = x.Picture,
                    PictureTitle = x.PictureTitle,
                    PictureAlt = x.PictureAlt,
                    BtnText = x.BtnText,
                    Heading = x.Heading,
                    Link = x.Link,
                    Text = x.Text,
                    Title = x.Title
                }).ToList();
        }
    }
}
