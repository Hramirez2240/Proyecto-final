#pragma checksum "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cafd175e4b6bd3e8f7b109841329f01bb0e8fac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Gestion_Clientes_Edit), @"mvc.1.0.razor-page", @"/Pages/Gestion-Clientes/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cafd175e4b6bd3e8f7b109841329f01bb0e8fac2", @"/Pages/Gestion-Clientes/Edit.cshtml")]
    public class Pages_Gestion_Clientes_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>GestionClientes</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""GestionClientes.Id"" />
            <div class=""form-group"">
                <label asp-for=""GestionClientes.Cedula"" class=""control-label""></label>
                <input asp-for=""GestionClientes.Cedula"" class=""form-control"" />
                <span asp-validation-for=""GestionClientes.Cedula"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GestionClientes.Nombre"" class=""control-label""></label>
                <input asp-for=""GestionClientes.Nombre"" class=""form-control"" />
                <span asp-validation-for=""GestionClientes.Nombre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GestionClientes.Apellido"" class=""c");
            WriteLiteral(@"ontrol-label""></label>
                <input asp-for=""GestionClientes.Apellido"" class=""form-control"" />
                <span asp-validation-for=""GestionClientes.Apellido"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GestionClientes.Correo"" class=""control-label""></label>
                <input asp-for=""GestionClientes.Correo"" class=""form-control"" />
                <span asp-validation-for=""GestionClientes.Correo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GestionClientes.Licencia"" class=""control-label""></label>
                <input asp-for=""GestionClientes.Licencia"" class=""form-control"" />
                <span asp-validation-for=""GestionClientes.Licencia"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GestionClientes.Nacionalidad"" class=""control-label""></label>
                <i");
            WriteLiteral(@"nput asp-for=""GestionClientes.Nacionalidad"" class=""form-control"" />
                <span asp-validation-for=""GestionClientes.Nacionalidad"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GestionClientes.TipSangre"" class=""control-label""></label>
                <input asp-for=""GestionClientes.TipSangre"" class=""form-control"" />
                <span asp-validation-for=""GestionClientes.TipSangre"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""GestionClientes.Habilitar"" /> ");
#nullable restore
#line 54 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Edit.cshtml"
                                                                                      Write(Html.DisplayNameFor(model => model.GestionClientes.Habilitar));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""GestionClientes.Ft1"" class=""control-label""></label>
                <input asp-for=""GestionClientes.Ft1"" class=""form-control"" />
                <span asp-validation-for=""GestionClientes.Ft1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GestionClientes.Ft2"" class=""control-label""></label>
                <input asp-for=""GestionClientes.Ft2"" class=""form-control"" />
                <span asp-validation-for=""GestionClientes.Ft2"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""./Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\dhima\Desktop\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyecto_final.Pages.Gestion_Clientes.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto_final.Pages.Gestion_Clientes.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto_final.Pages.Gestion_Clientes.EditModel>)PageContext?.ViewData;
        public Proyecto_final.Pages.Gestion_Clientes.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
