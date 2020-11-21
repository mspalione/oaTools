namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedPrinciplesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (1, 'Honesty')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (2, 'Hope')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (3, 'Faith')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (4, 'Courage')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (5, 'Integrity')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (6, 'Willingness')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (7, 'Humility')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (8, 'Love')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (9, 'Discipline')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (10, 'Perseverance')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (11, 'Spirituality')");
            Sql("INSERT INTO Principles (StepId, Virtue) VALUES (12, 'Service')");
        }
        
        public override void Down()
        {
        }
    }
}
