#pragma checksum "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1ee7083ed9544ce30dad8d5f49b3c40fd46970d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teste_ListArma), @"mvc.1.0.view", @"/Views/Teste/ListArma.cshtml")]
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
#line 1 "C:\Users\wende\Documents\aprender cs\Views\_ViewImports.cshtml"
using aprender_cs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wende\Documents\aprender cs\Views\_ViewImports.cshtml"
using aprender_cs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ee7083ed9544ce30dad8d5f49b3c40fd46970d", @"/Views/Teste/ListArma.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75dcd725729dfd2eff6639070bead40193b41e5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Teste_ListArma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Arma>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadArma", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml"
  
    ViewData["Title"] = "Teste Controller";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Armas</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1ee7083ed9544ce30dad8d5f49b3c40fd46970d3912", async() => {
                WriteLiteral("Cadastrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml"
 if(TempData["CadSucess"] != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n  Cadastro realizado com sucesso\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped table-bordered\">\r\n    <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th class=\"text-center\">");
#nullable restore
#line 17 "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml"
                                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
            </tr>
            <tr>
                 <td>
                     <table class=""table table-striped table-bordered"">
                        <thead class=""text-center"">
                            <tr>
                                <td>Model</td>
                            </tr>    
                        </thead>
                        <tbody>
");
#nullable restore
#line 28 "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml"
                             foreach (var Heroi in @item.Heroi)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 31 "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml"
                                                       Write(Heroi.ArmaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                 </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\wende\Documents\aprender cs\Views\Teste\ListArma.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Arma>> Html { get; private set; }
    }
}
#pragma warning restore 1591
