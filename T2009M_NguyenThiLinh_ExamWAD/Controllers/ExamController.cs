using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2009M_NguyenThiLinh_ExamWAD.Data;
using T2009M_NguyenThiLinh_ExamWAD.Models;
using T2009M_NguyenThiLinh_ExamWAD.Models.ViewModels;

namespace T2009M_NguyenThiLinh_ExamWAD.Controllers
{
    public class ExamController : Controller
    {
        private MyDbContext db = new MyDbContext();
        // GET: Exam
        public ActionResult Index()
        {
            return View(db.Exams.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(ExamViewModel examViewModel)
        {
            if (ModelState.IsValid)
            {
                Exam exam = new Exam()
                {
                    ExamSubject = (Models.ExamSubject)examViewModel.ExamSubject,
                    StartTime = examViewModel.StartTime,
                    ExamDate = examViewModel.ExamDate,
                    ExamDuration = examViewModel.ExamDuration,
                    ClassRoom = (Models.ClassRoom)examViewModel.ClassRoom,
                    Faculty = (Models.Faculty)examViewModel.Faculty,
                    Status = (Models.StatusValue)examViewModel.Status
                };
                db.Exams.Add(exam);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Create exam successful!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["FailMessage"] = "Create exam successful!";
                return View("Create");
            }
          
        }
    }
}