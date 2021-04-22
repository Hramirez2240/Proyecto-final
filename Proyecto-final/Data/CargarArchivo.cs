using System;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Proyecto_final.Services;

namespace Proyecto_final.Data
{
    public class CargarArchivo : ICargarArchivo
    {

        private readonly IWebHostEnvironment oWebHostEnvironment;

        public CargarArchivo(IWebHostEnvironment oWebHostEnvironment)
        {
            this.oWebHostEnvironment = oWebHostEnvironment;
        }

        public async Task Cargar(IFileListEntry file)
        {
            var path = Path.Combine(oWebHostEnvironment.ContentRootPath, "wwwroot/imagenes", file.Name);
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);

            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}