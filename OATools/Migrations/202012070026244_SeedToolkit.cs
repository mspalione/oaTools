namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedToolkit : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Toolkits (Name, Instructions, PartialViewName) VALUES ('Timed B*tch Letter', 'This writing tool is useful when needing to get out intense emotion around a person, event or idea. Time yourself b*tching. Do not filter, do not justify your own or anothers behavior. Do not be understanding of the person, situation or idea. Get out all your thoughts and emotions on the paper. Once completed, stop the timer. Now, give God as much time as you took. Write down anything you hear from God during that time, anything that comes to mind. It may not make sense in the moment, but often upon reflection or a later reading, Gods response fits and gives direction.', '_TimedBitchLetter')");
        }
        
        public override void Down()
        {
        }
    }
}
