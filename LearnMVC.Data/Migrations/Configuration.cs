namespace LearnMVC.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LearnMVC.Data.LearnMVCDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LearnMVC.Data.LearnMVCDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new LearnMVCDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new LearnMVCDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "learnmvc",
                Email = "thaiquocnhat96@gmail.com",
                EmailConfirmed = true,
                Birthday = DateTime.Now,
                FullName = "Thai Quoc Nhat"
            };

            manager.Create(user, "12345$");
            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "admin" });
                roleManager.Create(new IdentityRole { Name = "user" });
            }

            var adminUser = manager.FindByEmail("thaiquocnhat96@gmail.com");

            manager.AddToRoles(adminUser.Id, new string [] { "admin", "user" });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
