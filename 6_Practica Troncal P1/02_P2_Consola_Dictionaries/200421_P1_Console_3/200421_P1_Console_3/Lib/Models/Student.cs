using System;
using System.Collections.Generic;

namespace _200421_P1_Console_3.Lib.Models
{
    public class Student : Entity
    {
        public string Name { get; set; }

        public string Dni { get; set; }

        public List<Exam> Exams { get; set; }

        public Student()
        {
            Exams = new List<Exam>();
        }

        public bool AddExam(Exam exam)
        {
            exam.Student = this;
            Exams.Add(exam);
            return true;
        }
    }
}
