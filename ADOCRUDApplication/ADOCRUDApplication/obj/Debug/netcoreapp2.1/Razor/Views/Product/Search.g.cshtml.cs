#pragma checksum "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "513d11dc411938318c6e27ee061d62fd6c8e250d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Search), @"mvc.1.0.view", @"/Views/Product/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Search.cshtml", typeof(AspNetCore.Views_Product_Search))]
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
#line 1 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\_ViewImports.cshtml"
using ADOCRUDApplication;

#line default
#line hidden
#line 2 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\_ViewImports.cshtml"
using ADOCRUDApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"513d11dc411938318c6e27ee061d62fd6c8e250d", @"/Views/Product/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ed164d8ae767f46d3f0d6d0b54d703809cdfc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ADOCRUDApplication.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Product/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(99, 29, true);
            WriteLiteral("\r\n<h2>Search results</h2>\r\n\r\n");
            EndContext();
#line 9 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(152, 196, true);
            WriteLiteral("    <table class=\"table\">\r\n        <style>\r\n            table, th, td {\r\n                border: 1px solid black;\r\n            }\r\n        </style>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(349, 45, false);
#line 19 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(394, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(450, 47, false);
#line 22 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(497, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(553, 48, false);
#line 25 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(601, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(657, 47, false);
#line 28 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(704, 61, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 33 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
            BeginContext(817, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(878, 47, false);
#line 37 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
               Write(Html.DisplayFor(modelItem => product.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(925, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(993, 49, false);
#line 40 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
               Write(Html.DisplayFor(modelItem => product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1110, 50, false);
#line 43 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
               Write(Html.DisplayFor(modelItem => product.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1228, 49, false);
#line 46 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
               Write(Html.DisplayFor(modelItem => product.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1345, 81, false);
#line 49 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
               Write(Html.ActionLink("Update", "UpdateProduct", new { productID = product.ProductID }));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1451, 83, false);
#line 50 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
               Write(Html.ActionLink("Details", "DetailsProduct", new { productID = product.ProductID }));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 23, true);
            WriteLiteral("|\r\n                    ");
            EndContext();
            BeginContext(1558, 81, false);
#line 51 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
               Write(Html.ActionLink("Delete", "DeleteProduct", new { productID = product.ProductID }));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1947, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 57 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
        }

#line default
#line hidden
            BeginContext(2000, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 59 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2026, 37, true);
            WriteLiteral("    <h3>No records where found</h3>\r\n");
            EndContext();
#line 63 "D:\Projects\DotNet\ADOApplication\ADOCRUDApplication\ADOCRUDApplication\Views\Product\Search.cshtml"
}

#line default
#line hidden
            BeginContext(2066, 755, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2077e0f7a6384b9b90e2cb82efbaa657", async() => {
                BeginContext(2130, 202, true);
                WriteLiteral("\r\n\r\n    <input type=\"text\" name=\"SearchValue\" class=\"form-control\" placeholder=\"Product Name\" />\r\n    <span>Search Category :</span>\r\n    <select name=\"ProductCategoryID\" class=\"form-control\">\r\n        ");
                EndContext();
                BeginContext(2332, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "775c51220e254c88aae3e2318111b0c0", async() => {
                    BeginContext(2350, 8, true);
                    WriteLiteral("Clothing");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2367, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2377, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab2101d4c5974ec3a7a7e153f303b15e", async() => {
                    BeginContext(2395, 11, true);
                    WriteLiteral("Electronics");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2415, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2425, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3e5c767aa104e01a0787cd124c81a61", async() => {
                    BeginContext(2443, 7, true);
                    WriteLiteral("Grocery");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2459, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2469, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40e53583d9f34ba8a54fea1c7e3d941a", async() => {
                    BeginContext(2487, 15, true);
                    WriteLiteral("Home Appliances");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2511, 303, true);
                WriteLiteral(@"
    </select>
    <span>Price Form :</span>
    <input type=""number"" name=""Min"" class=""form-control"" min=""0"" max=""250000"" />
    <span> To </span>
    <input type=""number"" name=""Max"" class=""form-control"" min=""0"" max=""250000"" />
    <input type=""submit"" value=""Search"" class=""btn btn-primary"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ADOCRUDApplication.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
