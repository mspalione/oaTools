namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeToolkitColumnName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Toolkits", "ViewName", c => c.String());
            DropColumn("dbo.Toolkits", "PartialViewName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Toolkits", "PartialViewName", c => c.String());
            DropColumn("dbo.Toolkits", "ViewName");
        }
    }
}
