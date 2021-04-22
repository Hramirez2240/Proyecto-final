using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto_final.Models
{
    public partial class GestionClientes
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Licencia { get; set; }
        public string Nacionalidad { get; set; }
        public string TipSangre { get; set; }
        public bool Habilitar { get; set; }
        public byte[] Ft1 { get; set; }
        public byte[] Ft2 { get; set; }
    }
}
