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
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
using Proyecto_final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mapa-vehiculos")]
    public partial class Mapa_vehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
      

    int zoom = 3;
    string click = "";

    void OnMapClick(GoogleMapClickEventArgs args)
    {

        click = $"Map click lat: {args.Position.Lat} Lon: {args.Position.Lng}";
    }

    void OnMarkerClick(RadzenGoogleMapMarker args)
    {

        click = $"Map click provincia: {args.Title} lat: {args.Position.Lat} Lon: {args.Position.Lng}";
    }

    List<DataConsultaVehiculos> GetVehiculos() =>
    (
        from v in new db_a72daa_proyecContext().Vehiculos
        select new DataConsultaVehiculos
        {
            datos = " Marca: " + v.Marca + " ,Modelo: " + v.Modelo + " ,Año: " + v.Anio + " ,Color: " + v.Color,
            lat = v.Latitud,
            lon = v.Longitud
        }
    ).ToList();


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
