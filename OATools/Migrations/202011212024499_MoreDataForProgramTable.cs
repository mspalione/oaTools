namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MoreDataForProgramTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Overeaters Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Sex Addicts Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Cocaine Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Narcotics Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Clutterers Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Crystal Meth Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Co-Dependents Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Debtors Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Gamblers Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Heroin Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Marijuana Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Neurotics Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Pills Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Racists Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Underearners Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Workaholics Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Sexaholics Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Sex Addicts Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Sexual Compulsives Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Sexual Recovery Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Survivors of Incest Anonymous')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Adult Children of Alcoholics')");
            Sql("INSERT INTO Programs (ProgramName) VALUES ('Al-Anon/Alateen')");
        }
        
        public override void Down()
        {
        }
    }
}
