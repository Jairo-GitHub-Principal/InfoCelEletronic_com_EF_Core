#pragma checksum "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0773d55175a6893c783c029102313832a2d242dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_cliente_ListarCliente), @"mvc.1.0.view", @"/Views/cliente/ListarCliente.cshtml")]
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
#line 1 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\_ViewImports.cshtml"
using InfoCelEletronic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\_ViewImports.cshtml"
using InfoCelEletronic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0773d55175a6893c783c029102313832a2d242dc", @"/Views/cliente/ListarCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7915925dee8c3d03074ae928e84600fc7154a946", @"/Views/_ViewImports.cshtml")]
    public class Views_cliente_ListarCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
   
   
<div class=""row "">
    <div class=""col-12"">
        <table class=""table pt-5 "">
            
            
            <thead class=""text-warning "">
                <tr>
                <th>ID</th>    
                <th>Nome</th>
                <th>Nome de usuario</th>
                <th>Senha</th>
                </tr>
            </thead>
                        <tbody class=""text-light "">
");
#nullable restore
#line 20 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml"
                             foreach (cliente item in Model)
                            {                        
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml"
                           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml"
                           Write(item.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml"
                           Write(item.nomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml"
                           Write(item.senha);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                           

                            <td>
                                <!-- controle de acesso com previlegios diferenciado para o clliente e o usuario Adm-->

                                  

                                        
                                                <a");
            BeginWriteAttribute("href", " href=\"", 1182, "\"", 1213, 2);
            WriteAttributeValue("", 1189, "excluirClirente/", 1189, 16, true);
#nullable restore
#line 36 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml"
WriteAttributeValue("", 1205, item.id, 1205, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1278, "\"", 1310, 2);
            WriteAttributeValue("", 1285, "AtualizarCliente/", 1285, 17, true);
#nullable restore
#line 37 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml"
WriteAttributeValue("", 1302, item.id, 1302, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Alterar</a>
                                            

                                            
                                    
                                    
                                        </td>
                            </tr>
");
#nullable restore
#line 45 "C:\Users\jairo\Desktop\PiUC08_EntityFramework\InfoCelEletronic\Views\cliente\ListarCliente.cshtml"
                            
                        
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0773d55175a6893c783c029102313832a2d242dc7998", async() => {
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
            WriteLiteral("\r\n\r\n    \r\n\r\n\r\n</table>\r\n        \r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
