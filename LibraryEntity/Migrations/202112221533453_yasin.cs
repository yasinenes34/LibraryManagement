namespace LibraryEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yasin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookOperation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        BookID = c.Int(nullable: false),
                        Purchaseof_Books = c.DateTime(nullable: false),
                        BookReturn_Date = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Book", t => t.BookID)
                .ForeignKey("dbo.Student", t => t.StudentID)
                .Index(t => t.StudentID)
                .Index(t => t.BookID);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Book_Name = c.String(),
                        Author = c.String(),
                        Release_Date = c.DateTime(nullable: false),
                        Copies = c.Int(nullable: false),
                        Page_Count = c.Int(nullable: false),
                        Category = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Last_Name = c.String(),
                        Department = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookOperation", "StudentID", "dbo.Student");
            DropForeignKey("dbo.BookOperation", "BookID", "dbo.Book");
            DropIndex("dbo.BookOperation", new[] { "BookID" });
            DropIndex("dbo.BookOperation", new[] { "StudentID" });
            DropTable("dbo.Student");
            DropTable("dbo.Book");
            DropTable("dbo.BookOperation");
        }
    }
}
