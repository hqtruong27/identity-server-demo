#pragma checksum "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7578c629a275994808ac7949fb00ae4e01dc79d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\_ViewImports.cshtml"
using Knowledge.Web.IdentityProvider;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\_ViewImports.cshtml"
using Knowledge.Web.IdentityProvider.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7578c629a275994808ac7949fb00ae4e01dc79d9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a826902beab5dcd031c3850c6d35b0e39134f40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Type</th>
                <th>Value</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Home\Index.cshtml"
             if (User.Identity.IsAuthenticated)
            {
                foreach (var item in User.Claims)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 21 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Home\Index.cshtml"
                       Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Home\Index.cshtml"
                       Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 24 "D:\Documents\git\New folder\IdentityProvider\Knowledge.Web.IdentityProvider\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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