#pragma checksum "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcff043fd27e1c0edb7397f53263d1f640fd7b20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.LatestArrivals.Pages_Shared_Components_LatestArrivals_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/LatestArrivals/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.LatestArrivals
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcff043fd27e1c0edb7397f53263d1f640fd7b20", @"/Pages/Shared/Components/LatestArrivals/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_LatestArrivals_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampshadeQuery.Contracts.Product.ProductQueryModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""single-row-slider-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title-wrapper text-center section-space--half"">
                    <h2 class=""section-title"">آخرین محصولات</h2>
                    <p class=""section-subtitle"">
                        لورم ایپسوم متن ساختگی با تولید سادگی
                        نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""single-row-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                        ""slidesToShow"": 4,
                        ""slidesToScroll"": 1,
                        ""arrows"": true,
                        ""autoplay"": false,
                        ""autoplaySpeed"": 5000,
                        ""speed"":");
            WriteLiteral(@" 1000,
                        ""infinite"": true,
                        ""rtl"": true,
                        ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                        ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                    }' data-slick-responsive='[
                        {""breakpoint"":1501, ""settings"": {""slidesToShow"": 4} },
                        {""breakpoint"":1199, ""settings"": {""slidesToShow"": 4, ""arrows"": false} },
                        {""breakpoint"":991, ""settings"": {""slidesToShow"": 3, ""arrows"": false} },
                        {""breakpoint"":767, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                        {""breakpoint"":575, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                        {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                    ]'>
");
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                         foreach (var product in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col"">
                                <div class=""single-grid-product"">
                                    <div class=""single-grid-product__image"">
                                        <div class=""single-grid-product__label"">
");
#nullable restore
#line 46 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                             if (product.HasDiscount)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"sale new\">-");
#nullable restore
#line 48 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                   Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 49 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"new\">New</span>\r\n                                        </div>\r\n                                        <a href=\"single-product.html\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 2897, "\"", 2919, 1);
#nullable restore
#line 53 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
WriteAttributeValue("", 2903, product.Picture, 2903, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 2938, "\"", 2963, 1);
#nullable restore
#line 53 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
WriteAttributeValue("", 2944, product.PictureAlt, 2944, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2964, "\"", 2993, 1);
#nullable restore
#line 53 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
WriteAttributeValue("", 2972, product.PictureTitle, 2972, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        </a>
                                    </div>
                                    <div class=""single-grid-product__content"">
                                        <div class=""single-grid-product__category-rating"">
                                            <span class=""category""><a href=""shop-left-sidebar.html"">");
#nullable restore
#line 58 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                                               Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></span>
                                            <span class=""rating"">
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star-outline""></i>
                                            </span>
                                        </div>

                                        <h3 class=""single-grid-product__title"">
                                            <a href=""single-product.html"">");
#nullable restore
#line 69 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                     Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </h3>\r\n                                        <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 72 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                             if (product.HasDiscount)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"discounted-price\">");
#nullable restore
#line 74 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                          Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                                                <span class=\"main-price discounted\">");
#nullable restore
#line 75 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 76 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"main-price\">");
#nullable restore
#line 79 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 80 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 86 "C:\Users\ASUS\source\repos\LampShade_Project\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampshadeQuery.Contracts.Product.ProductQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591