#pragma checksum "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec3402b25a3bbbab9ae51e2719ccf5e0bef76348"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Saved), @"mvc.1.0.view", @"/Views/User/Saved.cshtml")]
namespace AspNetCore
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
#line 1 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\_ViewImports.cshtml"
using FirstlyArticleSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3402b25a3bbbab9ae51e2719ccf5e0bef76348", @"/Views/User/Saved.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc53067ee0ec1c16c531a1c8dde20d9b3911f10b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Saved : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArticleVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
  
    ViewData["Title"] = "Saved";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-3\">\r\n");
#nullable restore
#line 8 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
     foreach (ArticleVM item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"mb-2 row article-card\">\r\n            <div class=\"col-3 d-flex\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 301, "\"", 330, 1);
#nullable restore
#line 12 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
WriteAttributeValue("", 307, item.Base64HeaderImage, 307, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-7 content\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 415, "\"", 480, 1);
#nullable restore
#line 15 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
WriteAttributeValue("", 422, Url.Action("Article","Article",new { id= item.ArticleId}), 422, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"title\">");
#nullable restore
#line 15 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
                                                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <p class=\"trailer\">");
#nullable restore
#line 16 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
                               Write(item.Content.Substring(0,20) + "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"date\">");
#nullable restore
#line 17 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
                           Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"count\"><i class=\"fas fa-eye\"></i>");
#nullable restore
#line 18 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
                                                      Write(item.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-2 d-flex justify-content-center\">\r\n                <div class=\"my-auto\">\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 894, "\"", 964, 1);
#nullable restore
#line 22 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
WriteAttributeValue("", 901, Url.Action("UnsaveArticle","User",new { id = item.ArticleId }), 901, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Kaldır</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Saved.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArticleVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591