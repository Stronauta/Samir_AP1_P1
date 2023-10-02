using Microsoft.EntityFrameworkCore;
using Samir_AP1_P1.Models;
using System.Security.Cryptography.X509Certificates;
namespace Samir_AP1_P1.DAL
{
    public class Context : DbContext
    {
        public DbSet<Aportes> Aportes { get; set; }
    public Context(DbContextOptions<Context> options):base(options) 
        {
            
        }
    }
}
