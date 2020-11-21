namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedNeutralResponsesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('That is interesting.', 24)");
        }
        
        public override void Down()
        {
        }
    }
}
