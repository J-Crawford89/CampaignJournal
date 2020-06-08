namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastupdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Backgrounds", "LastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Campaigns", "LastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Characters", "LastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Classes", "LastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Races", "LastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Journals", "LastUpdated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Notes", "LastUpdated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notes", "LastUpdated");
            DropColumn("dbo.Journals", "LastUpdated");
            DropColumn("dbo.Races", "LastUpdated");
            DropColumn("dbo.Classes", "LastUpdated");
            DropColumn("dbo.Characters", "LastUpdated");
            DropColumn("dbo.Campaigns", "LastUpdated");
            DropColumn("dbo.Backgrounds", "LastUpdated");
        }
    }
}
