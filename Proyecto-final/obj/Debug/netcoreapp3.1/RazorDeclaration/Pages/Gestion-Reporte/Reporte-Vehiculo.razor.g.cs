// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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