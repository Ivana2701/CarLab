#pragma checksum "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "affe2e2c246ec10e15556b3f699c7b1e90cd4830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome__ProductsHomePageList), @"mvc.1.0.view", @"/Views/CustomerHome/_ProductsHomePageList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"affe2e2c246ec10e15556b3f699c7b1e90cd4830", @"/Views/CustomerHome/_ProductsHomePageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2e94d20ead2fbacee36b149f73917313be3f01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CustomerHome__ProductsHomePageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarLab.Models.CommonEntities.BasicDataModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themeContent/customer/demos/car/images/filter-cars/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Open Imagination"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
                      
                        if (Model != null && Model.productsList != null && Model.productsList.Count > 0)
                        {
                           
                            foreach (var item in Model.productsList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                 <article class=""portfolio-item col-12 col-sm-6 col-md-4"">
                                    <div class=""grid-inner"">
                                        <div class=""portfolio-image"">
                                            <a href=""#""");
            BeginWriteAttribute("onclick", "  onclick=\"", 612, "\"", 659, 3);
            WriteAttributeValue("", 623, "ShowProductDetail(\'", 623, 19, true);
#nullable restore
#line 14 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
WriteAttributeValue("", 642, item.ProductID, 642, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 657, "\')", 657, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n\n");
#nullable restore
#line 16 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
                                                 if (item.ProductImage != null)
                                                {
                                                    string bitString = BitConverter.ToString(item.ProductImage);
                                                    if (bitString == "00" || bitString == "")
                                                    {
                                                       

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "affe2e2c246ec10e15556b3f699c7b1e90cd48306718", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 23 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
                                                    }
                                                    else
                                                    {
                                                        string imageBase64Data = Convert.ToBase64String(item.ProductImage);
                                                        string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                         <img");
            BeginWriteAttribute("src", " src=\"", 1751, "\"", 1770, 1);
#nullable restore
#line 29 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
WriteAttributeValue("", 1757, imageDataURL, 1757, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Open Imagination\">\n");
#nullable restore
#line 30 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
                                                    }
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "affe2e2c246ec10e15556b3f699c7b1e90cd48309519", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 35 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                               \n\n\n                                                <div class=\"filter-p-pricing\">\n                                                    <span class=\"p-price fw-bold ls1\">$");
#nullable restore
#line 41 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
                                                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                  
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""portfolio-desc"">
                                            <h3><a href=""#""");
            BeginWriteAttribute("onclick", " onclick=\"", 2766, "\"", 2812, 3);
            WriteAttributeValue("", 2776, "ShowProductDetail(\'", 2776, 19, true);
#nullable restore
#line 47 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
WriteAttributeValue("", 2795, item.ProductID, 2795, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2810, "\')", 2810, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
                                                                                                      Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n                                            <span>\n\n");
#nullable restore
#line 50 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
                                                  
                                                    item.Description = String.IsNullOrWhiteSpace(item.Description) ? "" : (item.Description.Substring(0, item.Description.Length>100 ? 100 : item.Description.Length));
                                                    item.Description = item.Description.Length > 99 ? (item.Description + "...") : item.Description;
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                 ");
#nullable restore
#line 54 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </span>
                                        </div>
                                        <div class=""row g-0 car-p-features font-primary clearfix"">
                                            <div class=""col-lg-4 col-6 p-0""><i class=""icon-car-meter""></i><span> 20000</span></div>
                                            <div class=""col-lg-4 col-6 p-0""><i class=""icon-car-door""></i><span> 5 Seater</span></div>
                                            <div class=""col-lg-4 col-6 p-0""><i class=""icon-car-fuel2""></i><span> 20kmpl</span></div>
                                            <div class=""col-lg-4 col-6 p-0""><i class=""icon-car-signal""></i><span> Automatic</span></div>
                                            <div class=""col-lg-4 col-6 p-0""><i class=""icon-car-wheel""></i><span> 15 Inch</span></div>
                                            <div class=""col-lg-4 col-6 p-0""><i class=""icon-car-care""></i><span> 2021</span></div>
                         ");
            WriteLiteral("               </div>\n                                    </div>\n                                </article>\n");
#nullable restore
#line 67 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"

                            }
                        }

                          else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                              <article class=""portfolio-item col-12 col-sm-6 col-md-4"">
                                    <div class=""grid-inner"">
                                        <h3>No Data found</h3>
                                    </div>
                                </article>
");
#nullable restore
#line 78 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductsHomePageList.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                          \n");
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