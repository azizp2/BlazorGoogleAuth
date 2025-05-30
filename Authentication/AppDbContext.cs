using BlazorAuthGoogle.Authentications;
using Microsoft.EntityFrameworkCore;

namespace BlazorAuthGoogle.Authentication
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<AppUser> GoogleUsers { get; set; }
    }

    
}
