#pragma checksum "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad128963a4048f9269ad530c27fb1390008915b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Detail), @"mvc.1.0.view", @"/Views/Employee/Detail.cshtml")]
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
#line 1 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\_ViewImports.cshtml"
using WarehouseManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\_ViewImports.cshtml"
using WarehouseManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\_ViewImports.cshtml"
using WarehouseManagementSystem.Models.EmployeeViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad128963a4048f9269ad530c27fb1390008915b", @"/Views/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a55eefa47799cca704885ef230f0ac6bee74ae95", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2 class=""mt-5 text-center"">Employee Detail</h2>

<div class=""row mt-5 shadow p-3 mb-5 bg-white rounded table-responsive-lg table-responsive-md table-responsive-sm"">
    <div class=""col-lg-6 col-md-12 col-sm-12"">
        <table class=""table table-hover table-sm table-striped table-borderless mt-5"">
            <tr>
                <th class=""col-wrap-text"">");
#nullable restore
#line 9 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td class=\"col-wrap-text\">");
#nullable restore
#line 10 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-wrap-text\">");
#nullable restore
#line 13 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td class=\"col-wrap-text\">");
#nullable restore
#line 14 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-wrap-text\">");
#nullable restore
#line 17 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td class=\"col-wrap-text\">");
#nullable restore
#line 18 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-wrap-text\">");
#nullable restore
#line 21 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td class=\"col-wrap-text\">");
#nullable restore
#line 22 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-wrap-text\">");
#nullable restore
#line 25 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td class=\"col-wrap-text\">");
#nullable restore
#line 26 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-wrap-text\">");
#nullable restore
#line 29 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td class=\"col-wrap-text\">");
#nullable restore
#line 30 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayFor(model => model.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-wrap-text\">");
#nullable restore
#line 33 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayNameFor(model => model.HomeWarehouse));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td class=\"col-wrap-text\">");
#nullable restore
#line 34 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayFor(model => model.HomeWarehouse));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"col-wrap-text\">");
#nullable restore
#line 37 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayNameFor(model => model.WarehouseEmployeeCardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td class=\"col-wrap-text\">");
#nullable restore
#line 38 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                     Write(Html.DisplayFor(model => model.WarehouseEmployeeCardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-lg-6 col-md-12 col-sm-12 mt-5\">\r\n        <h4>Assets Currently Checked Out</h4>\r\n        <div style=\"max-height: 200px;\" class=\"pre-scrollable\">\r\n");
#nullable restore
#line 45 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
             if (@Model.AssetsCheckedOut.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                 foreach (var checkout in @Model.AssetsCheckedOut)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <div class=\"card border-primary mb-3 mr-3\">\r\n                            <div class=\"card-header\">\r\n                                ");
#nullable restore
#line 52 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                           Write(checkout.WarehouseAsset.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - (Warehouse Asset ID: ");
#nullable restore
#line 52 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                                                                Write(checkout.WarehouseAsset.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                            </div>\r\n                            <div class=\"card-body\">\r\n                                <h6>\r\n                                    Since: ");
#nullable restore
#line 56 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                      Write(checkout.Since);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h6>\r\n                                <h6>\r\n                                    Due: ");
#nullable restore
#line 59 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                                    Write(checkout.Until);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h6>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 64 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>No items currently checked out.</div>\r\n");
#nullable restore
#line 69 "C:\Users\MB\Desktop\WarehouseManagementSystem\WarehouseManagementSystem\Views\Employee\Detail.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
