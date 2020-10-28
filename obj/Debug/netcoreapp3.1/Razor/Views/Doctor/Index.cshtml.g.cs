#pragma checksum "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7de40799a0c1c71fe75f8d8f641cb59b3b3d5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Index), @"mvc.1.0.view", @"/Views/Doctor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7de40799a0c1c71fe75f8d8f641cb59b3b3d5b", @"/Views/Doctor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb7939409e989001d98734c702361b623a08d69b", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/dt/dt-1.10.22/datatables.min.css"" />

<h1>Citas Pendientes</h1>

<table class=""table"" id=""tbtCitaDoctor"">
    <thead>
        <tr>
            <th>Fecha</th>
            <th>Paciente</th>
            <th>Horario</th>
            <th>Estado</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
         foreach (var item in ViewBag.Citas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
               Write(item.fecha.ToString("dd/mm/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
               Write(item.cliente.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
                                     Write(item.cliente.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
               Write(item.horario.horaInicio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 22 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
                                          Write(item.horario.horaFin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 25 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
                     if (item.estado == "true")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>Pendiente</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 895, 2);
            WriteAttributeValue("", 851, "/Doctor/Historial?idPaciente=", 851, 29, true);
#nullable restore
#line 28 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 880, item.idCliente, 880, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Atender Paciente</a>\r\n");
#nullable restore
#line 29 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
                     if (item.estado == "false")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>Atendido</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1086, "\"", 1136, 2);
            WriteAttributeValue("", 1093, "/Doctor/HistoriaClinica?idCita=", 1093, 31, true);
#nullable restore
#line 35 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 1124, item.idCita, 1124, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ver Historia Clinica</a>\r\n");
#nullable restore
#line 36 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                   \r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "D:\Dental\DentoWeb\Views\Doctor\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://cdn.datatables.net/v/dt/dt-1.10.22/datatables.min.js""></script>
    <script>
    $(document).ready(function () {
            $('#tbtCitaDoctor').DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/1.10.15/i18n/Spanish.json""
                }
            });
        });</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
