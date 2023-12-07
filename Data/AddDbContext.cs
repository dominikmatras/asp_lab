using System.Runtime.InteropServices.JavaScript;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AddDbContext : DbContext
{
  public DbSet<PhotoEntity> Photos { get; set; } 
  private string DbPath { get; set; }

  public AddDbContext()
  {
    var folder = Environment.SpecialFolder.LocalApplicationData; 
    var path = Environment.GetFolderPath(folder); 
    DbPath = System.IO.Path.Join(path, "photosDb.db"); 
  }
  protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<PhotoEntity>().HasData(
      new PhotoEntity()
      {
        Id = 1, Date = DateTime.Now, Description = "Opis zdjęcia 1", Camera = "Aparat 1", Author = "Autor 1",
        Resolution = "1920x1080", AspectRatio = "16:9", Priority = 1
      },
      new PhotoEntity()
      {
        Id = 2, Date = DateTime.Now, Description = "Opis zdjęcia 2", Camera = "Aparat 2", Author = "Autor 2",
        Resolution = "1920x1080", AspectRatio = "16:9", Priority = 2
      }
    );
  }
}