using Domain.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace Domain.Contexts
{
	public class ApplicationContext : DbContext
	{

		public DbSet<UserModel> Users { get; set; }
		public DbSet<RoleModel> Roles { get; set; }
		public DbSet<DataInputModel> DataInputs { get; set; }


		public ApplicationContext(DbContextOptions<ApplicationContext> options)
				: base(options)
		{
			//Database.EnsureCreated();
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			string adminRoleName = "admin";
			string userRoleName = "user";

			string adminLogin = "admin";
			string adminPassword = "admin";

			// добавляем роли
			RoleModel adminRole = new RoleModel { Id = 1, Name = adminRoleName };
			RoleModel userRole = new RoleModel { Id = 2, Name = userRoleName };

			UserModel adminUser = new UserModel { Id = 1, Login = adminLogin, Password = adminPassword, RoleId = adminRole.Id };

			var model = DataInputModel.GetDefaultModel();

			modelBuilder.Entity<DataInputModel>().HasData(new DataInputModel[] { model });

			modelBuilder.Entity<RoleModel>().HasData(new RoleModel[] { adminRole, userRole });
			modelBuilder.Entity<UserModel>().HasData(new UserModel[] { adminUser });
			base.OnModelCreating(modelBuilder);
		}
	}


}
