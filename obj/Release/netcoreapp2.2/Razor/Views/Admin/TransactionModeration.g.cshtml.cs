#pragma checksum "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92cb8e1ee0313a6702e3bd8f22494627bf8e1459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TransactionModeration), @"mvc.1.0.view", @"/Views/Admin/TransactionModeration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/TransactionModeration.cshtml", typeof(AspNetCore.Views_Admin_TransactionModeration))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92cb8e1ee0313a6702e3bd8f22494627bf8e1459", @"/Views/Admin/TransactionModeration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d30cee2550be9db46aaba39048f361d201242e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_TransactionModeration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTransaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form_line"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TransactionModeration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
  
  int previous  = 0;
  int next = 1;
  int this_page = 0;
    
    if(@ViewBag.Data_deal.currect_number < 0)
      {
        this_page = 0;
      }
    else
      {
        this_page = @ViewBag.Data_deal.currect_number;
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
            BeginContext(418, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(421, 44, false);
#line 27 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
Write(await Component.InvokeAsync("Menu" , new {}));

#line default
#line hidden
            EndContext();
            BeginContext(465, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(472, 27, false);
#line 28 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
Write(ViewBag.Translate_words[14]);

#line default
#line hidden
            EndContext();
            BeginContext(499, 105, true);
            WriteLiteral(" </h1>\r\n\r\n<table class=\"table\">\r\n  <thead class=\"thead-light\">\r\n    <tr>\r\n      \r\n      <th scope=\"col\"> ");
            EndContext();
            BeginContext(605, 27, false);
#line 34 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
                  Write(ViewBag.Translate_words[78]);

#line default
#line hidden
            EndContext();
            BeginContext(632, 30, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\"> ");
            EndContext();
            BeginContext(663, 27, false);
#line 35 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
                  Write(ViewBag.Translate_words[66]);

#line default
#line hidden
            EndContext();
            BeginContext(690, 30, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\"> ");
            EndContext();
            BeginContext(721, 27, false);
#line 36 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
                  Write(ViewBag.Translate_words[35]);

#line default
#line hidden
            EndContext();
            BeginContext(748, 70, true);
            WriteLiteral("</th>\r\n      <th scope=\"col\"></th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
            EndContext();
#line 41 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
 foreach( var a in @ViewBag.Data_deal.list) 
{
  string id_this = "a"+@a[0];
  

#line default
#line hidden
            BeginContext(900, 23, true);
            WriteLiteral("<div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 923, "\"", 936, 1);
#line 44 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
WriteAttributeValue("", 928, id_this, 928, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(937, 296, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h5 class=""modal-title"" id=""exampleModalLabel"">Вы точно хотите удалить сделку у  ");
            EndContext();
            BeginContext(1234, 4, false);
#line 48 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
                                                                                      Write(a[1]);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 85, true);
            WriteLiteral(" ?</h5>\r\n\r\n        </div>\r\n        \r\n        <div class=\"modal-footer\">\r\n\r\n          ");
            EndContext();
            BeginContext(1323, 352, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cb8e1ee0313a6702e3bd8f22494627bf8e145910523", async() => {
                BeginContext(1416, 63, true);
                WriteLiteral("\r\n                  <input type=\"hidden\"  name=\"id_transaction\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1479, "\"", 1492, 1);
#line 55 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
WriteAttributeValue("", 1487, a[0], 1487, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1493, 59, true);
                WriteLiteral("/>\r\n                  <input type=\"hidden\" name=\"numb_page\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1552, "\"", 1570, 1);
#line 56 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
WriteAttributeValue("", 1560, this_page, 1560, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1571, 97, true);
                WriteLiteral("/>\r\n                  <button type=\"submit\"  class=\"btn btn-primary\">Confirm</button>\r\n          ");
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
            BeginContext(1675, 165, true);
            WriteLiteral("    \r\n         \r\n          <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n");
            EndContext();
            BeginContext(1848, 32, true);
            WriteLiteral("    <tr>\r\n      <th scope=\"row\">");
            EndContext();
            BeginContext(1881, 4, false);
#line 69 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
                 Write(a[1]);

#line default
#line hidden
            EndContext();
            BeginContext(1885, 17, true);
            WriteLiteral("</th>\r\n      <td>");
            EndContext();
            BeginContext(1903, 4, false);
#line 70 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
     Write(a[2]);

#line default
#line hidden
            EndContext();
            BeginContext(1907, 17, true);
            WriteLiteral("</td>\r\n      <td>");
            EndContext();
            BeginContext(1925, 4, false);
#line 71 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
     Write(a[3]);

#line default
#line hidden
            EndContext();
            BeginContext(1929, 112, true);
            WriteLiteral("</td>\r\n\r\n      <td>\r\n           <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#");
            EndContext();
            BeginContext(2042, 7, false);
#line 74 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
                                                                                      Write(id_this);

#line default
#line hidden
            EndContext();
            BeginContext(2049, 3, true);
            WriteLiteral("\" >");
            EndContext();
            BeginContext(2053, 27, false);
#line 74 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
                                                                                                 Write(ViewBag.Translate_words[27]);

#line default
#line hidden
            EndContext();
            BeginContext(2080, 35, true);
            WriteLiteral("</button>\r\n      </td>\r\n    </tr>\r\n");
            EndContext();
#line 77 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
   
}

#line default
#line hidden
            BeginContext(2123, 18, true);
            WriteLiteral("\r\n</table>\r\n\r\n\r\n\r\n");
            EndContext();
#line 84 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
 if(@ViewBag.Data_deal.count_pages > 1 )
{

#line default
#line hidden
            BeginContext(2186, 51, true);
            WriteLiteral("<nav aria-label=\"...\">\r\n  <ul class=\"pagination\">\r\n");
            EndContext();
#line 88 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
     if(this_page > 0)
    {

#line default
#line hidden
            BeginContext(2268, 34, true);
            WriteLiteral("    <li class=\"page-item\">\r\n      ");
            EndContext();
            BeginContext(2302, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cb8e1ee0313a6702e3bd8f22494627bf8e145916896", async() => {
                BeginContext(2439, 104, true);
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
#line 91 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
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
            BeginContext(2547, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
#line 96 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
    }

#line default
#line hidden
            BeginContext(2567, 18, true);
            WriteLiteral("\r\n    \r\n    \r\n\r\n\r\n");
            EndContext();
#line 102 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
     if(this_page < 12)
    {
      

#line default
#line hidden
#line 104 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
       for(int i = 0;i < 19; i++ )
      {
        int nn_page = i;
         

#line default
#line hidden
#line 107 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
          if(nn_page == this_page)
        {

#line default
#line hidden
            BeginContext(2735, 53, true);
            WriteLiteral("          <li class=\"page-item active\">\r\n            ");
            EndContext();
            BeginContext(2788, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cb8e1ee0313a6702e3bd8f22494627bf8e145920762", async() => {
                BeginContext(2905, 13, false);
#line 110 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
                                                                                                                           Write(this_page + 1);

#line default
#line hidden
                EndContext();
                BeginContext(2919, 39, true);
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
#line 110 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
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
            BeginContext(2962, 19, true);
            WriteLiteral("\r\n          </li>\r\n");
            EndContext();
#line 112 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"

        }
        else{
          if((i < @ViewBag.Data_deal.count_pages)&&(i >= 0))
          {

#line default
#line hidden
            BeginContext(3084, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3096, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cb8e1ee0313a6702e3bd8f22494627bf8e145924218", async() => {
                BeginContext(3212, 11, false);
#line 117 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
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
#line 117 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
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
            BeginContext(3228, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 118 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
          }
        }

#line default
#line hidden
#line 119 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
         
      }

#line default
#line hidden
#line 120 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
       
      
    }
    else
    {
      

#line default
#line hidden
#line 125 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
       for( int i =  Convert.ToInt32(this_page) - 9 ;
        i < Convert.ToInt32(this_page) + 10; i++)
      {
        
        int nn_page = i;
        
        

#line default
#line hidden
#line 131 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
         if(nn_page == this_page)
        {

#line default
#line hidden
            BeginContext(3502, 53, true);
            WriteLiteral("          <li class=\"page-item active\">\r\n            ");
            EndContext();
            BeginContext(3555, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cb8e1ee0313a6702e3bd8f22494627bf8e145928239", async() => {
                BeginContext(3671, 13, false);
#line 134 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
                                                                                                                          Write(this_page + 1);

#line default
#line hidden
                EndContext();
                BeginContext(3685, 39, true);
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
            BeginContext(3728, 19, true);
            WriteLiteral("\r\n          </li>\r\n");
            EndContext();
#line 136 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"

        }
        else{
          if((i < @ViewBag.Data_deal.count_pages)&&(i >= 0))
          {

#line default
#line hidden
            BeginContext(3850, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3862, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cb8e1ee0313a6702e3bd8f22494627bf8e145931168", async() => {
                BeginContext(3978, 11, false);
#line 141 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
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
#line 141 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
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
            BeginContext(3994, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 142 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
          }
        }

#line default
#line hidden
#line 143 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
         
      }

#line default
#line hidden
#line 144 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
       


    }

#line default
#line hidden
            BeginContext(4040, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 149 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
     if(next < @ViewBag.Data_deal.count_pages)
    {

#line default
#line hidden
            BeginContext(4097, 34, true);
            WriteLiteral("    <li class=\"page-item\">\r\n      ");
            EndContext();
            BeginContext(4131, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cb8e1ee0313a6702e3bd8f22494627bf8e145934960", async() => {
                BeginContext(4259, 100, true);
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
#line 152 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
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
            BeginContext(4363, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
#line 157 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
    }

#line default
#line hidden
            BeginContext(4383, 19, true);
            WriteLiteral("\r\n  </ul>\r\n</nav>\r\n");
            EndContext();
#line 161 "E:\diploma_project_here\SoftSpace_web\Views\Admin\TransactionModeration.cshtml"
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