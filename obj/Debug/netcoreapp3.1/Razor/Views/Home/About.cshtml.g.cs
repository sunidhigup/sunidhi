#pragma checksum "C:\Users\sunidhigupta\source\repos\MyFirstWebApp\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e422495a8824d5002cde3e8037190c5787ee9b9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\sunidhigupta\source\repos\MyFirstWebApp\Views\_ViewImports.cshtml"
using MyFirstWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sunidhigupta\source\repos\MyFirstWebApp\Views\_ViewImports.cshtml"
using MyFirstWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e422495a8824d5002cde3e8037190c5787ee9b9a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9234ca7c4332f629a8c8c8b80fc04595c07db32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sunidhigupta\source\repos\MyFirstWebApp\Views\Home\About.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Information\r\n");
#nullable restore
#line 2 "C:\Users\sunidhigupta\source\repos\MyFirstWebApp\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>About</h1>\r\n\r\n");
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 9 "C:\Users\sunidhigupta\source\repos\MyFirstWebApp\Views\Home\About.cshtml"
        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p> Designation : ");
#nullable restore
#line 10 "C:\Users\sunidhigupta\source\repos\MyFirstWebApp\Views\Home\About.cshtml"
                 Write(Model.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p> Company_name : ");
#nullable restore
#line 11 "C:\Users\sunidhigupta\source\repos\MyFirstWebApp\Views\Home\About.cshtml"
                  Write(Model.Company_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>  Domain: ");
#nullable restore
#line 12 "C:\Users\sunidhigupta\source\repos\MyFirstWebApp\Views\Home\About.cshtml"
            Write(Model.Domain);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
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
