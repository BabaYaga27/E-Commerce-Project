#pragma checksum "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e537099d0e4c8adaaec2e96dee7e9b539890c259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_CartList), @"mvc.1.0.view", @"/Views/Cart/CartList.cshtml")]
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
#line 2 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\_ViewImports.cshtml"
using E_commerceProject.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\_ViewImports.cshtml"
using E_commerceProject.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e537099d0e4c8adaaec2e96dee7e9b539890c259", @"/Views/Cart/CartList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d3d7eb503f3a9e2e107ee13e238ea7f4a1a218", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_CartList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cart/increaseQuantity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cart/decreaseQuantity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cart/deleteCartProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cart/Checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
  
    int total_sum=0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">Orders</h1>
        <hr>

        <table class=""table table-bordered mt-3"">
            <thead>
                <tr>

                    <td style=""width: 130px;"">Image</td>
                    <td>Name</td>
                    <td style=""width: 100px;"">Price</td>

                    <td style=""width: 110px;"">In Stock</td>
                    <td style=""width: 110px;text-align:center"">Quantity</td>
                    <td style=""width: 150px;""></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                 if (Model.Orders.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                     foreach (var item in Model.Products)
                    {

                            int sumperproduct=0;


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e537099d0e4c8adaaec2e96dee7e9b539890c2597652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 945, "~/img/", 945, 6, true);
#nullable restore
#line 33 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
AddHtmlAttributeValue("", 951, item.ImageUrl, 951, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n");
#nullable restore
#line 38 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                                 if (@item.InStock)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 41 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 45 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n<td style=\"text-align:center\">\r\n");
#nullable restore
#line 48 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                             foreach (var order in @Model.Orders)
                            {

                                if (@item.ProductId == order.ProductId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e537099d0e4c8adaaec2e96dee7e9b539890c25911440", async() => {
                WriteLiteral("\r\n                                      <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=", 1935, "", 1964, 1);
#nullable restore
#line 54 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
WriteAttributeValue("", 1942, Model.User.CustomerID, 1942, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                      <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=", 2042, "", 2064, 1);
#nullable restore
#line 55 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
WriteAttributeValue("", 2049, item.ProductId, 2049, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                      <input type=\"hidden\" name=\"Quantity\"");
                BeginWriteAttribute("value", " value=", 2141, "", 2163, 1);
#nullable restore
#line 56 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
WriteAttributeValue("", 2148, order.Quantity, 2148, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                     <button type=\"submit\" class=\"btn-sm\">  <i class=\"fa fa-plus px-2\"></i></button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                               Write(order.Quantity);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                                                   
                                    sumperproduct=@order.Quantity*Convert.ToInt32(@item.Price);

                                    

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e537099d0e4c8adaaec2e96dee7e9b539890c25915141", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=", 2605, "", 2634, 1);
#nullable restore
#line 63 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
WriteAttributeValue("", 2612, Model.User.CustomerID, 2612, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=", 2710, "", 2732, 1);
#nullable restore
#line 64 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
WriteAttributeValue("", 2717, item.ProductId, 2717, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"Quantity\"");
                BeginWriteAttribute("value", " value=", 2807, "", 2829, 1);
#nullable restore
#line 65 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
WriteAttributeValue("", 2814, order.Quantity, 2814, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn-sm\">  <i class=\"fa fa-minus px-2\"></i></button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"




                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e537099d0e4c8adaaec2e96dee7e9b539890c25918598", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 3259, "\"", 3289, 1);
#nullable restore
#line 79 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
WriteAttributeValue("", 3267, Model.User.CustomerID, 3267, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 3366, "\"", 3389, 1);
#nullable restore
#line 80 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
WriteAttributeValue("", 3374, item.ProductId, 3374, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 85 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                    total_sum+=sumperproduct;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Products</h3>\r\n                    </div>\r\n");
#nullable restore
#line 93 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <h3 style=\"text-align:right\">Total Sum: ");
#nullable restore
#line 96 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
                                           Write(total_sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e537099d0e4c8adaaec2e96dee7e9b539890c25922689", async() => {
                WriteLiteral("\r\n         <input type=\"hidden\" name=\"TotalSum\"");
                BeginWriteAttribute("value", " value=", 4112, "", 4129, 1);
#nullable restore
#line 98 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Cart\CartList.cshtml"
WriteAttributeValue("", 4119, total_sum, 4119, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <button type=\"submit\" style=\"float: right;\" class=\"btn btn-primary btn-sm\">Checkout</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
