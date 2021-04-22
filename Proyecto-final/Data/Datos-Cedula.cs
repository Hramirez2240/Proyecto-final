using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Proyecto_final.Data
{
    public class DatosCedula
    {
        public Root Datos(string cedula)
        {
            WebClient web = new WebClient();

            var url = "https://api.adamix.net/apec/cedula/" + cedula;
            var datos = web.DownloadString(url);
            var convertidor = JsonConvert.DeserializeObject<Root>(datos);
            return convertidor;
        }
    }
}