using Kiemtra90.Model;
using Microsoft.EntityFrameworkCore;

namespace Kiemtra90
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Nhomhanghoa> Nhomhanghoa { get; set; }
        public DbSet<Hanghoa> Hanghoa { get; set; }
    }
}
