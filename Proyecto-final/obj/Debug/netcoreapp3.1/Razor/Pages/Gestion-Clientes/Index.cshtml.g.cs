#pragma checksum "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c839830cadeb6ebf6b7cafc5d45d62f6037156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Gestion_Clientes_Index), @"mvc.1.0.razor-page", @"/Pages/Gestion-Clientes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c839830cadeb6ebf6b7cafc5d45d62f6037156", @"/Pages/Gestion-Clientes/Index.cshtml")]
    public class Pages_Gestion_Clientes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].Licencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].Nacionalidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].TipSangre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].Habilitar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].Ft1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GestionClientes[0].Ft2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
 foreach (var item in Model.GestionClientes) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Licencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nacionalidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipSangre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Habilitar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ft1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ft2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2570, "\"", 2593, 1);
#nullable restore
#line 83 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
WriteAttributeValue("", 2585, item.Id, 2585, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2646, "\"", 2669, 1);
#nullable restore
#line 84 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
WriteAttributeValue("", 2661, item.Id, 2661, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2724, "\"", 2747, 1);
#nullable restore
#line 85 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
WriteAttributeValue("", 2739, item.Id, 2739, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 88 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyecto_final.Pages.Gestion_Clientes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto_final.Pages.Gestion_Clientes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto_final.Pages.Gestion_Clientes.IndexModel>)PageContext?.ViewData;
        public Proyecto_final.Pages.Gestion_Clientes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
