namespace FirstMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RankEnums3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "RatingsEnum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "RatingsEnum");
        }
    }
}
