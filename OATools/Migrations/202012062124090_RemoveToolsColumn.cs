namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveToolsColumn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tools", "Program_Id", "dbo.Programs");
            DropIndex("dbo.Tools", new[] { "Program_Id" });
            DropColumn("dbo.Tools", "ProgramId");
            DropColumn("dbo.Tools", "Program_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tools", "Program_Id", c => c.Int());
            AddColumn("dbo.Tools", "ProgramId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Tools", "Program_Id");
            AddForeignKey("dbo.Tools", "Program_Id", "dbo.Programs", "Id");
        }
    }
}
