namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Promises : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Promises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PromiseText = c.String(),
                        PromiseNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Promises");
        }
    }
}
