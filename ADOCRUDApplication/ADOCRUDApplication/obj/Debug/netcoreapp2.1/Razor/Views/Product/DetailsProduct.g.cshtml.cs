#pragma checksum "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc57c4d04f0b5124d380996337d53cab57e509ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DetailsProduct), @"mvc.1.0.view", @"/Views/Product/DetailsProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/DetailsProduct.cshtml", typeof(AspNetCore.Views_Product_DetailsProduct))]
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
#line 1 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\_ViewImports.cshtml"
using ADOCRUDApplication;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\_ViewImports.cshtml"
using ADOCRUDApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc57c4d04f0b5124d380996337d53cab57e509ec", @"/Views/Product/DetailsProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ed164d8ae767f46d3f0d6d0b54d703809cdfc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DetailsProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ADOCRUDApplication.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
  
    ViewData["Title"] = "DetailsProduct";

#line default
#line hidden
            BeginContext(94, 94, true);
            WriteLiteral("\r\n<h2>DetailsProduct</h2>\r\n\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(189, 45, false);
#line 12 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(234, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(280, 41, false);
#line 16 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
       Write(Html.DisplayFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(321, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(367, 47, false);
#line 20 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(414, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(460, 43, false);
#line 24 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(503, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(547, 48, false);
#line 27 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(595, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(641, 44, false);
#line 31 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
       Write(Html.DisplayFor(model => model.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(685, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(731, 47, false);
#line 35 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(778, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(824, 43, false);
#line 39 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(867, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(915, 72, false);
#line 45 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
Write(Html.ActionLink("Update", "UpdateProduct", new { id = Model.ProductID }));

#line default
#line hidden
            EndContext();
            BeginContext(987, 7, true);
            WriteLiteral("|\r\n    ");
            EndContext();
            BeginContext(995, 40, false);
#line 46 "C:\Users\admin\Desktop\Products\ADOCRUDApplication\ADOCRUDApplication\Views\Product\DetailsProduct.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 8, true);
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ADOCRUDApplication.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
