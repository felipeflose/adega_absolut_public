#pragma checksum "/Users/felipeflose/Documents/Uninove-Faculdade/20-03/Projeto/Adega/adega_absolut/Views/Vendas/old_Index copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1eedb1c5bd43531de93b2cd3eeb9f071319baf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendas_old_Index_copy), @"mvc.1.0.view", @"/Views/Vendas/old_Index copy.cshtml")]
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
#line 1 "/Users/felipeflose/Documents/Uninove-Faculdade/20-03/Projeto/Adega/adega_absolut/Views/_ViewImports.cshtml"
using AppWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/felipeflose/Documents/Uninove-Faculdade/20-03/Projeto/Adega/adega_absolut/Views/_ViewImports.cshtml"
using AppWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1eedb1c5bd43531de93b2cd3eeb9f071319baf9", @"/Views/Vendas/old_Index copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a45b59a216ede8d1c1f849b2aeca0bec0c5365", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendas_old_Index_copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppWeb.Models.VendasViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/felipeflose/Documents/Uninove-Faculdade/20-03/Projeto/Adega/adega_absolut/Views/Vendas/old_Index copy.cshtml"
  
    ViewData["Title"] = "Finalizar pedidos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
<h2 class=""text-center"">Finalizar pedido</h2>

  <div>
    <br/>
  </div>

  <!-- #region começo Collapse-->  
  <div id=""accordion"">
    <div class=""card"">
      <div class=""card-header"">
        <a class=""card-link"" data-toggle=""collapse"" href=""#collapseOne"">
          Forma de pagamento
        </a>
      </div>
      <div id=""collapseOne"" class=""collapse show"" data-parent=""#accordion"">
        <div class=""card-body"">

            <div class=""container"">
            <button type=""button"" class=""btn btn-info btn-lg"" data-toggle=""collapse"" data-target=""#demo"">Cartão de crédito</button>
            <div id=""demo"" class=""collapse"">
                <hr />
                
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1eedb1c5bd43531de93b2cd3eeb9f071319baf94335", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col"">
                            <input type=""text"" class=""form-control"" placeholder=""N° do cartão"">
                        </div>
                        <div class=""col"">
                            <input type=""text"" class=""form-control"" placeholder=""CVV"">
                        </div>
                    </div>

                    <hr />

                    <div class=""row"">
                        <div class=""col"">
                            <input type=""text"" class=""form-control"" placeholder=""Nome impresso no cartão"">
                        </div>
                        <div class=""col"">
                            <input type=""text"" class=""form-control"" placeholder=""Endereço da fatura"">
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                <hr/>

            </div>
        </div>
        
        <hr/>

            <div>
                
                <div class=""container"">
                    <button type=""button"" class=""btn btn-info btn-lg"" data-toggle=""collapse"" data-target=""#demo2"">Cartão de debito</button>
                    <div id=""demo2"" class=""collapse"">
                        <hr />
                    
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1eedb1c5bd43531de93b2cd3eeb9f071319baf96914", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col"">
                                <input type=""text"" class=""form-control"" placeholder=""N° do cartão"">
                            </div>
                            <div class=""col"">
                                <input type=""text"" class=""form-control"" placeholder=""CVV"">
                            </div>
                        </div>
                <hr/>
                        
                        <div class=""row"">
                            <div class=""col"">
                                <input type=""text"" class=""form-control"" placeholder=""Nome impresso no cartão"">
                            </div>
                            <div class=""col"">
                                <input type=""text"" class=""form-control"" placeholder=""Endereço da fatura"">
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                </div>
            </div>

        </div>
      </div>
    </div>

    <div class=""card"">
      <div class=""card-header"">
        <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseTwo"">
        Data da compra
      </a>
      </div>
      <div id=""collapseTwo"" class=""collapse"" data-parent=""#accordion"">
        <div class=""card-body"">
            ");
#nullable restore
#line 102 "/Users/felipeflose/Documents/Uninove-Faculdade/20-03/Projeto/Adega/adega_absolut/Views/Vendas/old_Index copy.cshtml"
       Write(DateTime.Now.ToString("HH:mm dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
      </div>
    </div>

    <div class=""card"">
      <div class=""card-header"">
        <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseThree"">
            Itens pedidos
        </a>
      </div>
      <div id=""collapseThree"" class=""collapse"" data-parent=""#accordion"">
        <div class=""card-body"">
         <table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">Quantidade</th>
            <th scope=""col"">Itens</th>
            <th scope=""col"">Valor unitário</th>
            <th scope=""col"">Valor total</th>
        </tr>
    </thead>
");
            WriteLiteral(@"    </table>
        </div>
      </div>
    </div>

    <div class=""card"">
      <div class=""card-header"">
        <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseFour"">
        Total
      </a>
      </div>
      <div id=""collapseFour"" class=""collapse"" data-parent=""#accordion"">
        <div class=""card-body"">
          R$ 000,00
        </div>
      </div>
    </div>

  </div>
</div>
<!-- #region final Collapse--> 

<div>
  <br/>
</div>
 
<!-- #region Botão finalizar compra-->    
<div class=""form-group"">
     <input type=""submit"" value=""Finalizar"" class=""btn btn-info btn-lg botao-finalizar"" />
</div>
<!-- #region -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppWeb.Models.VendasViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591