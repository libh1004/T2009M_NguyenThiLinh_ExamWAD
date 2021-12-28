using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T2009M_NguyenThiLinh_ExamWAD.Models.ViewModels
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
    public class ExamViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter exam subject.")]
        public ExamSubject ExamSubject { get; set; }
        [Required(ErrorMessage = "Please enter start time.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage = "Please enter exam date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExamDate { get; set; }
        [Required(ErrorMessage = "Please enter exam duration.")]
        [Range(1, 60, ErrorMessage = "Please enter exam duration with mininum 1min.")]
        public DateTime ExamDuration { get; set; }
        [Required(ErrorMessage = "Please enter class room.")]
        public ClassRoom ClassRoom { get; set; }
        [Required(ErrorMessage = "Please enter faculty.")]
        public Faculty Faculty { get; set; }
        [Required(ErrorMessage = "Please enter status.")]
        public StatusValue Status { get; set; }
    }
}