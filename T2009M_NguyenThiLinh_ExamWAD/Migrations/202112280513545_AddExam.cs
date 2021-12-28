namespace T2009M_NguyenThiLinh_ExamWAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Exams", "ExamSubject", c => c.Int(nullable: false));
            AlterColumn("dbo.Exams", "ClassRoom", c => c.Int(nullable: false));
            AlterColumn("dbo.Exams", "Faculty", c => c.Int(nullable: false));
            AlterColumn("dbo.Exams", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Exams", "Status", c => c.String());
            AlterColumn("dbo.Exams", "Faculty", c => c.String());
            AlterColumn("dbo.Exams", "ClassRoom", c => c.String());
            AlterColumn("dbo.Exams", "ExamSubject", c => c.String());
        }
    }
}
