// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Proyecto_final.Pages.Gestion_Clientes
{
    #line hidden
    using System;
    using System.Collections.Generic;
#nullable restore
#line 2 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Agregar.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Agregar.razor"
using Proyecto_final.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Agregar.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Agregar.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Agregar.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Agregar.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Agregar-cli")]
    public partial class Agregar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 164 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Proyecto-final\Proyecto-final\Pages\Gestion-Clientes\Agregar.razor"
      
    Data.DatosCedula dc = new Data.DatosCedula();
    IFileListEntry file;

    async Task HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();

        if (file != null)
        {
            await cargarArchivo.Cargar(file);
        }
    }

    string cedula = "", Apellido = "", nombre = "", correo = "", licencia = "";
    string nacionalidad = "", sangre = "", ft1 = "", ft2 = "";



    int mensaje = 0;

    public List<Cliente> lista_cliente = new List<Cliente>();
    public List<Cliente> GetCliente() => new db_a72daa_proyecContext().Cliente.ToList();

    public void AgregarCliente()
    {
        using (db_a72daa_proyecContext context = new db_a72daa_proyecContext())
        {
            Cliente ve = new Cliente();
            ve.Cedula = cedula;
            ve.Nombre = nombre;
            ve.Apellido = Apellido;
            ve.Nacionalidad = nacionalidad;
            ve.Correo = correo;
            ve.Sangre = sangre;
            ve.Licencia = licencia;
            ve.Ft1 = ft1;
            ve.Ft2 = file.Name;


            context.Add(ve);
            context.SaveChanges();
        }

        mensaje = 1;
    }
    public void buscar()
    {
        var Cd = dc.Datos(cedula);
        nombre = Cd.Nombres;
        Apellido = Cd.Apellido1;
        ft1 = Cd.foto;

    }
    public void Editar(int id)
    {
        using (db_a72daa_proyecContext contexto = new db_a72daa_proyecContext())
        {
            var datos = contexto.Cliente.Find(id);
            cedula = datos.Cedula;
            nombre = datos.Nombre;
            Apellido = datos.Apellido;
            licencia = datos.Licencia;
            nacionalidad = datos.Nacionalidad;
            correo = datos.Correo;
            sangre = datos.Sangre;



        }
    }
    public void GuardarCambios()
    {
        using (db_a72daa_proyecContext context = new db_a72daa_proyecContext())
        {
            Cliente ve = context.Cliente
            .Where(e => e.Cedula == cedula).FirstOrDefault();

            ve.Cedula = cedula;
            ve.Nombre = nombre;
            ve.Apellido = Apellido;
            ve.Nacionalidad = nacionalidad;
            ve.Correo = correo;
            ve.Sangre = sangre;
            ve.Licencia = licencia;


            context.SaveChanges();
        }

        Limpiar();
        mensaje = 1;
    }


    protected override void OnInitialized()
    {
        lista_cliente = GetCliente();
    }

    public void Limpiar()
    {
        cedula = "";
        Apellido = "";
        nombre = "";
        correo = "";
        licencia = "";
        nacionalidad = "";
        sangre = "";
        ft1 = "";
        ft2 = "";

    }


    public void Deshabilitar(int id)
    {
        using (db_a72daa_proyecContext context = new db_a72daa_proyecContext())
        {
            var des = context.Cliente.Find(id);
            des.Habilitar = "No disponible";

            context.SaveChanges();

            Recargar();
        }

    }
    public void Cerrar()
    {
        Recargar();
    }

    public void Recargar()
    {
        NavigationManager.NavigateTo("/Agregar-cli", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICargarArchivo cargarArchivo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
