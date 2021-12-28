namespace T2009M_NguyenThiLinh_ExamWAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExam2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Exams", "ExamDuration", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Exams", "ExamDuration", c => c.DateTime(nullable: false));
        }
    }
}
