#pragma checksum "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d8ef8b3f91131e4789347937954daa0ec16d9084d95b7f6da6910e2f3916038d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\_ViewImports.cshtml"
using GalleON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\_ViewImports.cshtml"
using GalleON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml"
using Contentful.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d8ef8b3f91131e4789347937954daa0ec16d9084d95b7f6da6910e2f3916038d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"70272d6e1563cf572c1308ab78b2e552d91b1207fcefbfca052730456f2ebe51", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentfulCollection<SOTShips>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml"
 foreach (var ships in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card m-2 col-12 col-lg-10 mx-auto\">\r\n        <div class=\"card-header\">\r\n            <h2 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml"
                              Write(ships.ShipName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"card-body text-center\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 377, "\"", 408, 1);
#nullable restore
#line 16 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml"
WriteAttributeValue("", 383, ships.ShipImage.File.Url, 383, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"werkt niet\" style=\"display: block; max-width: 100%;\" />\r\n            <div class=\"col-12 row justify-content-center\" style=\"font-size: 22px;\">\r\n                <p class=\"col-4\"><strong>Crew Size</strong>: ");
#nullable restore
#line 18 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml"
                                                        Write(ships.CrewSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"col-4\"><strong>Number of Decks</strong>: ");
#nullable restore
#line 19 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml"
                                                              Write(ships.NumberofDecks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"col-4\"><strong>Number of Masts</strong>: ");
#nullable restore
#line 20 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml"
                                                              Write(ships.NumberofMasts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\Jorrit Geurts\DevOpsCaseStudy\GalleON\GalleON\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentfulCollection<SOTShips>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
