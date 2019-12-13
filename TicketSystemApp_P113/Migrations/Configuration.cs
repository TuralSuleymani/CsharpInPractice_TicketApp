namespace TicketSystemApp_P113.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TicketSystemApp_P113.Models.TicketsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TicketSystemApp_P113.Models.TicketsDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            if(!context.Users.Any())
            {
                context.Users.Add(new Models.User
                {
                    Email = "test@gmail.com",
                    InvalidTry = 0,
                    IsActive = true,
                    Name = "test user",
                    Password = "1234Test",
                    RegisterDate = DateTime.Now,
                    RoleType = Models.RoleType.User,
                    Surname = "test surname"
                });
            }
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
