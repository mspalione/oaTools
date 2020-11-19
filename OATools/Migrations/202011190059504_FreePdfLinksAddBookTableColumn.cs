namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FreePdfLinksAddBookTableColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FreePdfLinks", "BookTitle", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FreePdfLinks", "BookTitle");
        }
    }
}
