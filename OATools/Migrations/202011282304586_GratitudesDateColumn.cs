namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GratitudesDateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gratitudes", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gratitudes", "Date");
        }
    }
}
