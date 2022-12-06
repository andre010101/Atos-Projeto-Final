using Microsoft.EntityFrameworkCore;

namespace Projeto_Final_Atos.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet <Livro> livros { get; set; }
    }
}
