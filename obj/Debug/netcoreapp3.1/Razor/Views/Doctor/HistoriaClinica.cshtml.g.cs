#pragma checksum "D:\Dental\DentoWeb\Views\Doctor\HistoriaClinica.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa648812b760e230daa331dd9dda2b511b3532fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_HistoriaClinica), @"mvc.1.0.view", @"/Views/Doctor/HistoriaClinica.cshtml")]
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
#line 1 "D:\Dental\DentoWeb\Views\_ViewImports.cshtml"
using ProyDentoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dental\DentoWeb\Views\_ViewImports.cshtml"
using ProyDentoWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa648812b760e230daa331dd9dda2b511b3532fc", @"/Views/Doctor/HistoriaClinica.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb7939409e989001d98734c702361b623a08d69b", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_HistoriaClinica : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Dental\DentoWeb\Views\Doctor\HistoriaClinica.cshtml"
  
    ViewData["Title"] = "HistoriaClinica";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
       
        <table class=""table"">
            <thead>
                <tr>
                    <th>Id Cliente</th>
                    <th>Id Historias </th>
                    <th>Id NumerHisotoria</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "D:\Dental\DentoWeb\Views\Doctor\HistoriaClinica.cshtml"
                 foreach (var item in ViewBag.History)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 22 "D:\Dental\DentoWeb\Views\Doctor\HistoriaClinica.cshtml"
                         foreach (var cliente in ViewBag.Clientes)
                    {
                        if (cliente.idCliente == item.idCliente)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 26 "D:\Dental\DentoWeb\Views\Doctor\HistoriaClinica.cshtml"
                              Write(cliente.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 27 "D:\Dental\DentoWeb\Views\Doctor\HistoriaClinica.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\Dental\DentoWeb\Views\Doctor\HistoriaClinica.cshtml"
                   Write(item.idHistorial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "D:\Dental\DentoWeb\Views\Doctor\HistoriaClinica.cshtml"
                   Write(item.numeroHistoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "D:\Dental\DentoWeb\Views\Doctor\HistoriaClinica.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
