#pragma checksum "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\POS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c09483d2e4c14d49b98b3c04b9556565bdb90322"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesOrder_POS), @"mvc.1.0.view", @"/Views/SalesOrder/POS.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesOrder/POS.cshtml", typeof(AspNetCore.Views_SalesOrder_POS))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c09483d2e4c14d49b98b3c04b9556565bdb90322", @"/Views/SalesOrder/POS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274199361aa84f71c2d19793a9f6f7494fc9e81e", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesOrder_POS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquerey-numpad/jquery.numpad.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\inventory\2\New folder\POS---Point-Of-Sales-master\POS---Point-Of-Sales-master\core22\Views\SalesOrder\POS.cshtml"
  
    ViewData["Title"] = "POS";

#line default
#line hidden
            BeginContext(37, 3711, true);
            WriteLiteral(@"
<h1>POS - Point of sales</h1>
<div class=""row"">
    <div class=""col-md-5"">
        <table class=""table"" id=""productLine"" style=""width:100%"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Product</th>
                    <th scope=""col"">Price (Sell)</th>
                    <th scope=""col"">Price (Purchase)</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
        </table>
    </div>
    <div class=""col-md-7"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""form-group"">
                    <label class=""control-label"">Order Number #</label>
                    <input class=""form-control"" id=""orderNumber"" readonly />
                    <hidden id=""salesOrderId""></hidden>
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""form-group"">
                    <label class=""control-label"">Product</label>
                    <input clas");
            WriteLiteral(@"s=""form-control"" id=""product"" readonly />
                    <hidden id=""productId""></hidden>
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""form-group"">
                    <label class=""control-label"">Quantity</label>
                    <input type=""number"" class=""form-control"" id=""quantity"" />
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""form-group"">
                    <label class=""control-label"">Price</label>
                    <input type=""number"" class=""form-control"" id=""price"" />
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table"" id=""posLine"" style=""width:100%"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">Product</th>
                            <th scope=""col"">Price</th>
                            <th ");
            WriteLiteral(@"scope=""col"">Qty</th>
                            <th scope=""col"">SubTotal</th>
                            <th scope=""col"">Disc.</th>
                            <th scope=""col"">Total</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""form-group"">
                    <label class=""control-label"">Total</label>
                    <input class=""form-control"" id=""total"" readonly />
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""form-group"">
                    <label class=""control-label"">Payment</label>
                    <input type=""number"" class=""form-control"" id=""payment"" />
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""form-group"">
                    <label class=""control-label"">Cha");
            WriteLiteral(@"nge</label>
                    <input class=""form-control"" id=""change"" readonly />
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <button onclick=""initiateNewPOSOrder()"" class=""btn btn-block btn-success"">New</button>
            </div>
            <div class=""col-md-4"">
                <button onclick=""posLineInsert()"" class=""btn btn-block btn-warning"">Insert</button>
            </div>
            <div class=""col-md-4"">
                <button class=""btn btn-block btn-danger"">Cancel</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(3764, 23, true);
                WriteLiteral("\n    <!--numpad-->\n    ");
                EndContext();
                BeginContext(3787, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c09483d2e4c14d49b98b3c04b9556565bdb903228489", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3858, 260, true);
                WriteLiteral(@"
    <!--numpad-->
    <style type=""text/css"">
        .nmpd-grid {
            border: none;
            padding: 20px;
            background: white;
        }

        .nmpd-grid > tbody > tr > td {
            border: none;
        }

       
    </style>
");
                EndContext();
            }
            );
            BeginContext(4120, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4138, 5670, true);
                WriteLiteral(@"
    <script>
        // These defaults will be applied to all NumPads within this document!
        $.fn.numpad.defaults.gridTpl = '<table class=""table modal-content""></table>';
        $.fn.numpad.defaults.backgroundTpl = '<div class=""modal-backdrop in""></div>';
        $.fn.numpad.defaults.displayTpl = '<input type=""text"" class=""form-control"" />';
        $.fn.numpad.defaults.buttonNumberTpl = '<button type=""button"" class=""btn btn-default""></button>';
        $.fn.numpad.defaults.buttonFunctionTpl = '<button type=""button"" class=""btn"" style=""width: 100%;""></button>';
        $.fn.numpad.defaults.onKeypadCreate = function () { $(this).find('.done').addClass('btn-primary'); };
        // jquery numpad

        $(document).ready(function () {
            //numpad
            $('#quantity').numpad();
            $('#price').numpad();
            $('#payment').numpad();

            //datatables
            initProductLine();
        });

        function initPosLine() {
            var salesOrderId = $(""#salesO");
                WriteLiteral(@"rderId"").val();

            $(""#posLine"").DataTable({
                ""destroy"": true,
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
                    { ""data"": ""total"" },
                    {
                        ""data"": ""salesOrderLineId"",
                        ""render"": function (data) {
                            var btnDelete = '<button onclick=""deleteLine(\'' + data + '\')"" class=""btn btn-danger"">DELETE</button>';
                            return btnDelete;
                        }
                    }
     ");
                WriteLiteral(@"           ],
                ""language"": {
                    ""emptyTable"": ""data is empty.""
                },
                ""lengthChange"": false,
                ""bFilter"": false,
                ""paging"": false,
                ""info"": false
            });

            return false;
        }

        function initProductLine() {

            $(""#productLine"").DataTable({
                ""ajax"": {
                    ""type"": ""GET"",
                    ""url"": ""/api/Product"",
                    ""dataSrc"": function (data) {
                        return data;
                    }
                },
                ""columns"": [
                    { ""data"": ""name"" },
                    { ""data"": ""priceSell"" },
                    { ""data"": ""pricePurchase"" },
                    {
                        ""data"": ""productId"",
                        ""render"": function (data) {
                            var btnSelect = '<button onclick=""selectProduct(\'' + data +'\')"" class=""btn btn-info"">Select</butt");
                WriteLiteral(@"on>';
                            return btnSelect;
                        }
                    }
                ],
                ""language"": {
                    ""emptyTable"": ""data is empty.""
                },
                ""lengthChange"": false,
                ""pageLength"": 5,
                ""bFilter"": false,
                ""paging"": true,
                ""info"": false
            });

            return false;
        }

        function selectProduct(productId) {
            var salesOrderNumber = $(""#orderNumber"").val();
            if (salesOrderNumber) {

                axios.get('/api/Product/' + productId
                )
                .then(function (response) {
                    $(""#productId"").val(response.data.productId);
                    $(""#product"").val(response.data.name);
                    $(""#price"").val(response.data.priceSell);
                    $(""#quantity"").val(1);
                    toastr.success(response.data.name + ' is selected.', 'Success')
            ");
                WriteLiteral(@"    })
                .catch(function (error) {

                })
                .then(function () {

                });

            } else {
                toastr.error('Order Number # empty. Please create new order first.', 'Error')
            }

            return false;
        }

        function initiateNewPOSOrder() {
            axios.post('/api/SalesOrder/InitiateNewPOSTrans'
            )
            .then(function (response) {
                $(""#orderNumber"").val(response.data.number);
                $(""#salesOrderId"").val(response.data.salesOrderId);
                initPosLine();
                toastr.success('New order created with number: ' + response.data.number, 'Success')
            })
            .catch(function (error) {

            })
            .then(function () {

            });
            return false;
        }

        function posLineInsert() {
            axios.post('/api/SalesOrderLine', {
                ""SalesOrderId"": $(""#salesOrderId"").val(),
                ""P");
                WriteLiteral(@"roductId"": $(""#productId"").val(),
                ""Quantity"": $(""#quantity"").val(),
                ""Price"": $(""#price"").val()
            })
            .then(function (response) {
                var product = $(""#product"").val();
                $(""#posLine"").DataTable().ajax.reload();
                toastr.success('Insert POS line success for item: ' + product, 'Success');
            })
            .catch(function (error) {

            })
            .then(function () {

            });
            return false;
        }

    </script>
");
                EndContext();
            }
            );
            BeginContext(9810, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
