#pragma checksum "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\Shared\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StatusMessage), @"mvc.1.0.view", @"/Views/Shared/_StatusMessage.cshtml")]
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
#line 1 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp.Models.Comments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0723a602e84d5a261d35f2702dcc54883c69cad5", @"/Views/Shared/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc5162fb7be94022b88d2b1f9bd13881bddb4964", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\Shared\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#nullable restore
#line 6 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\Shared\_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
#line 8 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\Shared\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Views\Shared\_StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
