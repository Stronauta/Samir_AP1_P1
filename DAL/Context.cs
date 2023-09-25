using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Samir_AP1_P1.DAL
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) 
        {
            
        }
    }
}
