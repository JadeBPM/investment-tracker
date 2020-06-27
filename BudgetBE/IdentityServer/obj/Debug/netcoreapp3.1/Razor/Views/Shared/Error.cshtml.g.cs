#pragma checksum "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a904f1afb721cfdf47ca2cac814a18e926c4d2e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity;

#line default
#line hidden
#line 3 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity.Models;

#line default
#line hidden
#line 4 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerWithAspNetIdentity.Models.ManageViewModels;

#line default
#line hidden
#line 7 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#line 1 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#line 2 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
using Microsoft.Extensions.Hosting;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a904f1afb721cfdf47ca2cac814a18e926c4d2e8", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4682ade7b0fb6e6a361ec10cd3ef52676e4744", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 6 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
  
    var error = Model?.Error?.Error;
    var errorDescription = host.IsDevelopment() ? Model?.Error?.ErrorDescription : null;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"error-page\">\r\n    <div class=\"page-header\">\r\n        <h1>Error</h1>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <div class=\"alert alert-danger\">\r\n                Sorry, there was an error\r\n\r\n");
#line 22 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
            WriteLiteral("                    <strong>\r\n                        <em>\r\n                            : ");
#line 26 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
                         Write(error);

#line default
#line hidden
            WriteLiteral("\r\n                        </em>\r\n                    </strong>\r\n");
#line 29 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"

                    if (errorDescription != null)
                    {

#line default
#line hidden
            WriteLiteral("                        <div>");
#line 32 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
                        Write(errorDescription);

#line default
#line hidden
            WriteLiteral("</div>\r\n");
#line 33 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
                    }
                }

#line default
#line hidden
            WriteLiteral("            </div>\r\n\r\n");
#line 37 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
#line 39 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
            WriteLiteral("</div>\r\n");
#line 40 "C:\Users\jmyer\source\repos\Projects\BudgetBackend\IdentityServer\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebHostEnvironment host { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
