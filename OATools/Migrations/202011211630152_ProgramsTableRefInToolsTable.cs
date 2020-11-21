namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProgramsTableRefInToolsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tools", "Program_Id", c => c.Int());
            AlterColumn("dbo.Tools", "ProgramId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Tools", "Program_Id");
            AddForeignKey("dbo.Tools", "Program_Id", "dbo.Programs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tools", "Program_Id", "dbo.Programs");
            DropIndex("dbo.Tools", new[] { "Program_Id" });
            AlterColumn("dbo.Tools", "ProgramId", c => c.Int(nullable: false));
            DropColumn("dbo.Tools", "Program_Id");
        }
    }
}
