#pragma checksum "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92ff08279a4273046995692780891685843e6853"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Published), @"mvc.1.0.view", @"/Views/User/Published.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ff08279a4273046995692780891685843e6853", @"/Views/User/Published.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc53067ee0ec1c16c531a1c8dde20d9b3911f10b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Published : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArticleVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
  
    ViewData["Title"] = "Published";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-3\">\r\n");
#nullable restore
#line 8 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
     foreach (ArticleVM item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"mb-2 row article-card\">\r\n            <div class=\"col-3 d-flex\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 305, "\"", 334, 1);
#nullable restore
#line 12 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
WriteAttributeValue("", 311, item.Base64HeaderImage, 311, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-7 content\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 419, "\"", 484, 1);
#nullable restore
#line 15 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
WriteAttributeValue("", 426, Url.Action("Article","Article",new { id= item.ArticleId}), 426, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"title\">");
#nullable restore
#line 15 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
                                                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <p class=\"trailer\">");
#nullable restore
#line 16 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
                               Write(item.Content.Substring(0,20) + "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"date\">");
#nullable restore
#line 17 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
                           Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"count\"><i class=\"fas fa-eye\"></i>");
#nullable restore
#line 18 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
                                                      Write(item.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-2 d-flex justify-content-center\">\r\n                <div class=\"my-auto\">\r\n                    <button class=\"btn btn-danger mx-2\"");
            BeginWriteAttribute("onclick", " onclick=\"", 908, "\"", 948, 3);
            WriteAttributeValue("", 918, "deleteArticle(", 918, 14, true);
#nullable restore
#line 22 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
WriteAttributeValue("", 932, item.ArticleId, 932, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 947, ")", 947, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Sil</button>\r\n                    <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1010, "\"", 1076, 1);
#nullable restore
#line 23 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
WriteAttributeValue("", 1017, Url.Action("Update","Article",new { id = item.ArticleId }), 1017, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\User\Published.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 

    <script>
        function deleteArticle(id) {
            $.ajax({
                url: ""/Article/DeleteArticle/"" + id,
                Type: ""GET"",
                success: function (res) {
                    window.location.href = res.redirectToUrl;
                },
                error: function (er) {
                    console.log(er)
                }
            });
        }
    </script>

");
            }
            );
            WriteLiteral("\r\n");
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