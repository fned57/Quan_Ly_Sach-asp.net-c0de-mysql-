#pragma checksum "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c2483c1e42a20143ff3bc4329dd2d41621445f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhieuTra_TraSach), @"mvc.1.0.view", @"/Views/PhieuTra/TraSach.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44c2483c1e42a20143ff3bc4329dd2d41621445f", @"/Views/PhieuTra/TraSach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Views/_ViewImports.cshtml")]
    public class Views_PhieuTra_TraSach : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PJC.Models.PhieuMuonInCTPM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/PhieuTra/EditTraSach"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/PhieuTra/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
  
    ViewData["Title"] = "TraSach";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        setTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);</script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh Sách Phiếu Chưa Trả</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách phhiếu chưa trả</li>
    </ol>
    <div class=""card-body"">
        <div class=""row"">
");
#nullable restore
#line 21 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
             if (ViewBag.SuccessMsg != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
               Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>");
#nullable restore
#line 25 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""card mb-4"">
            <div class=""card-header""><i class=""fas fa-table mr-1""></i>Phiếu chưa trả</div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 35 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 38 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 41 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 44 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.NgayHenTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 47 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 50 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 53 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 56 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 59 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 62 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayNameFor(model => model.TienPhat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 69 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 73 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 76 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 79 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 82 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NgayHenTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 85 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 88 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 91 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 94 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 97 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 100 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TienPhat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c2483c1e42a20143ff3bc4329dd2d41621445f16001", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4890, "\"", 4908, 1);
#nullable restore
#line 104 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
WriteAttributeValue("", 4898, item.MaPM, 4898, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4984, "\"", 5004, 1);
#nullable restore
#line 105 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
WriteAttributeValue("", 4992, item.MaSach, 4992, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"masach\" />\r\n                                        <input type=\"submit\" value=\"Trả sách\" class=\"btn btn-outline-success\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c2483c1e42a20143ff3bc4329dd2d41621445f19066", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5402, "\"", 5420, 1);
#nullable restore
#line 111 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
WriteAttributeValue("", 5410, item.MaPM, 5410, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5496, "\"", 5516, 1);
#nullable restore
#line 112 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
WriteAttributeValue("", 5504, item.MaSach, 5504, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"masach\" />\r\n                                        <input type=\"submit\" value=\"Sửa\" class=\"btn btn-outline-warning\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 117 "C:\Users\trand\OneDrive\Công nghệ phần mêm\FrameWork\FrameWork\Framework đồ án\PJC\Views\PhieuTra\TraSach.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PJC.Models.PhieuMuonInCTPM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
