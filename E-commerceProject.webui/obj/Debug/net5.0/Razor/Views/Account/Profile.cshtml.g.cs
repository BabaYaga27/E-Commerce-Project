#pragma checksum "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d51934446ec9183fd3d7dd1724b355d120533776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d51934446ec9183fd3d7dd1724b355d120533776", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d3d7eb503f3a9e2e107ee13e238ea7f4a1a218", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
  
        ViewData["Title"] = "Profile";
        Layout = "~/Views/Shared/_Layout5.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container rounded bg-white mt-5 mb-5"">
        <div class=""row"">
                <div class=""col-md-3 border-right"">
                        <div class=""d-flex flex-column align-items-center text-center p-3 py-5""><img
                                        class=""rounded-circle mt-5"" width=""150px""
                                        src=""https://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg""><span
                                        class=""font-weight-bold"">");
#nullable restore
#line 12 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                            Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span\r\n                                        class=\"text-black-50\">");
#nullable restore
#line 13 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                         Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span><span>
                                </span></div>
                </div>
                <div class=""col-md-5 border-right"">
                        <div class=""p-3 py-5"">
                                <div class=""d-flex justify-content-between align-items-center mb-3"">
                                        <h4 class=""text-right"">Profile Settings</h4>
                                </div>
                                <div class=""row mt-2"">
                                        <div class=""col-md-6""><label class=""labels"">Name</label>
                                                <p>");
#nullable restore
#line 23 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                              Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"col-md-6\"><label class=\"labels\">Surname</label>\r\n                                                <p>");
#nullable restore
#line 26 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                              Write(Model.User.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""row mt-3""></div>
                                        <div class=""col-md-12""><label class=""labels"">Username
                                                </label></div>
                                        <p>");
#nullable restore
#line 31 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                      Write(Model.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <div class=\"col-md-12\"><label class=\"labels\">Mobile\r\n                                                        Number</label></div>\r\n                                        <p>");
#nullable restore
#line 34 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                      Write(Model.User.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <div class=\"col-md-12\"><label class=\"labels\">Address</label>\r\n                                                <p>");
#nullable restore
#line 36 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                              Write(Model.User.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>

                                        <div class=""col-md-12""><label class=""labels"">BirthDate
                                                </label>
                                                <p>");
#nullable restore
#line 41 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                              Write(Model.User.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"col-md-12\"><label class=\"labels\">Sex\r\n                                                </label>\r\n");
#nullable restore
#line 45 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                 if (@Model.User.Sex == 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p>Female</p>\r\n");
#nullable restore
#line 48 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                 if (@Model.User.Sex == 1)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p>Male</p>\r\n");
#nullable restore
#line 53 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </div>\r\n                                        <div class=\"col-md-12\"><label class=\"labels\">Email\r\n                                                </label>\r\n                                                <p>");
#nullable restore
#line 59 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                              Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                                </div>\r\n\r\n                        </div>\r\n                </div>\r\n        </div>\r\n");
#nullable restore
#line 72 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
         if (@Model.OrderHistories.Count > 0)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-12"">
                        <h3 class=""h5 mb-4 text-center"">Order History</h3>
                        <div class=""table-wrap"">
                                <table class=""table"">
                                        <thead class=""thead-primary"">
                                                <tr>

                                                        <th>&nbsp;</th>
                                                        <th>Product</th>
                                                        <th>Date</th>
                                                        <th>Price</th>
                                                        <th>Quantity</th>
                                                        <th>Total</th>


                                                </tr>
                                        </thead>
                                        <tbody>");
#nullable restore
#line 93 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                foreach (var item in @Model.OrderHistories)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <tr class=""alert"" role=""alert"">

                                                                <td>
                                                                        <div class=""img""
                                                                style=""background-image:url(images/product-1.png)"">
                                                                        </div>
                                                                </td>
                                                                <td>
                                                                        <div class=""name"">
                                                                                <span>");
#nullable restore
#line 105 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                                                 Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                                                                <span>");
#nullable restore
#line 106 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                                                 Write(item.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                                        </div>
                                                                </td>
                                                                <td>
                                                                        <div class=""date"">
                                                                                <span class=""fw-bold"">");
#nullable restore
#line 111 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                                                                 Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                                        </div>\r\n                                                                </td>\r\n                                                                <td>$");
#nullable restore
#line 114 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                                Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                                <td class=""quantity"">
                                                                        <div class=""input-group"">
                                                                                <span
                                                                        class=""quantity form-control input-number"">");
#nullable restore
#line 118 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                                                                              Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                                        </div>\r\n                                                                </td>\r\n                                                                <td>$");
#nullable restore
#line 121 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                                 Write(item.Product.Price*item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                        </tr>\r\n");
#nullable restore
#line 124 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </tbody>\r\n                                </table>\r\n                        </div>\r\n                </div>\r\n");
#nullable restore
#line 130 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>ORDER HISTORY IS EMPTY</h1>\r\n");
#nullable restore
#line 134 "C:\Users\berkc\E-commerceProject\E-commerceProject\E-commerceProject.webui\Views\Account\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
