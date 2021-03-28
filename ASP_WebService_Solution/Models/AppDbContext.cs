using Microsoft.EntityFrameworkCore;
namespace ASP_WebService_Solution.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<UserModel> UserMaster { get; set; }
    }
}