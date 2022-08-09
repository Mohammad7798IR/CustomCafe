using CustomDrink.Model.Entities;
using Microsoft.EntityFrameworkCore;


namespace CustomDrink.DataAccess.Context
{
    public partial class CustomDrinkContext : DbContext
    {
        public CustomDrinkContext(DbContextOptions<CustomDrinkContext> options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }
    }

    public partial class CustomDrinkContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region User

            modelBuilder.Entity<User>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<User>()
                .HasMany(a => a.UserDetails)
                .WithOne(a => a.User)
                .HasForeignKey(fk => fk.UserId);

            #endregion

            #region UserRole


            modelBuilder.Entity<UserRole>()
                .HasKey(a=>a.Id);


            modelBuilder.Entity<UserRole>()
                .HasOne(a => a.Role)
                .WithMany(a => a.UserRoles)
                .HasForeignKey(fk => fk.RoleId);


            modelBuilder.Entity<UserRole>()
                .HasOne(a => a.User)
                .WithMany(a => a.UserRoles)
                .HasForeignKey(fk => fk.UserId);

            #endregion


            #region Store

            modelBuilder.Entity<Store>()
                .HasOne(a => a.User)
                .WithOne(a => a.Store)
                .HasForeignKey<Store>(fk => fk.UserId);

            #endregion
        }
    }
}
