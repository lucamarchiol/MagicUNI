using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using MagicUNI.Models;

namespace MagicUNI
{
    public class MagicContext : DbContext
    {
        private static string _connectionString;
        public MagicContext(DbContextOptions<MagicContext> options) : base(options)
        {

        }
        public DbSet<Studente> Studenti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                LoadConnectionString();
            }

            optionsBuilder.UseSqlServer(_connectionString);
        }

        private static void LoadConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                ;

            var configuration = builder.Build();
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
    }
}