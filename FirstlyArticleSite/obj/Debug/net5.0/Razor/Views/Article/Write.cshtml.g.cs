#pragma checksum "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Article\Write.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af9d82673bad68892d7be37bcd8a9a057bba0597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Write), @"mvc.1.0.view", @"/Views/Article/Write.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9d82673bad68892d7be37bcd8a9a057bba0597", @"/Views/Article/Write.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc53067ee0ec1c16c531a1c8dde20d9b3911f10b", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Write : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleVM>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Article\Write.cshtml"
  
    ViewData["Title"] = "Write";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"row\">\r\n    <div class=\"col-xl-7 mx-auto\">\r\n        <div class=\"mb-3\">\r\n            <img class=\"mb-3 border\" style=\"max-height:100px; max-width:100px;\"");
            BeginWriteAttribute("src", " src=\"", 329, "\"", 335, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""currentHeader"" />
            <label for=""headerImage"" class=""form-label"">Profil Fotoğrafı</label>
            <input class=""form-control"" size=""2"" style=""max-width:700px"" accept=""image/png"" id=""headerImage"" type=""file"" required>
        </div>
        <div class=""mb-3 row"">
            <select class=""form-select"" id=""topicName"" aria-label=""Default select example"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af9d82673bad68892d7be37bcd8a9a057bba05974204", async() => {
                WriteLiteral("Başlık seçmek için tıklayın");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Article\Write.cshtml"
                 foreach (TopicVM item in ViewBag.Topics)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af9d82673bad68892d7be37bcd8a9a057bba05975813", async() => {
#nullable restore
#line 20 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Article\Write.cshtml"
                                             Write(item.TopicName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Article\Write.cshtml"
                       WriteLiteral(item.TopicId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Article\Write.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""mb-3 row"">
            <div class=""col-sm-10"">
                <label for=""articleTitle"" class=""col-sm-2 col-form-label"">Hikaye Başlığı</label>
                <input type=""email"" class=""form-control"" id=""articleTitle"" required>
            </div>
        </div>
        <div class=""mb-3 row"">
            <div class=""col-sm-10"">
                <label for=""articleContent"" class=""col-sm-2 col-form-label"">İçerik alanı</label>
                <textarea class=""form-control"" id=""articleContent""></textarea>
            </div>
        </div>
        <div class=""mb-3 d-grid"">
            <button class=""btn btn-dark btn-lg"" style=""max-width:700px"" id=""btnPublish"">Hikayeyi Yayınla</button>
        </div>
        <div class=""alert alert-warning mb-3"" role=""alert"" id=""successAlert"">
        </div>
    </div>
</section>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        const ppInput = document.getElementById('headerImage');
        ppInput.addEventListener('change', handleFiles, false);

        function handleFiles() {
            if (!this.files.length) {
                console.log(""No files selected!"");
            }
            else {
                const imgArea = document.getElementById('currentHeader');
                imgArea.src = '#';
                imgArea.src = URL.createObjectURL(this.files[0]);
            }
        }

        function getBase64Image() {
            let imgArea = document.getElementById('currentHeader');
            var canvas = document.createElement('canvas');
            canvas.width = imgArea.naturalWidth;
            canvas.height = imgArea.naturalHeight;
            var ctx = canvas.getContext('2d');
            ctx.drawImage(imgArea, 0, 0);
            var dataURL = canvas.toDataURL(""image/png"");
            return dataURL.replace(/^data:image\/(png|jpg);base64,/, """");
        }

   ");
                WriteLiteral("     $(\"#btnPublish\").click(function () {\r\n            var article = {\r\n                writerId: ");
#nullable restore
#line 74 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Article\Write.cshtml"
                     Write(HttpContextAccessor.HttpContext.Session.GetInt32("userId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@",
                topicId: $(""#topicName"").val(),
                title: $(""#articleTitle"").val(),
                content: $(""#articleContent"").val(),
                base64HeaderImage: getBase64Image(),
            };

            publishArticle(article);
        });

        function publishArticle(article) {
            $.ajax({
                url: ""/Article/PublishArticle/"",
                type: ""POST"",
                data: article,
                success: function (res) {
                    window.location = res.redirectToUrl;
                },
                error: function (error) {
                    console.log(error);
                }
            });
        }

    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
