#pragma checksum "C:\VB2\LTHDT\project\LTHDT_21880103\LTHDT_21880103\Pages\MH_HoaDonBan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e65e5ab42420d2271cdec694e75bf5701bcbe76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LTHDT_21880103.Pages.Pages_MH_HoaDonBan), @"mvc.1.0.razor-page", @"/Pages/MH_HoaDonBan.cshtml")]
namespace LTHDT_21880103.Pages
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
#line 1 "C:\VB2\LTHDT\project\LTHDT_21880103\LTHDT_21880103\Pages\_ViewImports.cshtml"
using LTHDT_21880103;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e65e5ab42420d2271cdec694e75bf5701bcbe76", @"/Pages/MH_HoaDonBan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74ad49a2cfdbfc5e935cf868a58811e1c39072c1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_HoaDonBan : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <h2>HÓA ĐƠN BÁN HÀNG</h2>
    <table>
        <tr>
            <th>Số thứ tự</th>
            <th>Tên mặt hàng</th>
            <th>Số lượng</th>
            <th>Ngày bán</th>
            <th></th>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <a href=""/MH_SuaSanPham?msp="">Sửa</a>
                <a href=""/MH_XoaSanPham?msp="">Xóa</a>
                <a href=""/MH_ThemSanPham?msp="">Thêm</a>
            </td>
        </tr>
    </table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LTHDT_21880103.Pages.MH_HoaDonBanModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LTHDT_21880103.Pages.MH_HoaDonBanModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LTHDT_21880103.Pages.MH_HoaDonBanModel>)PageContext?.ViewData;
        public LTHDT_21880103.Pages.MH_HoaDonBanModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
