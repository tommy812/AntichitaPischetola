#pragma checksum "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05eeb31a55533c148eee377e5aedbabfc9bd75fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowProduct), @"mvc.1.0.view", @"/Views/Product/ShowProduct.cshtml")]
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
#line 1 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\_ViewImports.cshtml"
using AntichitaPischetola2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\_ViewImports.cshtml"
using AntichitaPischetola2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05eeb31a55533c148eee377e5aedbabfc9bd75fe", @"/Views/Product/ShowProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330031e1a09fd6c33207b5334a6b4d105c46ebfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AntichitaPischetola2.Models.ProductsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h4>ProductModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 8 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 11 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.ModelYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.ModelYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductHeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.ProductHeight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductWidth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.ProductWidth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.IsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.Url1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.Url1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.Url2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.Url2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.Url3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.Url3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.Url4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
       Write(Html.DisplayFor(model => model.Url4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 88 "C:\Users\thoma\source\repos\AntichitaPischetola\AntichitaPischetola2\AntichitaPischetola2\Views\Product\ShowProduct.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05eeb31a55533c148eee377e5aedbabfc9bd75fe13481", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AntichitaPischetola2.Models.ProductsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591