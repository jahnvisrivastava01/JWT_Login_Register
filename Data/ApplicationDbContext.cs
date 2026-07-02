using Microsoft.EntityFrameworkCore;
using JWT_Login_Register_API.Models;

namespace JWT_Login_Register_API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
}