#pragma checksum "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Writer\_WriterArticles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a6ff4d9b0ad05070c868568d4db51aefd8d0578"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer__WriterArticles), @"mvc.1.0.view", @"/Views/Writer/_WriterArticles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6ff4d9b0ad05070c868568d4db51aefd8d0578", @"/Views/Writer/_WriterArticles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc53067ee0ec1c16c531a1c8dde20d9b3911f10b", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer__WriterArticles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArticleVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Writer\_WriterArticles.cshtml"
 foreach (ArticleVM item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mb-2 row article-card\">\r\n        <div class=\"col-3 d-flex\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 160, "\"", 189, 1);
#nullable restore
#line 8 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Writer\_WriterArticles.cshtml"
WriteAttributeValue("", 166, item.Base64HeaderImage, 166, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-9 content\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 262, "\"", 327, 1);
#nullable restore
#line 11 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Writer\_WriterArticles.cshtml"
WriteAttributeValue("", 269, Url.Action("Article","Article",new { id= item.ArticleId}), 269, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"title\">");
#nullable restore
#line 11 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Writer\_WriterArticles.cshtml"
                                                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <p class=\"trailer\">");
#nullable restore
#line 12 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Writer\_WriterArticles.cshtml"
                           Write(item.Content.Substring(0,20) + "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"date\">");
#nullable restore
#line 13 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Writer\_WriterArticles.cshtml"
                       Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"count\"><i class=\"fas fa-eye\"></i>");
#nullable restore
#line 14 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Writer\_WriterArticles.cshtml"
                                                  Write(item.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 17 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Writer\_WriterArticles.cshtml"
}

#line default
#line hidden
#nullable disable
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
