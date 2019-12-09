using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamWAD.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string ExamSubject { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public string StartTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public string ExamDate { get; set; }
        public int ExamDuration { get; set; }
        public string ClassRoom { get; set; }
        public string ExamFaculty { get; set; }
        public ExamStatus Status { get; set; }
    }

    public enum ExamStatus
    {
        Done = 0,
        UpComing = 1,
        OnGoing = -1
    }
}