using Microsoft.Build.Framework;

namespace Proje_Final_Atos.Models
{
    public class Livro
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Idioma { get; set; }
        public string Capa { get; set; }
        public string Resenha { get; set; }
    }
}
