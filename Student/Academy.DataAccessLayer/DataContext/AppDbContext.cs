using Academy.DataAccessLayer.DataContext.Entities;
using Microsoft.EntityFrameworkCore;
namespace Academy.DataAccessLayer.DataContext
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}
        public DbSet<Student > Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }
        

       
    }
}
