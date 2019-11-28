namespace ContestantSystem.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTestpropertyon_ContestantRating_AverageRatting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContestantRatings", "AverageRating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContestantRatings", "AverageRating");
        }
    }
}
