#pragma checksum "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Stylists\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f124259166c81f895d992cf49cb2dd03d6e2b697"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Search), @"mvc.1.0.view", @"/Views/Stylists/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Search.cshtml", typeof(AspNetCore.Views_Stylists_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f124259166c81f895d992cf49cb2dd03d6e2b697", @"/Views/Stylists/Search.cshtml")]
    public class Views_Stylists_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Stylists\Search.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(65, 111, true);
            WriteLiteral("\r\n<div class=\"stylistSearch\">\r\n  <h2><strong>Search a Stylist</strong></h2>\r\n\r\n  <div id=\"stylistSearchForm\">\r\n");
            EndContext();
#line 11 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Stylists\Search.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            BeginContext(214, 37, true);
            WriteLiteral("      <p><strong>Stylist Name\r\n      ");
            EndContext();
            BeginContext(252, 99, false);
#line 14 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Stylists\Search.cshtml"
 Write(Html.TextBoxFor((model => model.StylistName), new { @required = "required", @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(351, 111, true);
            WriteLiteral("\r\n      </p>\r\n      <input class=\"w3-button w3-purple\" type=\"submit\" value=\"Search\" style=\"cursor: pointer\";>\r\n");
            EndContext();
#line 17 "C:\Users\Jiwon Han\Desktop\Coding\c#-project\HairSalon.Solution\HairSalon\Views\Stylists\Search.cshtml"
    }

#line default
#line hidden
            BeginContext(469, 18, true);
            WriteLiteral("  </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
