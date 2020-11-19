namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedFreePdfLinksAddBookTableColumn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.FreePdfLinks SET BookTitle = 'The Big Book of Alcoholics Anonymous'");
        }
        
        public override void Down()
        {
        }
    }
}
