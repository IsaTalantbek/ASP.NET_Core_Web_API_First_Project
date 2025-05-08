using Microsoft.EntityFrameworkCore;
using API_Project.Entities;

namespace API_Project.Data;

public class ProjectDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
        : base(options)
    {
    }
}