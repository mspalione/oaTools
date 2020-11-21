namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedProgramTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Alcoholics Anonymous')");
        }
        
        public override void Down()
        {
        }
    }
}
