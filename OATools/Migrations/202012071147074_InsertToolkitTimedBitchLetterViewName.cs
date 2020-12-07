namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InsertToolkitTimedBitchLetterViewName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Toolkits SET ViewName = 'TimedBitchLetter' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
