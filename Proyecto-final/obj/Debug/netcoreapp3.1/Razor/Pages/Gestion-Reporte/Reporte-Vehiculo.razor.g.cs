#pragma checksum "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb85c22878d686d26d5bf92b966a464b0f58fcb8"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto_final.Pages.Gestion_Reporte
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
using Proyecto_final.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/prueba")]
    public partial class Reporte_Vehiculo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-striped");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<thead>\r\n        <tr>\r\n            <th>Marca</th>\r\n            <th>Modelo</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 16 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
         if (lista_vehiculos != null)
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
 foreach (var item in lista_vehiculos)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 21 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
         item.Marca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 22 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
         item.Modelo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\One Piece\Documents\Final1\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Reporte-Vehiculo.razor"
       List<Vehiculos> lista_vehiculos = new List<Vehiculos>();

            public List<Vehiculos> GetVehiculos() => new db_a72daa_proyecContext().Vehiculos.ToList();

            protected override void OnInitialized()
            {
                lista_vehiculos = GetVehiculos();
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICargarArchivo cargarArchivo { get; set; }
    }
}
#pragma warning restore 1591