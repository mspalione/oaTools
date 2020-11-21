namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StepsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Steps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StepNumber = c.Byte(nullable: false),
                        StepText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Steps");
        }
    }
}
