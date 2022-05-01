using System.Diagnostics.CodeAnalysis;
using Era_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Era_Commerce.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
}