#pragma checksum "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5e57bf9887b937dabadd2154b7c702144d3665"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<div class=\"container\">\r\n    <h1 style=\"text-align: center;  height: 65px\" class=\"mt-2 col-md-12 mb-1 pt-2\">Mostrar mapa de vehiculos</h1>\r\n</div>\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(1);
            __builder.AddAttribute(2, "Style", "height: 800px;");
            __builder.AddAttribute(3, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
                                               zoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 9 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
                                                               new GoogleMapPosition() { Lat = 18.735693, Lng = -70.162651}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
                                                                                                                                         OnMapClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "MarkerClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenGoogleMapMarker>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenGoogleMapMarker>(this, 
#nullable restore
#line 9 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
                                                                                                                                                                  OnMarkerClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n");
#nullable restore
#line 11 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
         foreach (var vehi in GetVehiculos())
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, "            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(10);
                __builder2.AddAttribute(11, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
                                           vehi.datos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 13 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
                                                                   new GoogleMapPosition() { Lat = Convert.ToDouble(vehi.lat), Lng = Convert.ToDouble(vehi.lon)}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n");
#nullable restore
#line 14 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(14, "    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\User\Desktop\Programacion 3\Proyecto-final\Proyecto-final\Pages\Gestion-Reporte\Mapa-vehiculos.razor"
      

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
            datos = " Marca: " + v.Marca + " ,Modelo: " + v.Modelo + " ,A??o: " + v.Anio + " ,Color: " + v.Color,
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
