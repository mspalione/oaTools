namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrinciplesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Principles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StepId = c.Byte(nullable: false),
                        Virtue = c.String(),
                        Step_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Steps", t => t.Step_Id)
                .Index(t => t.Step_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Principles", "Step_Id", "dbo.Steps");
            DropIndex("dbo.Principles", new[] { "Step_Id" });
            DropTable("dbo.Principles");
        }
    }
}
