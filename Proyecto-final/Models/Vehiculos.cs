using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto_final.Models
{
    public partial class Vehiculos
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public string Color { get; set; }
        public string PrecioDia { get; set; }
        public string Tipo { get; set; }
        public string Capacidad { get; set; }
        public string Pasajeros { get; set; }
        public string Matricula { get; set; }
        public string NumSeguro { get; set; }
        public string Foto { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
    }
}
