#pragma checksum "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Topics\AllTopics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "587cbce3ce05362d9c4fad24291fadb0fdab58c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topics_AllTopics), @"mvc.1.0.view", @"/Views/Topics/AllTopics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"587cbce3ce05362d9c4fad24291fadb0fdab58c2", @"/Views/Topics/AllTopics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc53067ee0ec1c16c531a1c8dde20d9b3911f10b", @"/Views/_ViewImports.cshtml")]
    public class Views_Topics_AllTopics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TopicVM>>
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
#line 2 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Topics\AllTopics.cshtml"
  
    ViewData["Title"] = "AllTopics";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"container my-3\">\r\n    <div class=\"row\">\r\n        <div class=\"my-3\">\r\n            <select class=\"form-select\" id=\"allTopics\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "587cbce3ce05362d9c4fad24291fadb0fdab58c23666", async() => {
                WriteLiteral("Bir Konu Başlığı Seçin");
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
#line 12 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Topics\AllTopics.cshtml"
                 foreach (TopicVM item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "587cbce3ce05362d9c4fad24291fadb0fdab58c25264", async() => {
#nullable restore
#line 14 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Topics\AllTopics.cshtml"
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
#line 14 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Topics\AllTopics.cshtml"
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
#line 15 "D:\Ders\BilgeAdam\Gizem Hoca\Ödevler\FistlyBlogMVC\FirstlyBlog\FirstlyArticleSite\Views\Topics\AllTopics.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n\r\n        <div class=\"px-4\" id=\"articlesOfSelectedTopic\">\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@" 

    <script>
        const selectBox = document.getElementById('allTopics');
        selectBox.addEventListener(""change"", function (ev) {
            $.ajax({
                url: ""/Topics/ArticlesOfTopic/"" + $(""#allTopics"").val(),
                type: ""GET"",
                success: function (res) {
                    $('#articlesOfSelectedTopic').html(res);
                },
                error: function (er) {
                    console.log(er);
                }

            })
        });

    </script>


");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TopicVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
