using System.ComponentModel;

namespace Projeto_Final_Atos.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Idioma { get; set; }
        public string Autor { get; set; }
        public string capa { get; set; }
        
        public string FotoLivro { get; set; }
        
        public string Resenha { get; set; }
    }
}
