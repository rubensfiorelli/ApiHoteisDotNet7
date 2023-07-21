using HoteisAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HoteisAPI.Data
{
    public class HospedeContext : DbContext
    {

        public HospedeContext(DbContextOptions<HospedeContext> opts) :base(opts)
        {
                        
        }

        public DbSet <Hospede> Hospedes { get; set; }
        public DbSet <Suite> Suites { get; set; }
        public DbSet <Endereco> Enderecos { get; set;}
        public DbSet <Hotel>  Hoteis { get; set; }
    }
}
