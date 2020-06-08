namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class softdeletion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Backgrounds", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Campaigns", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Classes", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Races", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Journals", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Notes", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsDeleted");
            DropColumn("dbo.Notes", "IsDeleted");
            DropColumn("dbo.Journals", "IsDeleted");
            DropColumn("dbo.Races", "IsDeleted");
            DropColumn("dbo.Classes", "IsDeleted");
            DropColumn("dbo.Characters", "IsDeleted");
            DropColumn("dbo.Campaigns", "IsDeleted");
            DropColumn("dbo.Backgrounds", "IsDeleted");
        }
    }
}
