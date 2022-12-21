using FTCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FTCRUD.Data
{
    public class CRUDDbContext : DbContext
    {
        public CRUDDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Campaign> Campaigns { get; set; }
    }
}
