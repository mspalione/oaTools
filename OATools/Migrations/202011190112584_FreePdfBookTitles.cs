namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FreePdfBookTitles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FreePdfBookTitles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookTitle = c.String(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FreePdfBookTitles");
        }
    }
}
