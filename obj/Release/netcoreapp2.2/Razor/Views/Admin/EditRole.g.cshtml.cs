#pragma checksum "E:\diploma_project_here\SoftSpace_web\Views\Admin\EditRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c69148af8f36b64bfe751c5fe5d245af3a6ace4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditRole), @"mvc.1.0.view", @"/Views/Admin/EditRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/EditRole.cshtml", typeof(AspNetCore.Views_Admin_EditRole))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69148af8f36b64bfe751c5fe5d245af3a6ace4e", @"/Views/Admin/EditRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d30cee2550be9db46aaba39048f361d201242e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRole_Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form_line"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(1, 44, false);
#line 1 "E:\diploma_project_here\SoftSpace_web\Views\Admin\EditRole.cshtml"
Write(await Component.InvokeAsync("Menu" , new {}));

#line default
#line hidden
            EndContext();
            BeginContext(45, 49, true);
            WriteLiteral("\r\n<h1>Edit Your Product  check on bellow</h1>\r\n\r\n");
            EndContext();
#line 4 "E:\diploma_project_here\SoftSpace_web\Views\Admin\EditRole.cshtml"
 if(@ViewBag.Ex == 1)
{

#line default
#line hidden
            BeginContext(120, 41, true);
            WriteLiteral("    <h1>Данная роль уже существует</h1>\r\n");
            EndContext();
#line 7 "E:\diploma_project_here\SoftSpace_web\Views\Admin\EditRole.cshtml"
}

#line default
#line hidden
            BeginContext(164, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(166, 851, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c69148af8f36b64bfe751c5fe5d245af3a6ace4e5333", async() => {
                BeginContext(255, 127, true);
                WriteLiteral("\r\n    <div class=\"card\" style=\"width: 18rem;\">\r\n  \r\n    \r\n    <div class=\"card-body\">\r\n\r\n    <input hidden name=\"id_role_users\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 382, "\"", 409, 1);
#line 15 "E:\diploma_project_here\SoftSpace_web\Views\Admin\EditRole.cshtml"
WriteAttributeValue("", 390, ViewBag.Role[0][0], 390, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(410, 128, true);
                WriteLiteral(">\r\n    \r\n    <div class=\"input-group mb-2\">\r\n        <div class=\"input-group-prepend\">\r\n          <div class=\"input-group-text\">");
                EndContext();
                BeginContext(539, 107, true);
                WriteLiteral("@</div>\r\n        </div>\r\n        <input type=\"text\" class=\"form-control\" name=\"name\" placeholder=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 646, "\"", 673, 1);
#line 21 "E:\diploma_project_here\SoftSpace_web\Views\Admin\EditRole.cshtml"
WriteAttributeValue("", 654, ViewBag.Role[0][1], 654, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(674, 166, true);
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"description\">Description</label>\r\n        <textarea class=\"form-control\" name=\"description\" rows=\"3\">");
                EndContext();
                BeginContext(841, 18, false);
#line 25 "E:\diploma_project_here\SoftSpace_web\Views\Admin\EditRole.cshtml"
                                                              Write(ViewBag.Role[0][2]);

#line default
#line hidden
                EndContext();
                BeginContext(859, 151, true);
                WriteLiteral("</textarea>\r\n    </div>\r\n    \r\n    \r\n     \r\n    \r\n   \r\n    <button type=\"submit\"  class=\"btn btn-primary\">Save</button>\r\n      </div>\r\n  \r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1017, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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