#pragma checksum "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd1d45b97cb13ccf5a295ec04eadc485672b2c6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DevModeration), @"mvc.1.0.view", @"/Views/Admin/DevModeration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DevModeration.cshtml", typeof(AspNetCore.Views_Admin_DevModeration))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1d45b97cb13ccf5a295ec04eadc485672b2c6a", @"/Views/Admin/DevModeration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d30cee2550be9db46aaba39048f361d201242e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DevModeration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DelDev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form_line"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DevModeration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-numb_page", "this_page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
  
  int previous  = 0;
  int next = 1;
  int this_page = 0;
    
    if(@ViewBag.Devs.currect_number < 0)
      {
        this_page = 0;
      }
    else
      {
        this_page = @ViewBag.Devs.currect_number;
      }
      
    if(this_page > 0) 
      {
        previous = this_page - 1;
      }
    else
      {
        this_page = 0;
      }
    
    next = this_page  +1 ;

#line default
#line hidden
            BeginContext(409, 44, false);
#line 26 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
Write(await Component.InvokeAsync("Menu" , new {}));

#line default
#line hidden
            EndContext();
            BeginContext(453, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(460, 27, false);
#line 27 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
Write(ViewBag.Translate_words[10]);

#line default
#line hidden
            EndContext();
            BeginContext(487, 97, true);
            WriteLiteral("</h1>\r\n\r\n<table class=\"table\">\r\n  <thead class=\"thead-light\">\r\n    <tr>\r\n      <th scope=\"col\">  ");
            EndContext();
            BeginContext(585, 27, false);
#line 32 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                   Write(ViewBag.Translate_words[65]);

#line default
#line hidden
            EndContext();
            BeginContext(612, 31, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\">  ");
            EndContext();
            BeginContext(644, 27, false);
#line 33 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                   Write(ViewBag.Translate_words[23]);

#line default
#line hidden
            EndContext();
            BeginContext(671, 31, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\">  ");
            EndContext();
            BeginContext(703, 27, false);
#line 34 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                   Write(ViewBag.Translate_words[30]);

#line default
#line hidden
            EndContext();
            BeginContext(730, 31, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\">  ");
            EndContext();
            BeginContext(762, 27, false);
#line 35 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                   Write(ViewBag.Translate_words[74]);

#line default
#line hidden
            EndContext();
            BeginContext(789, 31, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\">  ");
            EndContext();
            BeginContext(821, 27, false);
#line 36 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                   Write(ViewBag.Translate_words[75]);

#line default
#line hidden
            EndContext();
            BeginContext(848, 70, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\"></th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
            EndContext();
#line 41 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
 foreach( var a in @ViewBag.Devs.list) 
{

#line default
#line hidden
            BeginContext(962, 32, true);
            WriteLiteral("    <tr>\r\n      <th scope=\"row\">");
            EndContext();
            BeginContext(995, 4, false);
#line 44 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                 Write(a[1]);

#line default
#line hidden
            EndContext();
            BeginContext(999, 17, true);
            WriteLiteral("</th>\r\n      <td>");
            EndContext();
            BeginContext(1017, 4, false);
#line 45 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
     Write(a[2]);

#line default
#line hidden
            EndContext();
            BeginContext(1021, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(1039, 4, false);
#line 46 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
     Write(a[3]);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(1061, 4, false);
#line 47 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
     Write(a[4]);

#line default
#line hidden
            EndContext();
            BeginContext(1065, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(1083, 4, false);
#line 48 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
     Write(a[5]);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 30, true);
            WriteLiteral("</td>\r\n      <td>\r\n           ");
            EndContext();
            BeginContext(1117, 281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1d45b97cb13ccf5a295ec04eadc485672b2c6a11444", async() => {
                BeginContext(1199, 56, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id_dev\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1255, "\"", 1268, 1);
#line 51 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
WriteAttributeValue("", 1263, a[0], 1263, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1269, 71, true);
                WriteLiteral("/>\r\n                    <button type=\"submit\"  class=\"btn btn-primary\">");
                EndContext();
                BeginContext(1341, 27, false);
#line 52 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                              Write(ViewBag.Translate_words[27]);

#line default
#line hidden
                EndContext();
                BeginContext(1368, 23, true);
                WriteLiteral("</button>\r\n            ");
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
            BeginContext(1398, 26, true);
            WriteLiteral("\r\n      </td>\r\n    </tr>\r\n");
            EndContext();
#line 56 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
}

#line default
#line hidden
            BeginContext(1427, 20, true);
            WriteLiteral("\r\n</table>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 63 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
 if(@ViewBag.Devs.count_pages > 1 )
{

#line default
#line hidden
            BeginContext(1487, 51, true);
            WriteLiteral("<nav aria-label=\"...\">\r\n  <ul class=\"pagination\">\r\n");
            EndContext();
#line 67 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
     if(this_page > 0)
    {

#line default
#line hidden
            BeginContext(1569, 34, true);
            WriteLiteral("    <li class=\"page-item\">\r\n      ");
            EndContext();
            BeginContext(1603, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1d45b97cb13ccf5a295ec04eadc485672b2c6a15424", async() => {
                BeginContext(1732, 104, true);
                WriteLiteral("\r\n        <span aria-hidden=\"true\">&laquo;</span>\r\n        <span class=\"sr-only\">Previous</span>\r\n      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numb_page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                                                         WriteLiteral(previous);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numb_page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1840, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
#line 75 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
    }

#line default
#line hidden
            BeginContext(1860, 18, true);
            WriteLiteral("\r\n    \r\n    \r\n\r\n\r\n");
            EndContext();
#line 81 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
     if(this_page < 12)
    {
      

#line default
#line hidden
#line 83 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
       for(int i = 0;i < 19; i++ )
      {
        int nn_page = i;
         

#line default
#line hidden
#line 86 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
          if(nn_page == this_page)
        {

#line default
#line hidden
            BeginContext(2028, 53, true);
            WriteLiteral("          <li class=\"page-item active\">\r\n            ");
            EndContext();
            BeginContext(2081, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1d45b97cb13ccf5a295ec04eadc485672b2c6a19239", async() => {
                BeginContext(2190, 13, false);
#line 89 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                                                                                   Write(this_page + 1);

#line default
#line hidden
                EndContext();
                BeginContext(2204, 39, true);
                WriteLiteral(" <span class=\"sr-only\">(current)</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numb_page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                                                               WriteLiteral(this_page);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numb_page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2247, 19, true);
            WriteLiteral("\r\n          </li>\r\n");
            EndContext();
#line 91 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"

        }
        else{
          if((i < @ViewBag.Devs.count_pages)&&(i >= 0))
          {

#line default
#line hidden
            BeginContext(2364, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2376, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1d45b97cb13ccf5a295ec04eadc485672b2c6a22647", async() => {
                BeginContext(2484, 11, false);
#line 96 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                                                                                  Write(nn_page + 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numb_page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                                                               WriteLiteral(nn_page);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numb_page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2500, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 97 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
          }
        }

#line default
#line hidden
#line 98 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
         
      }

#line default
#line hidden
#line 99 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
       
      
    }
    else
    {
      

#line default
#line hidden
#line 104 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
       for( int i =  Convert.ToInt32(this_page) - 9 ;
        i < Convert.ToInt32(this_page) + 10; i++)
      {
        
        int nn_page = i;
        
        

#line default
#line hidden
#line 110 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
         if(nn_page == this_page)
        {

#line default
#line hidden
            BeginContext(2774, 53, true);
            WriteLiteral("          <li class=\"page-item active\">\r\n            ");
            EndContext();
            BeginContext(2827, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1d45b97cb13ccf5a295ec04eadc485672b2c6a26591", async() => {
                BeginContext(2935, 13, false);
#line 113 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                                                                                  Write(this_page + 1);

#line default
#line hidden
                EndContext();
                BeginContext(2949, 39, true);
                WriteLiteral(" <span class=\"sr-only\">(current)</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numb_page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"] = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2992, 19, true);
            WriteLiteral("\r\n          </li>\r\n");
            EndContext();
#line 115 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"

        }
        else{
          if((i < @ViewBag.Devs.count_pages)&&(i >= 0))
          {

#line default
#line hidden
            BeginContext(3109, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3121, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1d45b97cb13ccf5a295ec04eadc485672b2c6a29491", async() => {
                BeginContext(3229, 11, false);
#line 120 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                                                                                  Write(nn_page + 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numb_page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                                                               WriteLiteral(nn_page);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numb_page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 121 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
          }
        }

#line default
#line hidden
#line 122 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
         
      }

#line default
#line hidden
#line 123 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
       


    }

#line default
#line hidden
            BeginContext(3291, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 128 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
     if(next < @ViewBag.Devs.count_pages)
    {

#line default
#line hidden
            BeginContext(3343, 34, true);
            WriteLiteral("    <li class=\"page-item\">\r\n      ");
            EndContext();
            BeginContext(3377, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1d45b97cb13ccf5a295ec04eadc485672b2c6a33214", async() => {
                BeginContext(3497, 100, true);
                WriteLiteral("\r\n        <span aria-hidden=\"true\">&raquo;</span>\r\n        <span class=\"sr-only\">Next</span>\r\n      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numb_page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 131 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
                                                                                         WriteLiteral(next);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numb_page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numb_page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3601, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
#line 136 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
    }

#line default
#line hidden
            BeginContext(3621, 19, true);
            WriteLiteral("\r\n  </ul>\r\n</nav>\r\n");
            EndContext();
#line 140 "E:\diploma_project_here\SoftSpace_web\Views\Admin\DevModeration.cshtml"
}

#line default
#line hidden
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