namespace ISNP144626_William_Trejo.Models
{
    public class Videojuego
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string ImagenUrl { get; set; } // Nueva propiedad para la portada
    }
}