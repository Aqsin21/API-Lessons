using Microsoft.EntityFrameworkCore;
using StudentCrud.DataContext.Entities;

namespace StudentCrud.DataContext
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }
       
        public DbSet<Student> Students { get; set; }
    }
}
