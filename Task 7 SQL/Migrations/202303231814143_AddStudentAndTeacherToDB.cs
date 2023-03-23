namespace Task_7_LEO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentAndTeacherToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentTeacher",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.TeacherId })
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentTeacher", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentTeacher", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentTeacher", new[] { "TeacherId" });
            DropIndex("dbo.StudentTeacher", new[] { "StudentId" });
            DropTable("dbo.StudentTeacher");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
        }
    }
}
