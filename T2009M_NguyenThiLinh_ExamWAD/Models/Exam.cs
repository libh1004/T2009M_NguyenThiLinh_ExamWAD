using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2009M_NguyenThiLinh_ExamWAD.Models
{
    public enum ExamSubject
    {
        CoreJava,
        AdvanceJava,
        ProgrammingC,
        WebApplicationDevelopment,
        AgileDevelopment,
    }
    public enum ClassRoom
    {
        A01 = 1,
        A02 = 2,
        A03 = 3,
        A04 = 4,
        A05 = 5,
        A06 = 6,
        A07 = 7,
    }
    public enum Faculty
    {
        DaoHongLuyen,
        TrinhQuangHoa,
        NguyenVanTuan,
        DangKimThi
    }
    public enum StatusValue
    {
        Done = 1,
        UpComing = 2,
        OnGoing = 3
    }
    public class Exam
    {
        public int Id { get; set; }
        public ExamSubject ExamSubject { get; set; }
        public string StartTime { get; set; }
        public DateTime ExamDate { get; set; }
        public string ExamDuration { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public Faculty Faculty { get; set; }
        public StatusValue Status { get; set; }
    }
}