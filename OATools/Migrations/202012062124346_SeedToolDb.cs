namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedToolDb : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Tools (ToolText, ToolSummary) Values ('Abstinence', 'We commit ourselves to stay away from the first drink, one day at a time. This tool helps us deal with the physical aspects of our disease and achieve physical recovery.')");
            Sql("INSERT INTO Tools (ToolText, ToolSummary) Values ('Meetings', ' We attend A.A. meetings to learn how the program works, to share our experience, strength and hope with each other. Through the support of the fellowship, we can do what we could never do alone. Meetings give us an opportunity to identify our common problems, confirm our common solution through the Twelve Steps, and share the gifts we receive through this program. In addition to face-to-face meetings, many programs offer telephone and online meetings.')");
            Sql("INSERT INTO Tools (ToolText, ToolSummary) Values ('Sponsorship', 'A sponsor is a person in the program who has what we want and is continually sober. A sponsor is someone you can relate to, have access to and can confide in. We ask a sponsor to help us through our program of recovery on all three levels: physical, emotional, and spiritual.')");
            Sql("INSERT INTO Tools (ToolText, ToolSummary) Values ('Telephone', ' The telephone is our lifeline -- our meetings between meetings. Call before you take the first drink. Many members call, text, or email their sponsors and other members daily. Telephone or electronic contact also provides an immediate outlet for those hard-to-handle highs and lows we may experience. The more numbers you have, the more insurance you have.')");
            Sql("INSERT INTO Tools (ToolText, ToolSummary) Values ('Writing', 'Putting our thoughts and feelings down on paper helps us to better understand our actions and reactions in a way that is often not revealed to us by simply thinking or talking about them.')");
            Sql("INSERT INTO Tools (ToolText, ToolSummary) Values ('Literature', ' The Big Book of Alcoholics Anonymous is our basic tool and text. We read program approved books and pamphlets. Reading program approved literature daily reinforces how to live the Twelve Steps and Twelve Traditions.')");
            Sql("INSERT INTO Tools (ToolText, ToolSummary) Values ('Action Plan', 'An action plan is the process of identifying and implementing attainable actions that are necessary to support our individual abstinence. It may vary widely among members and may need to be adjusted to bring structure, balance, and manageability into our lives.')");
            Sql("INSERT INTO Tools (ToolText, ToolSummary) Values ('Anonymity', 'Whom you see here, what you hear here, when you leave here, let it stay here. Anonymity is the spiritual foundation of our program. Anonymity guarantees we will place principles before personalities and assures us that only we have the right to make our membership known within our community. Anonymity at the level of press, radio, films, television and other public media of communication means that we never allow our faces or last names to be used once we identify ourselves as a program member. Within the Fellowship, anonymity means that whatever we share with another member will be held in respect and confidence. What we hear at meetings should remain there.')");
            Sql("INSERT INTO Tools (ToolText, ToolSummary) Values ('Service', 'Service helps our personal program grow. Service is giving in A.A. Members can give service by attending and leading a meeting, making coffee, moving chairs, being a sponsor, putting out literature,  talking to newcomers, or emptying ashtrays. Beyond the group level, a member can serve as intergroup representative, committee chair, region representative, or conference delegate. Service is action, and action is the magic word in this program. Any form of service that helps reach a fellow sufferer adds to the quality of our own recovery.')");
        }
        
        public override void Down()
        {
        }
    }
}
