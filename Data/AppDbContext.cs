using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
  public DbSet<PhotoEntity> Photos { get; set; } 
  public DbSet<OrganizationEntity> Organizations { get; set; }
  
  public DbSet<CameraEntity> Cameras { get; set; }
  
  public DbSet<AuthorEntity> Authors { get; set; }
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

    modelBuilder.Entity<PhotoEntity>()
      .HasOne(e => e.Author)
      .WithMany(o => o.Photos)
      .HasForeignKey(e => e.AuthorId);
    
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
        });
    
    modelBuilder.Entity<PhotoEntity>()
      .HasData(
      new PhotoEntity()
      {
        Id = 1, Date = DateTime.Now, Description = "Opis zdjęcia 1", CameraId = 1, AuthorId = 1,
        Resolution = "1920x1080", AspectRatio = "16:9", Priority = 1, OrganizationId = 1
      },
      new PhotoEntity()
      {
        Id = 2, Date = DateTime.Now, Description = "Opis zdjęcia 2", CameraId = 2, AuthorId = 2,
        Resolution = "1920x1080", AspectRatio = "16:9", Priority = 2, OrganizationId = 2
      });

    modelBuilder.Entity<OrganizationEntity>()
      .OwnsOne(e => e.Address)
      .HasData(
        new { OrganizationEntityId = 1, City = "Kraków", Street = "Św. Filipa 17", PostalCode = "31-150", Region = "małopolskie" },
        new { OrganizationEntityId = 2, City = "Kraków", Street = "Krowoderska 45/6", PostalCode = "31-150", Region = "małopolskie" }
      );
    
    modelBuilder.Entity<AuthorEntity>()
      .HasData(
        new AuthorEntity()
        {
          Id = 1,
          FirstName = "Dominik",
          LastName = "Matras",
          Pseudonym = "Dominik Matras"
        },
        new AuthorEntity()
        {
          Id = 2,
          FirstName = "Jan",
          LastName = "Kowalski",
          Pseudonym = "Jan Kowalski"
        });
    
    modelBuilder.Entity<CameraEntity>()
      .HasData(
        new CameraEntity()
        {
          Id = 1,
          Model = "Canon 5D Mark IV",
          Producer = "Canon",
          SerialNumber = "SN12445"
        },
        new CameraEntity()
        {
          Id = 2,
          Model = "Sony A7 III",
          Producer = "Sony",
          SerialNumber = "SN12345"
        });
    
    base.OnModelCreating(modelBuilder);
    
    string ADMIN_ID = Guid.NewGuid().ToString();
    string ROLE_ID = Guid.NewGuid().ToString();
    string USER_ID = Guid.NewGuid().ToString();
    string USER_ROLE_ID = Guid.NewGuid().ToString();
    
    modelBuilder.Entity<IdentityRole>()
      .HasData(
      new IdentityRole
      {
        Name = "admin",
        NormalizedName = "ADMIN",
        Id = ROLE_ID,
        ConcurrencyStamp = ROLE_ID
      });

    modelBuilder.Entity<IdentityRole>()
      .HasData(
        new IdentityRole
        {
          Name = "user",
          NormalizedName = "USER",
          Id = USER_ROLE_ID,
          ConcurrencyStamp = USER_ROLE_ID
        });

    var admin = new IdentityUser
    {
      Id = ADMIN_ID,
      Email = "admin@wsei.edu.pl",
      EmailConfirmed = true,
      UserName = "admin",
      NormalizedUserName = "ADMIN",
    };

    var user = new IdentityUser
    {
      Id = USER_ID,
      Email = "user@wsei.edu.pl",
      EmailConfirmed = true,
      UserName = "user",
      NormalizedUserName = "USER" 
    };

    PasswordHasher<IdentityUser> passHashAdmin = new PasswordHasher<IdentityUser>();
    admin.PasswordHash = passHashAdmin.HashPassword(admin, "admin123");

    PasswordHasher<IdentityUser> passHashUser = new PasswordHasher<IdentityUser>();
    user.PasswordHash = passHashUser.HashPassword(user, "user123");

    modelBuilder.Entity<IdentityUser>().HasData(admin);
    modelBuilder.Entity<IdentityUser>().HasData(user);

    modelBuilder.Entity<IdentityUserRole<string>>()
      .HasData(new IdentityUserRole<string>
      {
        RoleId = ROLE_ID,
        UserId = ADMIN_ID
      });

    modelBuilder.Entity<IdentityUserRole<string>>()
      .HasData(new IdentityUserRole<string>
      {
        RoleId = USER_ROLE_ID,
        UserId = USER_ID
      });
  }
}
