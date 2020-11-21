namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Traditions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Traditions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TraditionText = c.String(),
                        TraditionNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Traditions");
        }
    }
}
