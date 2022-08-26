using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace InfoCelEletronic.Models
{
    public class infoceleletronicContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseMySql("Server=localhost;Database=infoceleletronic2;Uid=root;");
        }

       
        public DbSet<cliente> clientedb{get; set;}
        public DbSet<servicos> servicosdb{get; set;}
     

        
    }
}