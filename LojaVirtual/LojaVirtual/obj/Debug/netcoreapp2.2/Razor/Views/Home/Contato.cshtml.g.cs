#pragma checksum "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf035dcf6f22a9242ba8d4ee6d9482c41020e10a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contato.cshtml", typeof(AspNetCore.Views_Home_Contato))]
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
#line 3 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf035dcf6f22a9242ba8d4ee6d9482c41020e10a", @"/Views/Home/Contato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8e441a1ad085f94e3a56d46d99a0c2d222558b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/ContatoAcao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
  
    ViewData["Title"] = "Contato";
    LojaVirtual.Models.Contato contato = (LojaVirtual.Models.Contato)ViewData["CONTATO"];

#line default
#line hidden
            BeginContext(134, 1271, true);
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <div class=""container"">
        <div class=""row"">
            <aside class=""col-md-6"">
                <h4 class=""subtitle-doc"">
                    # Outros contatos
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Devolução/Garantia: </dt>
                            <dd>devolucao@lojavirtual.com.br</dd>
                        </dl>
                        <dl>
                            <dt>Televendas: </dt>
                            <dd>(61) 4000-2000</dd>
                        </dl>
                        <dl>
                            <dt>SAC:</dt>
                            <dd>sac@lojavirtual.com.br</dd>
                        </dl>
                    </div> 
                </div> 
            </aside>
            ");
            WriteLiteral("<aside class=\"col-sm-6\">\r\n\r\n                <h4 class=\"subtitle-doc\">\r\n                    # Contato\r\n                </h4>\r\n                <div>\r\n\r\n                    <article class=\"card\">\r\n                        <div class=\"card-body p-5\">\r\n");
            EndContext();
#line 42 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_S"] != null)
                            {

#line default
#line hidden
            BeginContext(1497, 63, true);
            WriteLiteral("                                <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(1561, 17, false);
#line 44 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                          Write(ViewData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(1578, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 45 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
#line 46 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_E"] != null)
                            {

#line default
#line hidden
            BeginContext(1707, 62, true);
            WriteLiteral("                                <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(1770, 27, false);
#line 48 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                         Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 49 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
            BeginContext(1834, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1862, 2375, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf035dcf6f22a9242ba8d4ee6d9482c41020e10a8890", async() => {
                BeginContext(1921, 555, true);
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label for=""nome"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" id=""nome"" class=""form-control"" name=""nome"" placeholder=""Digite seu nome""");
                EndContext();
                BeginWriteAttribute("required", "\r\n                                               required=\"", 2476, "\"", 2535, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2536, "\"", 2582, 1);
#line 58 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
WriteAttributeValue("", 2544, contato != null ? contato.Nome : "", 2544, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2583, 646, true);
                WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label for=""email"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" name=""email"" id=""email"" placeholder=""Digite seu email""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3229, "\"", 3276, 1);
#line 68 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
WriteAttributeValue("", 3237, contato != null ? contato.Email : "", 3237, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3277, 570, true);
                WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label for=""texto""><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" name=""texto"" id=""texto"" style=""width:100%"">");
                EndContext();
                BeginContext(3849, 36, false);
#line 77 "C:\Users\PAULO HENRIQUE\Documents\Visual Studio 2019\Asp.NetCoreMvcLojaVirtual\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                                                                                      Write(contato != null ? contato.Texto : "");

#line default
#line hidden
                EndContext();
                BeginContext(3886, 344, true);
                WriteLiteral(@"</textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4237, 157, true);
            WriteLiteral("\r\n                        </div> \r\n                    </article> \r\n\r\n                </div>\r\n\r\n            </aside>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
