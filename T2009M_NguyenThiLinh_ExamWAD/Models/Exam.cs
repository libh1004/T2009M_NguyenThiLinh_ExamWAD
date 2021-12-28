using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2009M_NguyenThiLinh_ExamWAD.Models
{
    public class Exam
    {
        public string ExamSubject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ExamDate { get; set; }
        public DateTime ExamDuration { get; set; }
        public string ClassRoom { get; set; }
        public string Faculty { get; set; }
    }
}