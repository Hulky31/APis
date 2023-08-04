using CadsatroFuncioanriosApi.Model;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CadsatroFuncioanriosApi.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        { 


        }
        public DbSet<ClienteModel> CompreBem { get; set; }
    }
}
