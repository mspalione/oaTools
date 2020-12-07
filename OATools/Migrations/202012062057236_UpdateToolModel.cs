namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateToolModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tools", "ToolSummary", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tools", "ToolSummary");
        }
    }
}
