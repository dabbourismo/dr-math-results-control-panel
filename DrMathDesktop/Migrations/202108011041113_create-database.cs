namespace DrMathDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResultValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Level = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameArabic = c.String(),
                        NameEnglish = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Level = c.Int(nullable: false),
                        ExamLanguage = c.Int(nullable: false),
                        AgeRange = c.Int(nullable: false),
                        Governate = c.String(),
                        TrainerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainers", t => t.TrainerId, cascadeDelete: true)
                .Index(t => t.TrainerId);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "TrainerId", "dbo.Trainers");
            DropIndex("dbo.Students", new[] { "TrainerId" });
            DropIndex("dbo.Results", new[] { "StudentId" });
            DropTable("dbo.Trainers");
            DropTable("dbo.Students");
            DropTable("dbo.Results");
        }
    }
}
