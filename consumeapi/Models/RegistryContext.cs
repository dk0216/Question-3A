using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace consumeapi.Models
{
    public class RegistryContext : DbContext
    {
        public RegistryContext(DbContextOptions<RegistryContext> options)
            : base(options)
        {
        }

        public DbSet<Registry> Registries { get; set; } = null!;
    }
}