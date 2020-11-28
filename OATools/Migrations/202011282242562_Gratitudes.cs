namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gratitudes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gratitudes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Grat1 = c.String(),
                        Grat2 = c.String(),
                        Grat3 = c.String(),
                        Grat4 = c.String(),
                        Grat5 = c.String(),
                        Grat6 = c.String(),
                        Grat7 = c.String(),
                        Grat8 = c.String(),
                        Grat9 = c.String(),
                        Grat10 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Gratitudes");
        }
    }
}
