namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Slogans : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Slogans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SloganText = c.String(),
                        AffiliatedProgram = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Slogans");
        }
    }
}
