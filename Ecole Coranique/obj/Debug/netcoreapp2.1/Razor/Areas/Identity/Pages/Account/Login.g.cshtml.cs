#pragma checksum "C:\Users\Saffou\source\repos\Ecole Coranique\Ecole Coranique\Areas\Identity\Pages\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cd01a4e449377d98f38434953bab5834253f498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Login), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Login.cshtml", typeof(AspNetCore.Areas_Identity_Pages_Account_Login))]
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
#line 4 "C:\Users\Saffou\source\repos\Ecole Coranique\Ecole Coranique\Areas\Identity\Pages\Account\Login.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cd01a4e449377d98f38434953bab5834253f498", @"/Areas/Identity/Pages/Account/Login.cshtml")]
    public class Areas_Identity_Pages_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(162, 9, false);
#line 5 "C:\Users\Saffou\source\repos\Ecole Coranique\Ecole Coranique\Areas\Identity\Pages\Account\Login.cshtml"
Write(attribute);

#line default
#line hidden
            EndContext();
            BeginContext(171, 27, true);
            WriteLiteral(" [IgnoreAntiforgeryToken]\r\n");
            EndContext();
            BeginContext(445, 546, true);
            WriteLiteral(@"<div id=""logreg-forms"">
    <form class=""form-signin"">
        <h1 class=""h3 mb-3 font-weight-normal"" style=""text-align: center""> Connexion</h1>
        <input type=""email"" id=""inputEmail"" class=""form-control"" placeholder=""Email address"" required="""" autofocus="""">
        <br />
        <input type=""password"" id=""inputPassword"" class=""form-control"" placeholder=""Password"" required="""">
        <br />
        <br />
        <button class=""btn btn-success btn-block"" type=""submit""><i class=""fas fa-sign-in-alt""></i> Se connecter</button>
");
            EndContext();
            BeginContext(1054, 241, true);
            WriteLiteral("\r\n        <hr>\r\n        <!-- <p>Don\'t have an account!</p>  -->\r\n        <button class=\"btn btn-primary btn-block\" type=\"button\" id=\"btn-signup\"><i class=\"fas fa-user-plus\"></i> Créer un compte</button>\r\n    </form>\r\n\r\n\r\n    <br>\r\n\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 7 "C:\Users\Saffou\source\repos\Ecole Coranique\Ecole Coranique\Areas\Identity\Pages\Account\Login.cshtml"
            
public async Task<IActionResult> OnPost()
{
    if (SignInManager.IsSignedIn(User))
    {
        await SignInManager.SignOutAsync();
    }

    return Redirect("~/");
}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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