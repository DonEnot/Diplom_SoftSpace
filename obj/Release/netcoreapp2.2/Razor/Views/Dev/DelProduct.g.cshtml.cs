#pragma checksum "E:\diploma_project_here\SoftSpace_web\Views\Dev\DelProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2279f6c684a3728f6631349777e2adc9d476c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dev_DelProduct), @"mvc.1.0.view", @"/Views/Dev/DelProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dev/DelProduct.cshtml", typeof(AspNetCore.Views_Dev_DelProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c2279f6c684a3728f6631349777e2adc9d476c2", @"/Views/Dev/DelProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d30cee2550be9db46aaba39048f361d201242e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Dev_DelProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(1, 44, false);
#line 1 "E:\diploma_project_here\SoftSpace_web\Views\Dev\DelProduct.cshtml"
Write(await Component.InvokeAsync("Menu" , new {}));

#line default
#line hidden
            EndContext();
            BeginContext(45, 34, true);
            WriteLiteral("\r\n<h1>you delete your product ^_^ ");
            EndContext();
            BeginContext(80, 5, false);
#line 2 "E:\diploma_project_here\SoftSpace_web\Views\Dev\DelProduct.cshtml"
                           Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(85, 5, true);
            WriteLiteral("</h1>");
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
