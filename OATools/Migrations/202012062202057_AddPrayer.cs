namespace OATools.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddPrayer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Prayers (Name, PrayerText, Active) VALUES ('Unity Prayer - also known as Rozanne’s Prayer', 'I put my hand in yours, and together we can do what we could never do alone. No longer is there a sense of hopelessness, no longer must we each depend upon our own unsteady willpower. We are all together now, reaching out our hands for power and strength greater than ours, and as we join hands, we find love and understanding beyond our wildest dreams.', 'True')");
            Sql("INSERT INTO Prayers (Name, PrayerText, Active) VALUES ('Resentment Prayer', 'God, help me to show tolerance, pity and patience. This is a sick man. How can I be helpful to him? God save me from being angry. Thy will be done.', 'True')");
            Sql("INSERT INTO Prayers (Name, PrayerText, Active) VALUES ('Fear Prayer', 'God, I ask that you remove my fear and direct my attention to what you would have me be.', 'True')");
            Sql("INSERT INTO Prayers (Name, PrayerText, Active) VALUES ('Sex Prayer', 'God, I ask that you would mold my ideals, and help me to live up to them. Where I have done harm, God show me what I should do about each specific matter.', 'True')");
            Sql("INSERT INTO Prayers (Name, PrayerText, Active) VALUES ('Seeking Forgiveness', 'God, I am sorry for what I have done, and have an honest desire to let You take me to better things', 'True')");
            Sql("INSERT INTO Prayers (Name, PrayerText, Active) VALUES ('Sanity and Strength Prayer', 'God, I earnestly pray for the right ideal, for guidance in each questionable situation, for sanity, and for the strength to do the right thing.', 'True')");
            Sql("INSERT INTO Prayers (Name, PrayerText, Active) VALUES ('Decision Prayer', 'God, I am faced with indecision and I am unable to determine which course to take. I ask You for inspiration, an intuitive thought, or a decision. God, I pray to be shown what my next step should be. Give me whatever I need to take care of my problems. Especially free me from self-will so that I may be of help to others. What can I do today to help others?', 'True')");
            Sql("INSERT INTO Prayers (Name, PrayerText, Active) VALUES ('Acceptance for Today', 'And acceptance is the answer to all my problems today. When I am disturbed, it is because I find some person, place, thing, or situation—some fact of my life—unacceptable to me, and I can find no serenity until I accept that person, place, thing, or situation as being exactly the way it is supposed to be at this moment. Nothing, absolutely nothing happens in God’s world by mistake. Until I could accept my compulsive overeating, I could not stay abstinent; unless I accept life completely on life’s terms, I cannot be happy. I need to concentrate not so much on what needs to be changed in the world as on what needs to be changed in me and in my attitude. Shakespeare said, “All the world’s a stage, all the men and women merely players.” He forgot to mention that I was the chief critic.I was always able to see the flaw in every person, every situation.And I was always glad to point it out, because I knew you wanted perfection, just as I did.O.A.and acceptance have taught me that there is a bit of good in the worst of us and a bit of bad in the best of us; that we are all children of God and we each have a right to be here. When I complain about me or about you, I am complaining about God’s handiwork, I am saying that I know better than God.', 'True')");
            Sql("INSERT INTO Prayers (Name, PrayerText, Active) VALUES ('Daily Direction Prayer', 'God, please direct my thinking; especially, that it be divorced from self-pity, dishonesty or self-seeking motives. What can I do for the man that is still sick? Please give me the right thought or action. I am no longer running the show. How can I best serve Thee — Thy will (not mine) be done.', 'True')");
        }
        
        public override void Down()
        {
        }
    }
}
