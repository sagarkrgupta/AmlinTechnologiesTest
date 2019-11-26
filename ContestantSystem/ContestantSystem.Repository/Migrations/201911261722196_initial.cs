namespace ContestantSystem.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contestants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50, unicode: false),
                        Lastname = c.String(nullable: false, maxLength: 50, unicode: false),
                        DateOfBirth = c.DateTime(nullable: false, storeType: "date"),
                        IsActive = c.Boolean(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 20, unicode: false),
                        PhotoUrl = c.String(nullable: false, maxLength: 50, unicode: false),
                        Address = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContestantRatings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContestantId = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        RatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contestants", t => t.ContestantId, cascadeDelete: true)
                .Index(t => t.ContestantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContestantRatings", "ContestantId", "dbo.Contestants");
            DropForeignKey("dbo.Contestants", "DistrictId", "dbo.Districts");
            DropIndex("dbo.ContestantRatings", new[] { "ContestantId" });
            DropIndex("dbo.Contestants", new[] { "DistrictId" });
            DropTable("dbo.ContestantRatings");
            DropTable("dbo.Districts");
            DropTable("dbo.Contestants");
        }
    }
}
