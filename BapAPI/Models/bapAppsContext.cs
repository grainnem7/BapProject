using Microsoft.EntityFrameworkCore;
#nullable disable

namespace BapProject.Models
{
    public partial class bapAppsContext : DbContext
    {
        public bapAppsContext()
        {
        }
        public bapAppsContext(DbContextOptions<bapAppsContext> options)
            : base(options)
        {
        }
        public virtual DbSet<BapApp> BapApps { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BapApp>(entity =>
            {
                entity.HasKey(e => e.AppId);
                entity.ToTable("bapApps");
                entity.Property(e => e.AppId).HasColumnName("AppID");
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
