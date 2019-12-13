namespace TicketSystemApp_P113.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commentators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentDate = c.DateTime(nullable: false),
                        CommentedBy = c.Int(nullable: false),
                        Desciption = c.String(nullable: false, maxLength: 500),
                        Ticket_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.Ticket_Id)
                .ForeignKey("dbo.Users", t => t.CommentedBy, cascadeDelete: true)
                .Index(t => t.CommentedBy)
                .Index(t => t.Ticket_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 30),
                        IsActive = c.Boolean(nullable: false),
                        InvalidTry = c.Byte(nullable: false),
                        BlockedDate = c.DateTime(),
                        RegisterDate = c.DateTime(nullable: false),
                        RoleType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 400),
                        Status = c.Int(nullable: false),
                        ClosedDate = c.DateTime(),
                        ClosedBy = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ClosedBy)
                .ForeignKey("dbo.Users", t => t.CreatedBy, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.CreatedBy)
                .Index(t => t.ClosedBy)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commentators", "CommentedBy", "dbo.Users");
            DropForeignKey("dbo.Tickets", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Tickets", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Commentators", "Ticket_Id", "dbo.Tickets");
            DropForeignKey("dbo.Tickets", "ClosedBy", "dbo.Users");
            DropIndex("dbo.Tickets", new[] { "User_Id" });
            DropIndex("dbo.Tickets", new[] { "ClosedBy" });
            DropIndex("dbo.Tickets", new[] { "CreatedBy" });
            DropIndex("dbo.Commentators", new[] { "Ticket_Id" });
            DropIndex("dbo.Commentators", new[] { "CommentedBy" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Users");
            DropTable("dbo.Commentators");
        }
    }
}
