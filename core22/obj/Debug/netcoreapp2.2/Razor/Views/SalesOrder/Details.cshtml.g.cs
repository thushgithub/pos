#pragma checksum "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbb99efaf6f4ce660ba65f3cfdcdae45648a5a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesOrder_Details), @"mvc.1.0.view", @"/Views/SalesOrder/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesOrder/Details.cshtml", typeof(AspNetCore.Views_SalesOrder_Details))]
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
#line 1 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\_ViewImports.cshtml"
using core22;

#line default
#line hidden
#line 2 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\_ViewImports.cshtml"
using core22.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb99efaf6f4ce660ba65f3cfdcdae45648a5a0d", @"/Views/SalesOrder/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274199361aa84f71c2d19793a9f6f7494fc9e81e", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesOrder_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<core22.Models.POS.Models.SalesOrder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 123, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>SalesOrder</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(208, 42, false);
#line 14 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(250, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(309, 38, false);
#line 17 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
       Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(347, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(405, 47, false);
#line 20 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(452, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(511, 43, false);
#line 23 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(554, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(612, 50, false);
#line 26 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesOrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(662, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(721, 46, false);
#line 29 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
       Write(Html.DisplayFor(model => model.SalesOrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(767, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(825, 44, false);
#line 32 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(869, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(928, 45, false);
#line 35 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Name));

#line default
#line hidden
            EndContext();
            BeginContext(973, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1015, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbb99efaf6f4ce660ba65f3cfdcdae45648a5a0d8455", async() => {
                BeginContext(1071, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
                           WriteLiteral(Model.SalesOrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1079, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1086, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbb99efaf6f4ce660ba65f3cfdcdae45648a5a0d10825", async() => {
                BeginContext(1108, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1124, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(1129, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbb99efaf6f4ce660ba65f3cfdcdae45648a5a0d12207", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 42 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SalesOrderId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1175, 549, true);
            WriteLiteral(@"
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table"" id=""gridLine"" style=""width:100%"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Product</th>
                    <th scope=""col"">Quantity</th>
                    <th scope=""col"">Price</th>
                    <th scope=""col"">SubTotal</th>
                    <th scope=""col"">Discount</th>
                    <th scope=""col"">Total</th>
                </tr>
            </thead>
        </table>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1741, 1125, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            initGridLine();
        });

        function initGridLine() {
            var salesOrderId = $(""#SalesOrderId"").val();

            $(""#gridLine"").DataTable({
                ""ajax"": {
                    ""type"": ""GET"",
                    ""url"": ""/api/SalesOrderLine/GetLines?salesOrderId="" + salesOrderId + """",
                    ""dataSrc"": function (data) {

                        return data.lines
                    }
                },
                ""columns"": [
                    { ""data"": ""product.name"" },
                    { ""data"": ""quantity"" },
                    { ""data"": ""price"" },
                    { ""data"": ""subTotal"" },
                    { ""data"": ""discount"" },
                    { ""data"": ""total"" }
                ],
                ""language"": {
                    ""emptyTable"": ""data is empty.""
                },
                ""lengthChange"": false,
                ""bFilter"": false,
                ""paging"": fal");
                WriteLiteral("se,\n                \"info\": false\n            });\n\n            return false;\n        }\n    </script>\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<core22.Models.POS.Models.SalesOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591