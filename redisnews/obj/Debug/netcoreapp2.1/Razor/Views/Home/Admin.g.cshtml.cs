#pragma checksum "/Users/borakasmer/redisnews/Views/Home/Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1495450d3805d162e5e82ba7ac4c8d8574208f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Admin), @"mvc.1.0.view", @"/Views/Home/Admin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Admin.cshtml", typeof(AspNetCore.Views_Home_Admin))]
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
#line 1 "/Users/borakasmer/redisnews/Views/_ViewImports.cshtml"
using testredis;

#line default
#line hidden
#line 2 "/Users/borakasmer/redisnews/Views/_ViewImports.cshtml"
using testredis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1495450d3805d162e5e82ba7ac4c8d8574208f2", @"/Views/Home/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57c26e4947a30b01c1d03bb5eaf62da74301d66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateNews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(12, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "/Users/borakasmer/redisnews/Views/Home/Admin.cshtml"
     if(Model.IsError)
    {

#line default
#line hidden
            BeginContext(41, 64, true);
            WriteLiteral("        <script>alert(\"Kayıt da tutarsızlık vardır!\");</script>\n");
            EndContext();
#line 5 "/Users/borakasmer/redisnews/Views/Home/Admin.cshtml"
    }

#line default
#line hidden
            BeginContext(111, 126, true);
            WriteLiteral("<div class=\"container\">\n    <div class=\"jumbotron\">\n        <h2>Borsoft News® Admin</h2>\n    </div>\n    <div align=\"right\"><b>");
            EndContext();
            BeginContext(238, 12, false);
#line 10 "/Users/borakasmer/redisnews/Views/Home/Admin.cshtml"
                     Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(250, 22, true);
            WriteLiteral("</b></div>       \n    ");
            EndContext();
            BeginContext(272, 1993, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f482f3ca7c69453380eb10555a2276ac", async() => {
                BeginContext(368, 486, true);
                WriteLiteral(@"
    <div>             
         <table class=""table"">                                
             <tr>                                                                                                                                                    
                 <td>                                                   
                     <b>Haber Başlığı :</b>
                 </td>       
                 <td>
                      <input type=""text"" name=""Title"" id=""Title""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 854, "\"", 874, 1);
#line 19 "/Users/borakasmer/redisnews/Views/Home/Admin.cshtml"
WriteAttributeValue("", 862, Model.Title, 862, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(875, 512, true);
                WriteLiteral(@" size=""100"">
                 </td>                                       
             </tr>   
             <tr>                                                                                                                                                    
                 <td>                                                   
                       <b>Haber İçeriği :</b>
                 </td>       
                 <td>
                       <textarea rows=""5"" cols=120 name=""Detail"" id=""Detail"" >");
                EndContext();
                BeginContext(1388, 12, false);
#line 27 "/Users/borakasmer/redisnews/Views/Home/Admin.cshtml"
                                                                         Write(Model.Detail);

#line default
#line hidden
                EndContext();
                BeginContext(1400, 281, true);
                WriteLiteral(@"</textarea>
                 </td>                                       
             </tr>  
             <tr>
                 <td>
                       <b>Haber Resimi : </b>
                 </td>
                 <td>
                      <input type=""hidden"" name=""Image""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1681, "\"", 1701, 1);
#line 35 "/Users/borakasmer/redisnews/Views/Home/Admin.cshtml"
WriteAttributeValue("", 1689, Model.Image, 1689, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1702, 64, true);
                WriteLiteral(">\n                       <input type=\"hidden\" name=\"UpdatedDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1766, "\"", 1792, 1);
#line 36 "/Users/borakasmer/redisnews/Views/Home/Admin.cshtml"
WriteAttributeValue("", 1774, Model.UpdatedDate, 1774, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1793, 28, true);
                WriteLiteral(">\n                      <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1821, "\"", 1847, 2);
                WriteAttributeValue("", 1827, "/images/", 1827, 8, true);
#line 37 "/Users/borakasmer/redisnews/Views/Home/Admin.cshtml"
WriteAttributeValue("", 1835, Model.Image, 1835, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1848, 410, true);
                WriteLiteral(@" width=""250px""><br><br>
                      <input type=""file"" name=""NewsImage"" id=""NewsImage""/>                             
                 </td>
             </tr>                                                  
         </table>         
             <div align=""center""><button type=""submit"" class=""btn btn-primary"" style=""width:50%"" name=""Image"" id=""Image"">Güncelle</button></div>   
    </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(2265, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News> Html { get; private set; }
    }
}
#pragma warning restore 1591
