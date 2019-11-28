namespace AppG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoryLearnings",
                c => new
                    {
                        idHistoryLearning = c.String(nullable: false, maxLength: 128),
                        yearFrom = c.Int(nullable: false),
                        yearEnd = c.Int(nullable: false),
                        address = c.String(),
                        idStudent = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.idHistoryLearning)
                .ForeignKey("dbo.Students", t => t.idStudent)
                .Index(t => t.idStudent);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        idStudent = c.String(nullable: false, maxLength: 128),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.Int(nullable: false),
                        dateOfBirth = c.DateTime(nullable: false),
                        placeOfBirth = c.String(),
                    })
                .PrimaryKey(t => t.idStudent);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistoryLearnings", "idStudent", "dbo.Students");
            DropIndex("dbo.HistoryLearnings", new[] { "idStudent" });
            DropTable("dbo.Students");
            DropTable("dbo.HistoryLearnings");
        }
    }
}
