// https://www.youtube.com/watch?v=6JVZwwAf88k
//

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UsersAndRolesTutorial.Data
{
	public class ApplicationDbContext : IdentityDbContext<User, Role, string,
		IdentityUserClaim<string>, UserRole, IdentityUserLogin<string>,
		IdentityRoleClaim<string>, IdentityUserToken<string>>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<User>(b =>
			{
				b.HasMany(e => e.UserRoles)
					.WithOne(e => e.User)
					.HasForeignKey(ur => ur.UserId)
					.IsRequired();
			});

			builder.Entity<Role>(b =>
			{
				b.HasMany(e => e.UserRoles)
					.WithOne(e => e.Role)
					.HasForeignKey(ur => ur.RoleId)
					.IsRequired();
			});

			Seed(builder);
		}

		private void Seed(ModelBuilder builder)
		{
			var adminUser = new User()
			{
				Email = "adminUser@hotmail.com",
				NormalizedEmail = "ADMINUSER@HOTMAIL.COM",
				UserName = "adminUser",
				NormalizedUserName = "ADMINUSER"
			};

			var salesUser = new User()
			{
				Email = "salesUser@hotmail.com",
				NormalizedEmail = "SALESUSER@HOTMAIL.COM",
				UserName = "salesUser",
				NormalizedUserName = "SALESUSER"
			};

			var userWithoutRole = new User()
			{
				Email = "userWithoutRole@hotmail.com",
				NormalizedEmail = "USERWITHOUTROLE@HOTMAIL.COM",
				UserName = "userWithoutRole",
				NormalizedUserName = "USERWITHOUTROLE"
			};

			var rolAdmin = new Role()
			{
				Name = "Admin",
				NormalizedName = "ADMIN"
			};

			var salesRole = new Role()
			{
				Name = "Sales",
				NormalizedName = "SALES"
			};

			builder.Entity<Role>().HasData(rolAdmin, salesRole);
			builder.Entity<User>().HasData(adminUser, salesUser, userWithoutRole);

			var userRoleAdmin = new UserRole()
			{
				RoleId = rolAdmin.Id,
				UserId = adminUser.Id
			};

			var userRoleSales = new UserRole()
			{
				RoleId = salesRole.Id,
				UserId = salesUser.Id
			};

			builder.Entity<UserRole>().HasData(userRoleAdmin, userRoleSales);
		}

	}





	public class User : IdentityUser
	{
		public virtual ICollection<UserRole> UserRoles { get; set; }
	}

	public class UserRole : IdentityUserRole<string>
	{
		public virtual User User { get; set; }
		public virtual Role Role { get; set; }
	}

	public class Role : IdentityRole
	{
		public virtual ICollection<UserRole> UserRoles { get; set; }
	}
}