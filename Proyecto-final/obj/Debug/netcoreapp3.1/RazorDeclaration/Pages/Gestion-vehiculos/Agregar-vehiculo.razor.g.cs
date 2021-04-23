// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Proyecto_final.Pages.Gestion_vehiculos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-vehiculos\Agregar-vehiculo.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-vehiculos\Agregar-vehiculo.razor"
using Proyecto_final.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-vehiculos\Agregar-vehiculo.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/agregar-vehiculo")]
    public partial class Agregar_vehiculo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 160 "c:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-vehiculos\Agregar-vehiculo.razor"
          

        IFileListEntry file;

        async Task HandleFileSelected(IFileListEntry[] files)
        {
            file = files.FirstOrDefault();

            if (file != null)
            {
                await cargarArchivo.Cargar(file);
            }
        }

        string marca = "", modelo = "", anio = "", color = "", precio_dia = "";
        string tipo = "", capacidad = "", pasajeros = "", matricula = "", num_seguro = "";
        string foto = "", latitud = "", longitud = "";

        int mensaje = 0;

        public List<Vehiculos> lista_vehiculos = new List<Vehiculos>();
        public List<Vehiculos> GetVehiculos() => new db_a72daa_proyecContext().Vehiculos.OrderByDescending(ee => ee.Id).ToList();

        public void AgregarVehiculo()
        {
            using (db_a72daa_proyecContext context = new db_a72daa_proyecContext())
            {
                Vehiculos ve = new Vehiculos();
                ve.Marca = marca;
                ve.Modelo = modelo;
                ve.Anio = anio;
                ve.Color = color;
                ve.PrecioDia = precio_dia;
                ve.Tipo = tipo;
                ve.Capacidad = capacidad;
                ve.Pasajeros = pasajeros;
                ve.Matricula = matricula;
                ve.NumSeguro = num_seguro;
                ve.Foto = file.Name;
                ve.Latitud = latitud;
                ve.Longitud = longitud;

                context.Add(ve);
                context.SaveChanges();
            }

            Limpiar();
            mensaje = 1;
        }

        public void Editar(int id)
        {
            using (db_a72daa_proyecContext contexto = new db_a72daa_proyecContext())
            {
                var datos = contexto.Vehiculos.Find(id);
                marca = datos.Marca;
                modelo = datos.Modelo;
                anio = datos.Anio;
                color = datos.Color;
                precio_dia = datos.PrecioDia;
                tipo = datos.Tipo;
                capacidad = datos.Capacidad;
                pasajeros = datos.Pasajeros;
                matricula = datos.Matricula;
                num_seguro = datos.NumSeguro;
                foto = datos.Foto;
                latitud = datos.Latitud;
                longitud = datos.Longitud;
            }
        }

        protected override void OnInitialized()
        {
            lista_vehiculos = GetVehiculos();
        }

        public void Limpiar()
        {
            marca = "";
            modelo = "";
            anio = "";
            color = "";
            precio_dia = "";
            tipo = "";
            capacidad = "";
            pasajeros = "";
            matricula = "";
            num_seguro = "";
            foto = "";
            latitud = "";
            longitud = "";

        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICargarArchivo cargarArchivo { get; set; }
    }
}
#pragma warning restore 1591
