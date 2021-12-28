using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using T2009M_NguyenThiLinh_ExamWAD.Models;

namespace T2009M_NguyenThiLinh_ExamWAD.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=ConnectionString")
        {

        }
        public DbSet<Exam> Exams { get; set; }
    }
}