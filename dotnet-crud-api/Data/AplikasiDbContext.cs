using Microsoft.EntityFrameworkCore;
using dotnet_crud_api.Models.Entities;

namespace dotnet_crud_api.Data
{
    public class AplikasiDbContext : DbContext
    {
        public AplikasiDbContext(DbContextOptions<AplikasiDbContext> options) : base(options) { }
        public DbSet<Produk> Produk { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Awal (Seeding) untuk Kategori agar Foreign Key bisa diuji
            modelBuilder.Entity<Kategori>().HasData(
            new Kategori { Id = 1, Nama = "Elektronik" },
            new Kategori { Id = 2, Nama = "Pakaian" }
            );
        }
    }
}

