#pragma checksum "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "875dfa20f05e56b3e19124b9cbf95cacfd943510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminHome__ContactUsListtPartial), @"mvc.1.0.view", @"/Views/AdminHome/_ContactUsListtPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"875dfa20f05e56b3e19124b9cbf95cacfd943510", @"/Views/AdminHome/_ContactUsListtPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2e94d20ead2fbacee36b149f73917313be3f01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminHome__ContactUsListtPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarLab.Models.CommonEntities.BasicDataModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table display text-nowrap"" id=""table_listing_data"">
    <thead>
        <tr>
        	
            <th class=""no-sort"">ContactUs ID</th>
            <th class=""no-sort"">Customer Name</th>
            <th class=""no-sort"">Customer Email</th>
            <th class=""no-sort"">CustomerPhone</th>

            <th class=""no-sort"">CustomerMessage</th>
            <th class=""no-sort"">AdminReply</th>
            <th class=""no-sort"">CustomerAskedOn</th>
            <th class=""no-sort"">AdminReliedOn</th>
           
            <th class=""no-sort"">Action</th>
        </tr>
    </thead>
    <tbody>


");
#nullable restore
#line 23 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
          
            if (Model != null && Model.ContactUsList != null && Model.ContactUsList.Count > 0)
            {
                foreach (var item in Model.ContactUsList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n\n                        <td>");
#nullable restore
#line 30 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
                       Write(item.ContactUsID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 31 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
                       Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 32 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
                       Write(item.CustomerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 33 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
                       Write(item.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 34 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
                       Write(item.CustomerMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 35 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
                       Write(item.AdminReply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 36 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
                       Write(item.CustomerAskedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 37 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
                       Write(item.AdminReliedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>



                        <td>
                            <div class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false"">
                                    <span class=""flaticon-more-button-of-three-dots""></span>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right"">

                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1750, "\"", 1796, 3);
            WriteAttributeValue("", 1760, "showReplyModal(\'", 1760, 16, true);
#nullable restore
#line 48 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"
WriteAttributeValue("", 1776, item.ContactUsID, 1776, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1793, "\');", 1793, 3, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#!\" class=\"dropdown-item\" ><i class=\"fas fa-cogs text-dark-pastel-green\"></i>Reply</a>\n\n\n\n                                </div>\n                            </div>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 56 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminHome\_ContactUsListtPartial.cshtml"

                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </tbody>\n</table>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarLab.Models.CommonEntities.BasicDataModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
