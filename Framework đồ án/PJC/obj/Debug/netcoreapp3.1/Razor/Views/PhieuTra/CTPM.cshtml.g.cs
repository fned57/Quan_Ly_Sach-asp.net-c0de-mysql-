#pragma checksum "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff74573fcd7ef9b7192bdee701508b6533480fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhieuTra_CTPM), @"mvc.1.0.view", @"/Views/PhieuTra/CTPM.cshtml")]
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
#line 1 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\_ViewImports.cshtml"
using PJC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\_ViewImports.cshtml"
using PJC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff74573fcd7ef9b7192bdee701508b6533480fd", @"/Views/PhieuTra/CTPM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Views/_ViewImports.cshtml")]
    public class Views_PhieuTra_CTPM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PJC.Models.CTPM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
  
    ViewData["Title"] = "CTPM";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
Write(ViewBag.mapm);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
<div class=""card mb-4"">
    <div class=""card-header""><i class=""fas fa-table mr-1""></i>Phiếu mượn</div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 17 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                       Write(Html.DisplayNameFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 20 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                       Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 23 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                       Write(Html.DisplayNameFor(model => model.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                       Write(Html.DisplayNameFor(model => model.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 29 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                       Write(Html.DisplayNameFor(model => model.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 32 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 35 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                       Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 38 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                       Write(Html.DisplayNameFor(model => model.TienPhat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 48 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 54 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 63 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                           Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 66 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 69 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TienPhat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 72 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\CTPM.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PJC.Models.CTPM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
