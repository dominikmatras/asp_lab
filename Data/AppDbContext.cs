using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AppDbContext : DbContext
{
  public DbSet<PhotoEntity> Photos { get; set; } 
  public DbSet<OrganizationEntity> Organizations { get; set; }
  private string DbPath { get; set; }

  public AppDbContext()
  {
    var folder = Environment.SpecialFolder.LocalApplicationData; 
    var path = Environment.GetFolderPath(folder); 
    DbPath = System.IO.Path.Join(path, "photos.db");
    Console.WriteLine($"Link do bazy: {DbPath}");
  }
  
  protected override void OnConfiguring(DbContextOptionsBuilder options) => 
    options.UseSqlite($"Data Source={DbPath}");

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<OrganizationEntity>()
      .OwnsOne(e => e.Address);
    
    modelBuilder.Entity<PhotoEntity>()
      .HasOne(e => e.Organization)
      .WithMany(o => o.Photos)
      .HasForeignKey(e => e.OrganizationId);
    
    modelBuilder.Entity<OrganizationEntity>()
      .HasData(
        new OrganizationEntity()
        {
          Id = 1,
          Title = "WSEI",
          Nip = "83492384",
          Regon = "13424234",
        },
        new OrganizationEntity()
        {
          Id = 2,
          Title = "Firma",
          Nip = "2498534",
          Regon = "0873439249",
        }
      );
    
    modelBuilder.Entity<PhotoEntity>()
      .HasData(
      new PhotoEntity()
      {
        Id = 1, Date = DateTime.Now, Description = "Opis zdjęcia 1", Camera = "Aparat 1", Author = "Autor 1",
        Resolution = "1920x1080", AspectRatio = "16:9", Priority = 1, OrganizationId = 1
      },
      new PhotoEntity()
      {
        Id = 2, Date = DateTime.Now, Description = "Opis zdjęcia 2", Camera = "Aparat 2", Author = "Autor 2",
        Resolution = "1920x1080", AspectRatio = "16:9", Priority = 2, OrganizationId = 2
      }
    );

    modelBuilder.Entity<OrganizationEntity>()
      .OwnsOne(e => e.Address)
      .HasData(
        new { OrganizationEntityId = 1, City = "Kraków", Street = "Św. Filipa 17", PostalCode = "31-150", Region = "małopolskie" },
        new { OrganizationEntityId = 2, City = "Kraków", Street = "Krowoderska 45/6", PostalCode = "31-150", Region = "małopolskie" }
      );
  }
}
