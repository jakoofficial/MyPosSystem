using Microsoft.EntityFrameworkCore;
using MyPosSystem.Models;

namespace MyPosSystem;

public class DBContext : DbContext
{
    public DbSet<Order>? Orders { get; set; }
    public DbSet<Sale>? Sales { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Item>? Items { get; set; }
    
    public string DbPath { get; }
    public DBContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "Banking.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Server=JACOB;Database=ServerSideDB;User Id=Admin;Password=Admin;TrustServerCertificate=True");
}