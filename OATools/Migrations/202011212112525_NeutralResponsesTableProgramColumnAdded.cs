namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NeutralResponsesTableProgramColumnAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NeutralResponses", "Program_Id", c => c.Int());
            CreateIndex("dbo.NeutralResponses", "Program_Id");
            AddForeignKey("dbo.NeutralResponses", "Program_Id", "dbo.Programs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NeutralResponses", "Program_Id", "dbo.Programs");
            DropIndex("dbo.NeutralResponses", new[] { "Program_Id" });
            DropColumn("dbo.NeutralResponses", "Program_Id");
        }
    }
}
