#pragma checksum "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\DetalleNota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1bebdc165c09a9dc27fbcc997de3a3c4dbbc718"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_DetalleNota), @"mvc.1.0.view", @"/Views/Blog/DetalleNota.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1bebdc165c09a9dc27fbcc997de3a3c4dbbc718", @"/Views/Blog/DetalleNota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2dfc294bf8d6131f460c8b716bd6e5797132710", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_DetalleNota : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table-bordered\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Titulo</th>\r\n        <th>Contenido</th>\r\n        <th>Fecha de la ultima modificacion</th>\r\n\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 10 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\DetalleNota.cshtml"
       Write(ViewBag.Nota.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 11 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\DetalleNota.cshtml"
       Write(ViewBag.Nota.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 12 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\DetalleNota.cshtml"
       Write(ViewBag.Nota.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\tony9\Desktop\ExamenFinal\ExamenFinal\Views\Blog\DetalleNota.cshtml"
       Write(ViewBag.Nota.UltimaModificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>");
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
