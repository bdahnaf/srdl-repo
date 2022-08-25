using Microsoft.EntityFrameworkCore;
using srdl_repo.Models;

namespace srdl_repo.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Division> Divisions { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Upazila> Upazilas { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
