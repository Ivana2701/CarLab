#pragma checksum "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b4106d21501bda30015b532697cb03b343b94b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterCustomer), @"mvc.1.0.view", @"/Views/Shared/_FooterCustomer.cshtml")]
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
#line 1 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
using CarLab.Models.DbEntities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b4106d21501bda30015b532697cb03b343b94b5", @"/Views/Shared/_FooterCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2e94d20ead2fbacee36b149f73917313be3f01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__FooterCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themeContent/customer/demos/car/images/logo-footer.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
  
    Users CustomerUser = new Users();

    var CustomerUserJson = sessonContext.HttpContext.Session.GetString("CustomerUser");
    if (!String.IsNullOrEmpty(CustomerUserJson))
    {
        CustomerUser = JsonConvert.DeserializeObject<Users>(CustomerUserJson);
    }

    CustomerUser = CustomerUser == null || CustomerUser.UserID < 1 ? new Users() : CustomerUser;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<footer id=""footer"" class=""dark border-0"" style=""background-color: #080808;"">
			<div class=""container-fluid px-5 clearfix"">
				<!-- Footer Widgets
				============================================= -->
				<div class=""footer-widgets-wrap"">

					<div class=""row col-mb-50 justify-content-between"">
						<div class=""col-lg-7"">

							<div class=""row col-mb-30"">
								<div class=""col-6 col-lg-6 col-md-6"">
									<div class=""widget widget_links widget-li-noicon"">
										<h4>Menus</h4>
										<ul>
											<li><a");
            BeginWriteAttribute("href", " href=\"", 957, "\"", 999, 1);
#nullable restore
#line 33 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
WriteAttributeValue("", 964, Url.Action("Index","CustomerHome"), 964, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a></li>\n\t\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 1032, "\"", 1077, 1);
#nullable restore
#line 34 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
WriteAttributeValue("", 1039, Url.Action("CarsList","CustomerHome"), 1039, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Car Listing</a></li>\n\t\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 1117, "\"", 1161, 1);
#nullable restore
#line 35 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
WriteAttributeValue("", 1124, Url.Action("AboutUs","CustomerHome"), 1124, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">About Us</a></li>\n\t\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 1198, "\"", 1244, 1);
#nullable restore
#line 36 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
WriteAttributeValue("", 1205, Url.Action("ContactUs","CustomerHome"), 1205, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Contacts Us</a></li>\n\t\t\t\t\t\t\t\t\t\t</ul>\n\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t<div class=\"col-6 col-lg-6 col-md-6\">\n\t\t\t\t\t\t\t\t\t<div class=\"widget widget_links widget-li-noicon\">\n\t\t\t\t\t\t\t\t\t\t<h4>Account</h4>\n\t\t\t\t\t\t\t\t\t\t<ul>\n\t\t\t\t\t\t\t\t\t\t\n");
#nullable restore
#line 46 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
                                              
											if (CustomerUser != null && CustomerUser.UserID > 0)
											{
												

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 1603, "\"", 1664, 1);
#nullable restore
#line 50 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
WriteAttributeValue("", 1610, Url.Action("LogoutCustomer","CustomerAuthentication"), 1610, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Logout</a></li>\n");
#nullable restore
#line 51 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
											}
											else
											{
												

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 1755, "\"", 1822, 1);
#nullable restore
#line 55 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
WriteAttributeValue("", 1762, Url.Action("LoginRegisterAccount","CustomerAuthentication"), 1762, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Login</a></li>\n");
#nullable restore
#line 56 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
											}

											if (CustomerUser != null && CustomerUser.UserID > 0)
											{
												

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 1962, "\"", 2061, 1);
#nullable restore
#line 61 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
WriteAttributeValue("", 1969, Url.Action("CarsCustomerBookingList","CustomerHome" , new {CustomerID=CustomerUser.UserID}), 1969, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Bookings</a></li>\n");
#nullable restore
#line 62 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\Shared\_FooterCustomer.cshtml"
											}
											

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\t\t\t\t\t\t\t\t\t\t</ul>\n\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t</div>\n\n\t\t\t\t\t\t</div>\n\n\t\t\t\t\t\t<div class=\"col-lg-5 text-center text-lg-end\">\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b4106d21501bda30015b532697cb03b343b94b511640", async() => {
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
							<br>
							<div style=""color: #444"">
								<span>&copy; Noor Tech Sol. All Rights Reserved.</span>
								<div class=""clear""></div>
							
							</div>
						</div>
					</div>

				</div><!-- .footer-widgets-wrap end -->
			</div>
		</footer>");
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
