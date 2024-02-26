using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class RentACarContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
        public DbSet<CorporateCustomer> CorporateCustomers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        public RentACarContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Brand>().HasKey(i=> i.Id); // EF Core Naming Convention BrandId //           
            modelBuilder.Entity<Brand>(e =>
            {
                e.HasKey(i => i.Id);   // Veritabanındaki "Brand" tablosunun Id sütununu birincil anahtar(PrimaryKey) olarak işaretler.
                e.Property(i => i.Premium).HasDefaultValue(true);   // Bu ifade, Premium özelliğinin veritabanında varsayılan değerini belirler. Yani, eğer bu özellik için bir değer belirtilmezse (örneğin, yeni bir kayıt eklenirken), otomatik olarak true değeri atanır.                                                                   
            });

            modelBuilder.Entity<Fuel>(e =>   
            { 
                e.HasKey(i => i.Id); 
            });

            modelBuilder.Entity<Transmission>(e => 
            { 
                e.HasKey(i => i.Id); 
            }); 
            
            modelBuilder.Entity<Model>(e => 
            { 
                e.HasKey(i => i.Id); 
            });        
            
            modelBuilder.Entity<Car>(e => 
            { 
                e.HasKey(i => i.Id); 
            });

            modelBuilder.Entity<User>(e => 
            { 
                e.HasKey(i => i.Id); 
            });

            modelBuilder.Entity<Customer>(e => 
            { 
                e.HasKey(i => i.Id); 
            });

            modelBuilder.Entity<IndividualCustomer>(e => 
            { 
                e.HasKey(i => i.Id); 
            });

            modelBuilder.Entity<CorporateCustomer>(e => 
            { 
                e.HasKey(i => i.Id); 
            });

            modelBuilder.Entity<UserRole>(e =>
            {
                e.HasKey(ur => new { ur.UserId, ur.RoleId });

                e.HasOne(ur => ur.User)
                    .WithMany(u => u.UserRoles)
                    .HasForeignKey(ur => ur.UserId);

                e.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId);
            });

            base.OnModelCreating(modelBuilder); // Normalde yaptığı işlemleri sürdürür.
        }
         // Update-Database migrationIsmi
         // Remove-Migration
    }
}