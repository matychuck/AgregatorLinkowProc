#pragma checksum "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\User\SignIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d99784c6110e87fab614527499050b9e463f27a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SignIn), @"mvc.1.0.view", @"/Views/User/SignIn.cshtml")]
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
#line 1 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\_ViewImports.cshtml"
using AgregatorLinkowProc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\_ViewImports.cshtml"
using AgregatorLinkowProc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d99784c6110e87fab614527499050b9e463f27a4", @"/Views/User/SignIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e80bfeb581b7e6290cc629d9cffb6341ed03cffb", @"/Views/_ViewImports.cshtml")]
    public class Views_User_SignIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AgregatorLinkowProc.ViewModels.LoginVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\User\SignIn.cshtml"
  
    ViewBag.Title = "SignIn";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"signin-form\">\r\n    <div class=\"signin-form-main\">\r\n");
#nullable restore
#line 9 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\User\SignIn.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"signin-title\">\r\n                Sign in\r\n            </div>\r\n            <hr />\r\n            <div class=\"signin-input\">\r\n                ");
#nullable restore
#line 16 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\User\SignIn.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", placeholder = "Email" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"signin-input\">\r\n                ");
#nullable restore
#line 19 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\User\SignIn.cshtml"
           Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control", placeholder = "Password", type = "password" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\User\SignIn.cshtml"
       Write(Html.ValidationSummary(false, "", new { @class = "text-danger validation-error" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"signin-button\">\r\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Sign in\">\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\User\SignIn.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"signin-button\">\r\n            or\r\n        </div>\r\n        <div class=\"signin-button\">\r\n            ");
#nullable restore
#line 30 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\User\SignIn.cshtml"
       Write(Html.ActionLink("Create account", "SignUp", "User", null, new { @class = "btn btn-outline-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgregatorLinkowProc.ViewModels.LoginVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
