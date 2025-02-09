using CRUD_SegurosMVC.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUD_SegurosMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Poliza> Polizas { get; set; }
    }
}
