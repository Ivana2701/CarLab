#pragma checksum "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a38784bf64d832fbd53367d0d1372b7e047b00c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminProducts_OrderDetail), @"mvc.1.0.view", @"/Views/AdminProducts/OrderDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a38784bf64d832fbd53367d0d1372b7e047b00c", @"/Views/AdminProducts/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2e94d20ead2fbacee36b149f73917313be3f01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminProducts_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarLab.Models.CommonEntities.BasicDataModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_Breadcrumbs.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mg-b-20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
  
    ViewData["Title"] = "Order Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
  
    var orderDetail =Model!=null && Model.ordersList!=null ?  Model.ordersList.FirstOrDefault() : new CarLab.Models.DbEntities.Orders();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"row\">\n    <div class=\"col-lg-5 col-md-5\">\n        <!-- Breadcubs Area Start Here -->\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a38784bf64d832fbd53367d0d1372b7e047b00c5877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <!-- Breadcubs Area End Here -->\n    </div>\n\n   <div class=\"col-lg-7 col-md-7 text-right\">\n\n       \n        <div class=\"breadcrumbs-area\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 608, "\"", 657, 1);
#nullable restore
#line 24 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
WriteAttributeValue("", 615, Url.Action("OrdersList", "AdminProducts"), 615, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-fill-lmd radius-30 text-light shadow-true-v bg-true-v\">Back To List</a>\n        </div>\n      \n\n    </div>\n\n</div>\n\n\n<div class=\"card height-auto\">\n    <div class=\"card-body\">\n        <div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a38784bf64d832fbd53367d0d1372b7e047b00c7829", async() => {
                WriteLiteral(@"
                <div class=""row gutters-8"">
                    <div class=""col-4-xxxl col-xl-4 col-lg-4 col-12 form-group"">
                        <label for=""OrderID"">Order ID</label>
                        <input type=""number"" id=""OrderID"" name=""OrderID"" class=""form-control"" readonly");
                BeginWriteAttribute("value", " value=\"", 1200, "\"", 1253, 1);
#nullable restore
#line 40 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
WriteAttributeValue("", 1208, orderDetail==null? 0 : orderDetail.OrderID, 1208, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                    </div>
                    <div class=""col-4-xxxl col-xl-4 col-lg-4 col-12 form-group"">
                        <label for=""name"">Customer Name</label>
                        <input type=""text"" id=""name"" name=""name"" class=""form-control"" readonly");
                BeginWriteAttribute("value", " value=\"", 1523, "\"", 1586, 1);
#nullable restore
#line 44 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
WriteAttributeValue("", 1531, orderDetail==null? "" : orderDetail.CustomerFullName, 1531, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                    </div>
                    <div class=""col-4-xxxl col-xl-4 col-lg-4 col-12 form-group"">
                        <label for=""email"">Email Address</label>
                        <input type=""text"" id=""email"" name=""email"" class=""form-control"" readonly");
                BeginWriteAttribute("value", " value=\"", 1859, "\"", 1919, 1);
#nullable restore
#line 48 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
WriteAttributeValue("", 1867, orderDetail==null? "" : orderDetail.CustomerEmail, 1867, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                    </div>


                    <div class=""col-4-xxxl col-xl-4 col-lg-4 col-12 form-group"">
                        <label for=""phone"">Phone</label>
                        <input type=""text"" id=""phone"" name=""phone"" class=""form-control"" readonly");
                BeginWriteAttribute("value", " value=\"", 2186, "\"", 2246, 1);
#nullable restore
#line 54 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
WriteAttributeValue("", 2194, orderDetail==null? "" : orderDetail.CustomerPhone, 2194, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                    </div>

                    <div class=""col-4-xxxl col-xl-4 col-lg-4 col-12 form-group"">
                        <label for=""address"">Delivery Address</label>
                        <input type=""text"" id=""address"" name=""address"" class=""form-control"" readonly");
                BeginWriteAttribute("value", " value=\"", 2529, "\"", 2591, 1);
#nullable restore
#line 59 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
WriteAttributeValue("", 2537, orderDetail==null? "" : orderDetail.CustomerAddress, 2537, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                    </div>\n\n                    <div class=\"col-4-xxxl col-xl-4 col-lg-4 col-12 form-group\">\n                        <label for=\"Total\">Total Amount ($)</label>\n");
#nullable restore
#line 64 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
                          
                            if(orderDetail!=null){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                 <input type=\"text\" id=\"Total\" class=\"form-control\" name=\"Total\" readonly");
                BeginWriteAttribute("value", " value=\"", 2955, "\"", 2987, 1);
#nullable restore
#line 66 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
WriteAttributeValue("", 2963, orderDetail.TotalAmount, 2963, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n");
#nullable restore
#line 67 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                 <input type=\"text\" id=\"Total\" class=\"form-control\" name=\"Total\" readonly");
                BeginWriteAttribute("value", " value=\"", 3189, "\"", 3197, 0);
                EndWriteAttribute();
                WriteLiteral("/>\n");
#nullable restore
#line 71 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                       \n                    </div>\n\n\n                </div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
        </div>



    </div>
</div>


<div class=""card height-auto"">
    <div class=""card-body"">
        <div class=""heading-layout1"">
            <div class=""item-title"">
                <h3>Order Detail</h3>
            </div>
            <div class=""dropdown"">
");
            WriteLiteral("            </div>\n        </div>\n\n\n        <!-- Grid listing starts here -->\n        <div class=\"table-responsive\" id=\"data_listing_grid\">\n            ");
#nullable restore
#line 108 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\AdminProducts\OrderDetail.cshtml"
       Write(await Html.PartialAsync("~/Views/AdminProducts/_OrderDetailPartial.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <!-- Grid listing ends here -->\n\n    </div>\n</div>\n");
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