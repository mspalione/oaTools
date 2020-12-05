namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSloganModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Slogans", "SloganText", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Slogans", "SloganText", c => c.String());
        }
    }
}
