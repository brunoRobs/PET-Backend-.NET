using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SegundoProjetoPet.Models;

namespace SegundoProjetoPet.Repositories
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Config;

        public DataContext(IConfiguration config)
        {
            Config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            var connectionString = Config.GetConnectionString("WebApiDatabase");
            opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected DbSet<Client>? Client { get; set; }

        protected DbSet<Employee>? Employee { get; set; }

        protected DbSet<Manager>? Manager { get; set; }
    }
}