namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedFreePdfBookTitles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO FreePdfBookTitles (BookTitle, Active) VALUES ('The Big Book of Alcoholics Anonymous', 'True')");
            Sql("INSERT INTO FreePdfBookTitles (BookTitle, Active) VALUES ('Alcoholics Anonymous Daily Reflections', 'True')");
        }
        
        public override void Down()
        {
        }
    }
}
