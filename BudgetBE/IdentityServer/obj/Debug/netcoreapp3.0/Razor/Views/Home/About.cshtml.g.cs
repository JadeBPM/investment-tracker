#pragma checksum "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d61b533e817629203142834d7e11ed2dc4539fa4"
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
#line 1 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d61b533e817629203142834d7e11ed2dc4539fa4", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4682ade7b0fb6e6a361ec10cd3ef52676e4744", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 6 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<h3>User claims</h3>\r\n\r\n<dl>\r\n");
#nullable restore
#line 11 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 13 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 14 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 15 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dt>id token</dt>\r\n    <dd>");
#nullable restore
#line 18 "C:\Users\jmyer\source\repos\reactjs-ts-identityserver\IdentityServer\Views\Home\About.cshtml"
   Write(await ViewContext.HttpContext.GetTokenAsync("id_token"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n</dl>\r\n");
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
