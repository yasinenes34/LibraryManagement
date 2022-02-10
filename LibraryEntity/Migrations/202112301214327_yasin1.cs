namespace LibraryEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yasin1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Scot", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "Scot");
        }
    }
}
