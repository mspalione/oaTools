namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrayersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        PrayerText = c.String(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Prayers");
        }
    }
}
