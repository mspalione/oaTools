namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MoreDataForNeutralResponsesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Let me think about that.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Thank you for your information.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Thank you for supporting me.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('I will have to ponder that one.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Wow.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Hmmm.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Golly-gee.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Good old fashioned silence.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Really?', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('You could be right.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('I never thought of it that way.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Thanks for the feedback.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('I appreciate your perspective.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('That is food for thought.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('I hear you.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('I hear what you are saying.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('I can see where you are coming from.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('That is fascinating.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Sounds like you have it under control.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('I trust your ability to handle this.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Maybe so.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('That could be.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Let me check and get back to you.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('That is one way to look at it.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('I do not know. What do you think?', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Oh.', 24)");
            Sql("INSERT INTO NeutralResponses (Response, Program_Id) VALUES ('Ah.', 24)");
        }
        
        public override void Down()
        {
        }
    }
}
