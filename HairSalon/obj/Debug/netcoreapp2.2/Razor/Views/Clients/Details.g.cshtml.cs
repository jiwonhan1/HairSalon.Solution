#pragma checksum "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85f30bd0997fe13990eb4d8637955cf6a195a3f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Details.cshtml", typeof(AspNetCore.Views_Clients_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f30bd0997fe13990eb4d8637955cf6a195a3f4", @"/Views/Clients/Details.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/eraser.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/target.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(62, 85, true);
            WriteLiteral("\r\n<div class=\"clientDetails\">\r\n  <h2>Client Detail</h2>\r\n\r\n  <hr />\r\n  <h4>Stylist : ");
            EndContext();
            BeginContext(148, 19, false);
#line 10 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
           Write(ViewBag.StylistName);

#line default
#line hidden
            EndContext();
            BeginContext(167, 27, true);
            WriteLiteral("</h4>\r\n  <h4>Client Name : ");
            EndContext();
            BeginContext(195, 42, false);
#line 11 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
               Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(237, 28, true);
            WriteLiteral("</h4>\r\n  <h4>Phone Number : ");
            EndContext();
            BeginContext(266, 43, false);
#line 12 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
                Write(Html.DisplayFor(model => model.ClientPhone));

#line default
#line hidden
            EndContext();
            BeginContext(309, 23, true);
            WriteLiteral("</h4>\r\n  <h4>Address : ");
            EndContext();
            BeginContext(333, 45, false);
#line 13 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
           Write(Html.DisplayFor(model => model.ClientAddress));

#line default
#line hidden
            EndContext();
            BeginContext(378, 26, true);
            WriteLiteral("</h4>\r\n  <h4>Last Visit : ");
            EndContext();
            BeginContext(405, 51, false);
#line 14 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
              Write(Html.DisplayFor(model => model.LastVisitDate.Month));

#line default
#line hidden
            EndContext();
            BeginContext(456, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(458, 49, false);
#line 14 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
                                                                   Write(Html.DisplayFor(model => model.LastVisitDate.Day));

#line default
#line hidden
            EndContext();
            BeginContext(507, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(509, 50, false);
#line 14 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
                                                                                                                      Write(Html.DisplayFor(model => model.LastVisitDate.Year));

#line default
#line hidden
            EndContext();
            BeginContext(559, 24, true);
            WriteLiteral("</h4>\r\n  <h4>Birthday : ");
            EndContext();
            BeginContext(584, 46, false);
#line 15 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
            Write(Html.DisplayFor(model => model.Birthday.Month));

#line default
#line hidden
            EndContext();
            BeginContext(630, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(632, 44, false);
#line 15 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.Birthday.Day));

#line default
#line hidden
            EndContext();
            BeginContext(676, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(678, 45, false);
#line 15 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
                                                                                                          Write(Html.DisplayFor(model => model.Birthday.Year));

#line default
#line hidden
            EndContext();
            BeginContext(723, 58, true);
            WriteLiteral("</h4>\r\n  <hr />\r\n\r\n  <div id=\"clientDetailLinks\">\r\n    <p>");
            EndContext();
            BeginContext(781, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "85f30bd0997fe13990eb4d8637955cf6a195a3f48821", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(831, 71, false);
#line 19 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
                                                   Write(Html.ActionLink("Edit this Client", "Edit", new { id = Model.ClientId}));

#line default
#line hidden
            EndContext();
            BeginContext(902, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(915, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "85f30bd0997fe13990eb4d8637955cf6a195a3f410433", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(965, 75, false);
#line 20 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
                                                   Write(Html.ActionLink("Delete this Client", "Delete", new { id = Model.ClientId}));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(1053, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "85f30bd0997fe13990eb4d8637955cf6a195a3f412052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1103, 47, false);
#line 21 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Clients\Details.cshtml"
                                                   Write(Html.ActionLink("Back to Client list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 22, true);
            WriteLiteral("</p>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
