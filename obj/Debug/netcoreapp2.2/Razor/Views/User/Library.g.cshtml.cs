#pragma checksum "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab6d367b8066ff306e57e9f00f4e4952a13e07d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Library), @"mvc.1.0.view", @"/Views/User/Library.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Library.cshtml", typeof(AspNetCore.Views_User_Library))]
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
#line 1 "E:\diploma_project_here\SoftSpace_web\Views\_ViewImports.cshtml"
using SoftSpace_web;

#line default
#line hidden
#line 2 "E:\diploma_project_here\SoftSpace_web\Views\_ViewImports.cshtml"
using SoftSpace_web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab6d367b8066ff306e57e9f00f4e4952a13e07d3", @"/Views/User/Library.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d30cee2550be9db46aaba39048f361d201242e2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Library : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px; width : 100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(1, 44, false);
#line 1 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
Write(await Component.InvokeAsync("Menu" , new {}));

#line default
#line hidden
            EndContext();
            BeginContext(45, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(52, 27, false);
#line 2 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
Write(ViewBag.Translate_words[58]);

#line default
#line hidden
            EndContext();
            BeginContext(79, 141, true);
            WriteLiteral("</h1>\r\n\r\n\r\n\r\n\r\n<table class=\"table\">\r\n  <thead class=\"thead-light\">\r\n    <tr>\r\n      <th scope=\"col\">Изображение</th>\r\n      <th scope=\"col\">");
            EndContext();
            BeginContext(221, 27, false);
#line 11 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
                 Write(ViewBag.Translate_words[22]);

#line default
#line hidden
            EndContext();
            BeginContext(248, 29, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\">");
            EndContext();
            BeginContext(278, 27, false);
#line 12 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
                 Write(ViewBag.Translate_words[23]);

#line default
#line hidden
            EndContext();
            BeginContext(305, 29, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\">");
            EndContext();
            BeginContext(335, 27, false);
#line 13 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
                 Write(ViewBag.Translate_words[65]);

#line default
#line hidden
            EndContext();
            BeginContext(362, 29, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\">");
            EndContext();
            BeginContext(392, 27, false);
#line 14 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
                 Write(ViewBag.Translate_words[66]);

#line default
#line hidden
            EndContext();
            BeginContext(419, 41, true);
            WriteLiteral("</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
            EndContext();
#line 18 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
 foreach( var a in @ViewBag.Lib) 
{

#line default
#line hidden
            BeginContext(498, 20, true);
            WriteLiteral("    <tr>\r\n      <td>");
            EndContext();
            BeginContext(518, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ab6d367b8066ff306e57e9f00f4e4952a13e07d36677", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 528, "~/Pictures/", 528, 11, true);
#line 21 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
AddHtmlAttributeValue("", 539, a[5], 539, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(615, 29, true);
            WriteLiteral("</td>\r\n      <th scope=\"row\">");
            EndContext();
            BeginContext(645, 4, false);
#line 22 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
                 Write(a[1]);

#line default
#line hidden
            EndContext();
            BeginContext(649, 17, true);
            WriteLiteral("</th>\r\n      <td>");
            EndContext();
            BeginContext(667, 4, false);
#line 23 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
     Write(a[2]);

#line default
#line hidden
            EndContext();
            BeginContext(671, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(689, 4, false);
#line 24 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
     Write(a[3]);

#line default
#line hidden
            EndContext();
            BeginContext(693, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(711, 4, false);
#line 25 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
     Write(a[4]);

#line default
#line hidden
            EndContext();
            BeginContext(715, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 27 "E:\diploma_project_here\SoftSpace_web\Views\User\Library.cshtml"
   
}

#line default
#line hidden
            BeginContext(741, 10, true);
            WriteLiteral("\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
