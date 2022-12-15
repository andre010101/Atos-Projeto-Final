using System.ComponentModel.DataAnnotations;

namespace Proje_Final_Atos.Models
{
    public class Livro
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Titulo do Livro")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Informe o SubTitulo do Livro")]
        public string SubTitulo { get; set; }
        [Required(ErrorMessage = "Informe o Autor do Livro")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Informe o Genero do Livro")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Informe o Idioma do Livro")]
        public string Idioma { get; set; }
        [Required(ErrorMessage = "Informe a Capa do Livro")]
        public string Capa { get; set; }
        [Required(ErrorMessage = "Informe a Resenha do Livro")]
        public string Resenha { get; set; }
    }
}
