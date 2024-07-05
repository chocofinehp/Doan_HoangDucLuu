using Microsoft.EntityFrameworkCore;
namespace DoAn_HoangDucLuu.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");
                entity.Property(e => e.IDSP).HasColumnName("IDSP");
                entity.Property(e => e.TenSP).IsRequired().HasMaxLength(500);
                entity.Property(e => e.LoaiSP).IsRequired().HasMaxLength(500);
                entity.Property(e => e.GiaSP).IsRequired();
                entity.Property(e => e.NgayNhap).HasColumnType("date");
                entity.Property(e => e.SoLuong).IsRequired();
                entity.Property(e => e.MoTa).HasColumnType("ntext");
            });
        }
    }
}