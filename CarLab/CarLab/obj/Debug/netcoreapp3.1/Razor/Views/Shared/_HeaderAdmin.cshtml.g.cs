#pragma checksum "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_HeaderAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd803d4e7bbbe734cd3ad6a3f311f6cccc7022c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderAdmin), @"mvc.1.0.view", @"/Views/Shared/_HeaderAdmin.cshtml")]
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
#line 1 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\_ViewImports.cshtml"
using CarLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\_ViewImports.cshtml"
using CarLab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\_ViewImports.cshtml"
using CarLab.DAL.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_HeaderAdmin.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_HeaderAdmin.cshtml"
using CarLab.Models.DbEntities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd803d4e7bbbe734cd3ad6a3f311f6cccc7022c7", @"/Views/Shared/_HeaderAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2e94d20ead2fbacee36b149f73917313be3f01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__HeaderAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themeContent/admin/img/logo-white.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 60px !important; width:161px !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themeContent/admin/img/figure/admin.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Admin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n\n\n");
#nullable restore
#line 6 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_HeaderAdmin.cshtml"
  
    Users usObj = new Users();
    var User =sessonContext!=null && sessonContext.HttpContext!=null ? sessonContext.HttpContext.Session.GetString("User") : "";
    if (!String.IsNullOrEmpty(User))
    {
        usObj = JsonConvert.DeserializeObject<Users>(User);
    }

     //string baseURL = urlHelper.GetAdminHomePageURL();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"navbar navbar-expand-md header-menu-one bg-light\">\n    <div class=\"nav-bar-header-one\">\n        <div class=\"header-logo\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 540, "\"", 580, 1);
#nullable restore
#line 21 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_HeaderAdmin.cshtml"
WriteAttributeValue("", 547, Url.Action("Index", "AdminHome"), 547, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cd803d4e7bbbe734cd3ad6a3f311f6cccc7022c77165", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </a>
        </div>
        <div class=""toggle-button sidebar-toggle"">
            <button type=""button"" class=""item-link"">
                <span class=""btn-icon-wrap"">
                    <span></span>
                    <span></span>
                    <span></span>
                </span>
            </button>
        </div>
    </div>
    <div class=""d-md-none mobile-nav-bar"">
        <button class=""navbar-toggler pulse-animation"" type=""button"" data-toggle=""collapse"" data-target=""#mobile-navbar"" aria-expanded=""false"">
            <i class=""far fa-arrow-alt-circle-down""></i>
        </button>
        <button type=""button"" class=""navbar-toggler sidebar-toggle-mobile"">
            <i class=""fas fa-bars""></i>
        </button>
    </div>
    <div class=""header-main-menu collapse navbar-collapse"" id=""mobile-navbar"">
        <ul class=""navbar-nav"">
            <li class=""navbar-item header-search-bar"">
");
            WriteLiteral(@"            </li>
        </ul>
        <ul class=""navbar-nav"">


            <li class=""navbar-item dropdown header-notification"" id=""header_notification_area"">
               
            </li>

            <li class=""navbar-item dropdown header-admin"">
                <a class=""navbar-nav-link dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown""
                   aria-expanded=""false"">
                    <div class=""admin-title"">
                        <h5 class=""item-title"">");
#nullable restore
#line 67 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_HeaderAdmin.cshtml"
                                          Write(usObj.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n                    </div>\n                    <div class=\"admin-img\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cd803d4e7bbbe734cd3ad6a3f311f6cccc7022c710280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </a>\n                <div class=\"dropdown-menu dropdown-menu-right\">\n                    <div class=\"item-header\">\n                        <h6 class=\"item-title\">");
#nullable restore
#line 76 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_HeaderAdmin.cshtml"
                                          Write(usObj.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    </div>\n                    <div class=\"item-content\">\n                        <ul class=\"settings-list\">\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3135, "\"", 3180, 1);
#nullable restore
#line 80 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_HeaderAdmin.cshtml"
WriteAttributeValue("", 3142, Url.Action("UserProfile","AdminHome"), 3142, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"flaticon-user\"></i>My Profile</a></li>\n\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3266, "\"", 3316, 1);
#nullable restore
#line 82 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_HeaderAdmin.cshtml"
WriteAttributeValue("", 3273, Url.Action("Logout","AdminAuthentication"), 3273, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"flaticon-turn-off\"></i>Log Out</a></li>\n                        </ul>\n                    </div>\n                </div>\n            </li>\n\n        </ul>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICustomerURLHelper urlHelper { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor sessonContext { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
