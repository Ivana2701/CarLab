#pragma checksum "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eba2837734f919100a753d344d7b9bc9747ed276"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome__ProductDetailPartial), @"mvc.1.0.view", @"/Views/CustomerHome/_ProductDetailPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eba2837734f919100a753d344d7b9bc9747ed276", @"/Views/CustomerHome/_ProductDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2e94d20ead2fbacee36b149f73917313be3f01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CustomerHome__ProductDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarLab.Models.CommonEntities.BasicDataModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themeContent/customer/demos/restaurant/images/menu/breakfast/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart mb-0 d-flex justify-content-between align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n<div class=\"modal-dialog modal-lg\">\n    <div class=\"modal-content\">\n        <div class=\"modal-header\">\n            <h4 class=\"modal-title\" id=\"myModalLabel\">");
#nullable restore
#line 8 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                  Write(Model!=null && Model.productsObj!=null ? Model.productsObj.ProductName : "Product Title");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            <button type=""button"" class=""btn-close btn-sm"" data-bs-dismiss=""modal"" aria-hidden=""true""></button>
        </div>
        <div class=""modal-body"">

            <div class=""row gutter-40 col-mb-80"">
                <div class=""postcontent col-lg-12 order-lg-last"">

                    <div class=""single-product"">
                        <div class=""product"">
                            <div class=""row gutter-40"">

                                <div class=""col-md-6"">

                                    <!-- Product Single - Gallery
                                    ============================================= -->
                                    <div class=""product-image"">
                                        <div class=""fslider"" data-pagi=""false"" data-arrows=""false"" data-thumbs=""true"">
                                            <div class=""flexslider"">
                                                <div class=""slider-wrap"" data-lightbox=""gallery"">
                              ");
            WriteLiteral(@"                      <div class=""slide"" data-thumb=""images/shop/thumbs/dress/3.jpg""><a href=""images/shop/dress/3.jpg"" title=""Pink Printed Dress - Front View"" data-lightbox=""gallery-item""><img src=""images/shop/dress/3.jpg"" alt=""Pink Printed Dress""></a></div>
");
#nullable restore
#line 29 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                      
                                                        if (Model != null && Model.productsObj != null && Model.productsObj.ProductImage != null)
                                                        {
                                                            string bitString = BitConverter.ToString(Model.productsObj.ProductImage);
                                                            if (bitString == "00" || bitString == "")
                                                            {

                                                               

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <a href=\"images/shop/dress/3.jpg\"");
            BeginWriteAttribute("title", " title=\"", 2308, "\"", 2346, 1);
#nullable restore
#line 37 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
WriteAttributeValue("", 2316, Model.productsObj.ProductName, 2316, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-lightbox=\"gallery-item\">\n                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eba2837734f919100a753d344d7b9bc9747ed2769359", async() => {
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
            WriteLiteral("\n                                                                    </a>\n");
#nullable restore
#line 40 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                              
                                                            }
                                                            else
                                                            {
                                                                string imageBase64Data = Convert.ToBase64String(Model.productsObj.ProductImage);
                                                                string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                               <a href=\"#!\"");
            BeginWriteAttribute("title", " title=\"", 3231, "\"", 3269, 1);
#nullable restore
#line 46 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
WriteAttributeValue("", 3239, Model.productsObj.ProductName, 3239, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-lightbox=\"gallery-item\">\n                                                                        <img");
            BeginWriteAttribute("src", " src=\"", 3377, "\"", 3396, 1);
#nullable restore
#line 47 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
WriteAttributeValue("", 3383, imageDataURL, 3383, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"1\">\n                                                                    </a>\n");
#nullable restore
#line 49 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                            }
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eba2837734f919100a753d344d7b9bc9747ed27613011", async() => {
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
#line 54 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                        }

                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\n                                            </div>\n                                        </div>\n");
            WriteLiteral(@"                                    </div><!-- Product Single - Gallery End -->

                                </div>

                                <div class=""col-md-6 product-desc"">

                                    <div class=""d-flex align-items-center justify-content-between"">

                                        <!-- Product Single - Price
                                        ============================================= -->
");
#nullable restore
#line 71 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                          
                                            if (Model!=null && Model.productsObj!=null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"product-price\"> <ins>$ ");
#nullable restore
#line 74 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                                              Write(Model.productsObj.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins></div><!-- Product Single - Price End -->\n");
#nullable restore
#line 75 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                  <div class=\"product-price\"> <ins>$ Not Confirm</ins></div><!-- Product Single - Price End -->\n");
#nullable restore
#line 79 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                       
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                      

                                    </div>

                                    <div class=""line""></div>

                                    <!-- Product Single - Quantity & Cart Button
                                    ============================================= -->
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eba2837734f919100a753d344d7b9bc9747ed27617303", async() => {
                WriteLiteral("\n");
#nullable restore
#line 91 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                          
                                            int ProductID = Model != null && Model.productsObj != null ? Model.productsObj.ProductID : 0;
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6180, "\"", 6213, 3);
                WriteAttributeValue("", 6190, "AddToCart(\'", 6190, 11, true);
#nullable restore
#line 94 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
WriteAttributeValue("", 6201, ProductID, 6201, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6211, "\')", 6211, 2, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"add-to-cart button m-0\">Book Now</button>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<!-- Product Single - Quantity & Cart Button End -->

                                    <div class=""line""></div>

                                    <!-- Product Single - Short Description
                                    ============================================= -->
                                    <p>
                                        ");
#nullable restore
#line 102 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                    Write(Model!=null && Model.productsObj!=null ? Model.productsObj.Description : "No Description");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </p>

                                    <!-- Product Single - Meta
                                    ============================================= -->
                                    <div class=""card product-meta"">
                                        <div class=""card-body"">

                                            <span class=""posted_in"">Make: <a href=""#"" rel=""tag""> ");
#nullable restore
#line 111 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                                                             Write(Model!=null && Model.productsObj!=null ? Model.productsObj.MakeName : " ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>.</span>\n                                             <span class=\"posted_in\">Model: <a href=\"#\" rel=\"tag\"> ");
#nullable restore
#line 112 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                                                               Write(Model!=null && Model.productsObj!=null ? Model.productsObj.ModelName : " ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>.</span>\n                                             <span class=\"posted_in\">Color: <a href=\"#\" rel=\"tag\"> ");
#nullable restore
#line 113 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                                                               Write(Model!=null && Model.productsObj!=null ? Model.productsObj.ColorName : " ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>.</span>\n                                             <span class=\"posted_in\">Year: <a href=\"#\" rel=\"tag\"> ");
#nullable restore
#line 114 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                                                              Write(Model!=null && Model.productsObj!=null ? Model.productsObj.ProductYear : " ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>.</span>\n                                             <span class=\"posted_in\">Location: <a href=\"#\" rel=\"tag\"> ");
#nullable restore
#line 115 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                                                                  Write(Model!=null && Model.productsObj!=null ? Model.productsObj.LocationName : " ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>.</span>\n                                             <span class=\"posted_in\">Fuel Type: <a href=\"#\" rel=\"tag\"> ");
#nullable restore
#line 116 "C:\Users\TEODOR\Desktop\gitHub project for pavel's fr\CarLabProject-main\CarLab\CarLab\Views\CustomerHome\_ProductDetailPartial.cshtml"
                                                                                                   Write(Model!=null && Model.productsObj!=null ? Model.productsObj.FuelType : " ");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>.</span>

                                        </div>
                                    </div><!-- Product Single - Meta End -->


                                </div>

                                <div class=""w-100""></div>



                            </div>
                        </div>
                    </div>




                </div>


            </div>

        </div>
    </div>
</div>");
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