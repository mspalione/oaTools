namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class TimedBitchLetters : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimedBitchLetters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: true),
                        EndTime = c.DateTime(nullable: true),
                        Bitching = c.String(),
                        GodsResponse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimedBitchLetters");
        }
    }
}
