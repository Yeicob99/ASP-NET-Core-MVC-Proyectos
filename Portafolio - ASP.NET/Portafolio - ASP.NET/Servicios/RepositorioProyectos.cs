using Portafolio___ASP.NET.Models;

namespace Portafolio___ASP.NET.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO
                {
                    Titulo = "Amazon",
                    Descripcion = "Clon de Amazon hecho en ASP.NET Core y Blazor",
                    Link = "https://www.amazon.com/",
                    ImagenUrl = "/img/amazon.png"
                },
                new ProyectoDTO
                {
                    Titulo = "New York Times",
                    Descripcion = "Pagina de noticias en React",
                    Link = "https://www.nytimes.com/",
                    ImagenUrl = "/img/nyt.png"
                },
                new ProyectoDTO
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://www.reddit.com/",
                    ImagenUrl = "/img/reddit.png"
                },
                new ProyectoDTO
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea para comprar videojuegos",
                    Link = "https://store.steampowered.com/",
                    ImagenUrl = "/img/steam.png"
                },
            };
        }


    }
}
