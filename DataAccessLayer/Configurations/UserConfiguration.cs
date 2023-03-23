using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataAccessLayer.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasMany(e => e.Roles)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            var user1 = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "user1@user.com",
                NormalizedUserName = "USER1@USER.COM",
                Email = "user1@user.com",
                NormalizedEmail = "USER1@USER.COM",
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber ="+905554443322",
                PhoneNumberConfirmed =false,
                TwoFactorEnabled = false,
                LockoutEnd = DateTime.UtcNow,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                IsDeleted = false,
                DeletedOn =DateTime.Now
            };
            user1.PasswordHash = CreatePasswordHash(user1, "123456");

            var user2 = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "user2@user.com",
                NormalizedUserName = "USER2@USER.COM",
                Email = "user2@user.com",
                NormalizedEmail = "USER1@USER.COM",
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = "+905554443322",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = DateTime.UtcNow,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                IsDeleted = false,
                DeletedOn = DateTime.Now
            };
            user2.PasswordHash = CreatePasswordHash(user2, "123456");

            var admin = new User
            {
                Id = "e26796d3-0f85-48fe-a864-4f523107c3bb",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email= "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = "+905554443322",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = DateTime.UtcNow,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                IsDeleted = false,
                DeletedOn = DateTime.Now
            };
            admin.PasswordHash = CreatePasswordHash(admin, "123456");

            builder.HasData(user1, user2, admin);
        }

        private string CreatePasswordHash(User applicationUser, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(applicationUser, password);
        }
    }
}
