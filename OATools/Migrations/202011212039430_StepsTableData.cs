namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class StepsTableData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (1, 'We admitted we were powerless over alcohol - that our lives had become unmanageable.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (2, 'Came to believe that a Power greater than ourselves could restore us to sanity.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (3, 'Made a decision to turn our will and our lives over to the care of God as we understood Him.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (4, 'Made a searching and fearless moral inventory of ourselves.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (5, 'Admitted to God, to ourselves and to another human being the exact nature of our wrongs.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (6, 'Were entirely ready to have God remove all these defects of character.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (7, 'Humbly asked Him to remove our shortcomings.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (8, 'Made a list of all persons we had harmed, and became willing to make amends to them all.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (9, 'Made direct amends to such people wherever possible, except when to do so would injure them or others.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (10, 'Continued to take personal inventory and when we were wrong promptly admitted it.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (11, 'Sought through prayer and meditation to improve our conscious contact with God as we understood Him, praying only for knowledge of His will for us and the power to carry that out.')");
            Sql("INSERT INTO Steps (StepNumber, StepText) VALUES (12, 'Having had a spiritual awakening as the result of these steps, we tried to carry this message to alcoholics and to practice these principles in all our affairs.')");
        }
        
        public override void Down()
        {
        }
    }
}
