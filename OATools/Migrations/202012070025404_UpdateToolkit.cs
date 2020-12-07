namespace OATools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateToolkit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TimedBitchLetters", "Subject", c => c.String());
            AddColumn("dbo.Toolkits", "PartialViewName", c => c.String());
            AlterColumn("dbo.TimedBitchLetters", "Bitching", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TimedBitchLetters", "Bitching", c => c.String());
            DropColumn("dbo.Toolkits", "PartialViewName");
            DropColumn("dbo.TimedBitchLetters", "Subject");
        }
    }
}
