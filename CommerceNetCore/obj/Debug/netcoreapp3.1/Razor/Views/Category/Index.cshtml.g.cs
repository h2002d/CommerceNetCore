#pragma checksum "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b756344024984df7c84eb06c075517b9d666394c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\_ViewImports.cshtml"
using CommerceNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\_ViewImports.cshtml"
using CommerceNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b756344024984df7c84eb06c075517b9d666394c", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85cf52a6d655a65cdd6f30c8b59d29ccbc3cbfc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommerceNetCore.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml"
     foreach (var item in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 190, "\"", 220, 2);
            WriteAttributeValue("", 197, "/Product/Index/", 197, 15, true);
#nullable restore
#line 10 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 212, item.Id, 212, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"row category_product\">\r\n                <div class=\"col-sm-3\" style=\"position:relative;\">\r\n                    <img style=\"height:auto;width:100%;\"");
            BeginWriteAttribute("src", " src=\"", 395, "\"", 472, 1);
#nullable restore
#line 13 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 401, item.ProductImages==null?"":item.ProductImages.FirstOrDefault().Path, 401, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-sm-9\">\r\n                    <b>");
#nullable restore
#line 16 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml"
                   Write(item.Name.Length <= 80 ? item.Name : item.Name.Substring(0, 80) + "...");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                    <p>Price: <span style=\"color:#0094ff\">");
#nullable restore
#line 17 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml"
                                                     Write(item.Price.ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> AMD</p>\r\n                    <p>\r\n                        ");
#nullable restore
#line 19 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml"
                   Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 24 "C:\Users\davitha\source\repos\CommerceNetCore\CommerceNetCore\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommerceNetCore.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591