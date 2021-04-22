using System;
using System.Threading.Tasks;
using BlazorInputFile;

namespace Proyecto_final.Services
{
    public interface ICargarArchivo
    {
        Task Cargar(IFileListEntry file);
    }
}