#pragma checksum "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e99480a797d227ac73d43ab4ac0ab860a24ee7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog__Index), @"mvc.1.0.view", @"/Views/Blog/_Index.cshtml")]
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
#line 1 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\_ViewImports.cshtml"
using ExamenFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\_ViewImports.cshtml"
using ExamenFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e99480a797d227ac73d43ab4ac0ab860a24ee7e", @"/Views/Blog/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2dfc294bf8d6131f460c8b716bd6e5797132710", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #0c002e"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e99480a797d227ac73d43ab4ac0ab860a24ee7e4667", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e99480a797d227ac73d43ab4ac0ab860a24ee7e4929", async() => {
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
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e99480a797d227ac73d43ab4ac0ab860a24ee7e6819", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-7\">\r\n");
#nullable restore
#line 15 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
             foreach (var item in @Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div style=\"background-color: #adb5bd\" class=\"card\">\r\n                    <h3 class=\"card-header\">\r\n                        <a style=\"color: #0b2e13\"");
                BeginWriteAttribute("href", " href=\"", 490, "\"", 530, 2);
                WriteAttributeValue("", 497, "/Blog/DetalleNota?IdNota=", 497, 25, true);
#nullable restore
#line 19 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
WriteAttributeValue("", 522, item.Id, 522, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p style=\"font-family:Arial, Helvetica, sans-serif;\">\r\n                                ");
#nullable restore
#line 21 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
                           Write(item.Titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </p>\r\n                        </a>\r\n                    </h3>\r\n                    <h5>\r\n                        ");
#nullable restore
#line 26 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
                   Write(ViewBag.resumen[@item.Id]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br /> <a");
                BeginWriteAttribute("href", " href=\"", 840, "\"", 879, 2);
                WriteAttributeValue("", 847, "/Blog/EditarNota?IdNota=", 847, 24, true);
#nullable restore
#line 26 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
WriteAttributeValue("", 871, item.Id, 871, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Editar</a> | <a");
                BeginWriteAttribute("onclick", " onclick=\"", 896, "\"", 953, 3);
                WriteAttributeValue("", 906, "eliminar(\'/Blog/EliminarNotra?IdNota=", 906, 37, true);
#nullable restore
#line 26 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
WriteAttributeValue("", 943, item.Id, 943, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 951, "\')", 951, 2, true);
                EndWriteAttribute();
                WriteLiteral(" href=\"#\">eliminar</a>  \r\n                    </h5>\r\n\r\n\r\n                    <div class=\"card-body\">\r\n");
#nullable restore
#line 31 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
                         foreach (var details in ViewBag.detalles)
                        {
                            if (details.IdNota == item.Id)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-3\">\r\n                                    <span style=\"color: #0b2e13 \" class=\"badge badge-success\">\r\n");
#nullable restore
#line 37 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
                                         foreach (var item1 in @ViewBag.etiquetas)
                                        {
                                            if (details.IdEtiqueta == item1.Id)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
                                           Write(item1.Nombre);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
                                                             
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </span>
                                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-tag-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                        <path fill-rule=""evenodd"" d=""M2 1a1 1 0 0 0-1 1v4.586a1 1 0 0 0 .293.707l7 7a1 1 0 0 0 1.414 0l4.586-4.586a1 1 0 0 0 0-1.414l-7-7A1 1 0 0 0 6.586 1H2zm4 3.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0z"" />
                                    </svg>
                                </div>
");
#nullable restore
#line 49 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 53 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\_Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    function eliminar(a) {\r\n\r\n        var url = a;\r\n\r\n        $.get(url, function (respuesta) {\r\n\r\n            $(\"#contenedor\").html(respuesta);\r\n        });\r\n        e.preventDefault();\r\n\r\n    }\r\n\r\n</script>\r\n\r\n</html>");
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
