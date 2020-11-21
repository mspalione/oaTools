namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnTraditionsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Traditions", "TraditionSummary", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Traditions", "TraditionSummary");
        }
    }
}
