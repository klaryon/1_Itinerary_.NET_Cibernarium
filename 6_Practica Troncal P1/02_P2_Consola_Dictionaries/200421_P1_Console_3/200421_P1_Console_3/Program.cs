using _200421_P1_Console_3.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _200421_P1_Console_3
{
    class Program
    {
        // ------------------------- DICTIONARIES ------------------------->>

        //public static Dictionary<Guid, Student> Students = new Dictionary<Guid, Student>(); // not using this dictionary with Guid as key.
        public static Dictionary<string, Student> StudentByDni = new Dictionary<string, Student>(); // using this dictionary with Dni "string" as key.
        public static Dictionary<Guid, Subject> Subjects = new Dictionary<Guid, Subject>();
        public static Dictionary<Guid, Exam> Exams = new Dictionary<Guid, Exam>();

        // ------------------------- MAIN PROGRAM ------------------------->>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Class Management Program");
            Console.WriteLine("Enter option a: to manage students");
            Console.WriteLine("Enter option s: to manage student subjects");
            Console.WriteLine("Enter option e: to manage student exams and statistics");

            var keepdoing = true;

            while (keepdoing)
            {
                var option = Console.ReadKey().KeyChar;

                if (option == 'a')
                {
                    ClearCurrentConsoleLine();
                    Console.WriteLine();
                    ShowStudentsMenu();
                }
                else if (option == 's')
                {
                    ClearCurrentConsoleLine();
                    Console.WriteLine();
                    ShowSubjectMenu();
                }
                else if (option == 'e')
                {
                    ClearCurrentConsoleLine();
                    Console.WriteLine();
                    ShowExamsMenu();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Did you enter the correct option?");
                }
            }
        }

        // ------------------------- STUDENT FUNCTIONS ------------------------->>
        static void ShowStudentsMenu()
        {
            ShowStudentsMenuOptions();

            var keepdoing = true;

            while (keepdoing)
            {
                var text = Console.ReadLine();

                switch (text)
                {
                    case "add":
                        AddNewStudent();
                        break;
                    case "all":
                        ShowAllStudents();
                        break;
                    case "edit":
                        EditStudent();
                        break;
                    case "del":
                        DeleteStudent();
                        break;
                    case "m":
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("Did you enter the correct option?");
                        Console.WriteLine();
                        ShowStudentsMenuOptions();
                        break;
                }
            }
            ShowMainMenu();
        }

        private static void ShowStudentsMenuOptions()
        {
            Console.WriteLine("---- Students Menu ----");

            Console.WriteLine("Enter add: to add new students");
            Console.WriteLine("Enter all: to see all students");
            Console.WriteLine("Enter edit: to edit an existing student");
            Console.WriteLine("Enter del: to delete an existing student");
            Console.WriteLine("Enter m: to return to main menu");
        }
        static void AddNewStudent()
        {
            Console.WriteLine("Enter first Dni or write ESC to exit");

            var keepdoing = true;

            while (keepdoing)
            {
                var dni = Console.ReadLine();

                if (dni == "ESC")
                {
                    break;
                }
                else if (string.IsNullOrEmpty(dni) || dni.Length != 9)
                {
                    Console.WriteLine($"This {dni} is not valid");
                }
                else if (StudentByDni.ContainsKey(dni))
                {
                    Console.WriteLine($"A student already exists with that {dni}");
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Enter name or write ESC to exit");

                        var name = Console.ReadLine();

                        if (name == "ESC")
                        {
                            keepdoing = false;
                            break;
                        }
                        else if (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine($"This {name} is empty");
                        }
                        else
                        {
                            var student = new Student
                            {
                                Id = Guid.NewGuid(),
                                Dni = dni,
                                Name = name,
                            };
                            StudentByDni.Add(student.Dni, student);
                            keepdoing = false;
                            break;
                        }
                    }
                }
            }

            ShowStudentsMenuOptions();
        }

        static void ShowAllStudents()
        {
            foreach (var student in StudentByDni.Values)
            {
                Console.WriteLine($"{student.Dni} {student.Name}");
            }
        }

        static void EditStudent()
        {
            Console.WriteLine("Enter Dni of student you want to modify");

            var dni = Console.ReadLine();

            foreach (var student in StudentByDni.Values)
            {
                if (student.Dni == dni)
                {
                    Console.WriteLine($"Enter new name for student with dni {dni}");
                    var newName = Console.ReadLine();
                    student.Name = newName;
                    Console.WriteLine("Student has been updated with these values:");
                    Console.WriteLine($"{student.Dni} {student.Name}");
                }  
            }
            Console.WriteLine();
            ShowStudentsMenuOptions();
        }

        static void DeleteStudent()
        {
            Console.WriteLine("Enter dni of student you want to delete");

            var delStudent = Console.ReadLine();

            foreach (var student in StudentByDni.Values)
            {
                if (student.Dni == delStudent)
                {
                    StudentByDni.Remove(student.Dni);
                    Console.WriteLine($"Student {delStudent} has been deleted");
                }
            }
            Console.WriteLine();
            ShowSubjectsMenuOptions();
        }

        // ------------------------- SUBJECT FUNCTIONS ------------------------->>
        static void ShowSubjectMenu()
        {
            ShowSubjectsMenuOptions();

            var keepdoing = true;

            while (keepdoing)
            {
                var text = Console.ReadLine();

                switch (text)
                {
                    case "add":
                        AddNewSubject();
                        break;
                    case "all":
                        ShowAllSubjects();
                        break;
                    case "edit":
                        EditSubject();
                        break;
                    case "del":
                        DeleteSubject();
                        break;
                    case "m":
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("Did you enter the correct option?");
                        Console.WriteLine();
                        ShowSubjectsMenuOptions();
                        break;
                }
            }
            ShowMainMenu();
        }
        private static void ShowSubjectsMenuOptions()
        {
            Console.WriteLine("---- Subjects Menu ----");

            Console.WriteLine("Enter add: to add new subjects");
            Console.WriteLine("Enter all: to see all subjects");
            Console.WriteLine("Enter edit: to edit an existing subject");
            Console.WriteLine("Enter del: to delete an existing subject");
            Console.WriteLine("Enter m: to return to main menu");
        }
        static void AddNewSubject()
        {
            Console.WriteLine("Enter a Subject or write ESC to exit");

            var keepdoing = true;

            while (keepdoing)
            {
                var subject = Console.ReadLine();

                if (subject == "ESC")
                {
                    break;
                }
                else if (string.IsNullOrEmpty(subject))
                {
                    Console.WriteLine($"This {subject} is not valid");
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Enter teacher name or write ESC to exit");

                        var teacherName = Console.ReadLine();

                        if (teacherName == "ESC")
                        {
                            keepdoing = false;
                            break;
                        }
                        else if (string.IsNullOrEmpty(teacherName))
                        {
                            Console.WriteLine($"This {teacherName} is empty");
                        }
                        else
                        {
                            var subjects = new Subject
                            {
                                Id = Guid.NewGuid(),
                                Name = subject,
                                Teacher = teacherName
                            };
                            Subjects.Add(subjects.Id, subjects);
                            keepdoing = false;
                            break;
                        }
                    }
                }
                ShowSubjectsMenuOptions();
            }
        }
        static void ShowAllSubjects()
        {
            foreach (var subject in Subjects.Values)
            {
                Console.WriteLine($"{subject.Name}: {subject.Teacher}");
            }
        }
        static void EditSubject()
        {
            Console.WriteLine("Enter name of subject you want to edit");

            var editSubject = Console.ReadLine();

            foreach (var subject in Subjects.Values)
            {
                if (subject.Name == editSubject)
                {
                    Console.WriteLine($"Enter name of new teacher for {editSubject}");
                    var newTeacher = Console.ReadLine();
                    subject.Teacher = newTeacher;
                }
                Console.WriteLine("Subject has been updated with these values:");
                Console.WriteLine($"{subject.Name}: {subject.Teacher}");
            }
            Console.WriteLine();
            ShowSubjectsMenuOptions();
        }
        static void DeleteSubject()
        {
            Console.WriteLine("Enter name of subject you want to delete");
            var delSubjectName = Console.ReadLine();
         
            foreach (var subject in Subjects.Values)
            {
                if (subject.Name == delSubjectName)
                {
                    Subjects.Remove(subject.Id);
                }
                Console.WriteLine($"Subject {delSubjectName} has been deleted");
            }
            Console.WriteLine();
            ShowSubjectsMenuOptions();
        }

        // ------------------------- EXAM FUNCTIONS ------------------------->>
        static void ShowExamsMenu()
        {
            ShowExamMenuOptions();

            var keepdoing = true;

            while (keepdoing)
            {
                var text = Console.ReadLine();

                switch (text)
                {
                    case "add":
                        AddNewExam();
                        break;
                    case "all":
                        ShowAllExam();
                        break;
                    case "edit":
                        EditExam();
                        break;
                    case "avg":
                        ShowAverage();
                        break;
                    case "min":
                        ShowMinimum();
                        break;
                    case "max":
                        ShowMaximum();
                        break;
                    case "m":
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("Did you enter the correct option?");
                        Console.WriteLine();
                        break;
                }
            }
            ShowMainMenu();
        }
        private static void ShowExamMenuOptions()
        {
            Console.WriteLine("---- Exams and Statistics Menu ----");

            Console.WriteLine("Enter add: to add new exam");
            Console.WriteLine("Enter all: to see all exams");
            Console.WriteLine("Enter edit: to edit exams");
            Console.WriteLine("Enter avg: to get the average student grade");
            Console.WriteLine("Enter max: to get the maximum student grade");
            Console.WriteLine("Enter min: to get the minimum student grade");
            Console.WriteLine("Enter m: to return to main menu");
        }
        static void AddNewExam()
        {
            Console.WriteLine("Enter a student dni or write ESC to exit:");
            var dni = Console.ReadLine();
            Console.WriteLine("Enter the subject or write ESC to exit:");
            var subjName = Console.ReadLine();

            //var student = StudentByDni[dni]; ---- this case works also, because dni is a "string" and can be searched in Dictionary with it's own value
            var student = StudentByDni.Values.FirstOrDefault(x => x.Dni == dni);
            var subject = Subjects.Values.FirstOrDefault(x => x.Name == subjName);

            // --------------- OTHER WAYS TO USE LINQ -.Where doest'n apply in this case ---------------
            /*var subjectId =
            from name in Subjects.Values
            where (x => x.Name == subjName)
            select (x => x.Id);*/

            //var ids = Subjects.Values.Where(x => x.Name == subjName).Select(x => x.Id);

            var keepdoing = true;

            if (dni == "ESC")
            {
                ShowExamMenuOptions();
            }
            else if (dni == student.Dni)
            {
                if (subjName == "ESC")
                {
                    ShowExamMenuOptions();
                }
                else if (subjName == subject.Name)
                {
                    while (keepdoing)
                    {
                        Console.WriteLine($"Enter exam grade for {subjName} exam");
                        var mark = double.Parse(Console.ReadLine());

                        var exam = new Exam
                        {
                            Id = Guid.NewGuid(),
                            Mark = mark,
                            Student = student,
                            Subject = subject,
                        };

                        Exams.Add(exam.Id, exam);
                        student.AddExam(Exams[exam.Id]);
                        keepdoing = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter correct subject");
                }
            }
            else
            {
                Console.WriteLine("Enter correct dni");
            }
            ShowExamMenuOptions();
        }
        static void ShowAllExam()
        {
            Console.WriteLine("Enter a student dni to see all his exams or write ESC to exit:");
            var dni = Console.ReadLine();
            var student = StudentByDni.Values.FirstOrDefault(x => x.Dni == dni);

            if (dni == "ESC")
            {
                ShowExamMenuOptions();
            }
            else if (dni == student.Dni)
            {
                foreach (var exam in student.Exams)
                {
                    Console.WriteLine($"{exam.Student.Name} {exam.Subject.Name} {exam.Mark}");
                }
            }
        }
        static void EditExam()
        {
            Console.WriteLine("Enter a student dni or write ESC to exit:");
            var dni = Console.ReadLine();
            Console.WriteLine("Enter the subject from which you want to edit its grade or write ESC to exit:");
            var subjName = Console.ReadLine();

            var student = StudentByDni.Values.FirstOrDefault(x => x.Dni == dni);
            var subject = Subjects.Values.FirstOrDefault(x => x.Name == subjName);

            if (dni == "ESC")
            {
                ShowExamMenuOptions();
            }
            else if (dni == student.Dni)
            {
                if (subjName == "ESC")
                {
                    ShowExamMenuOptions();
                }
                else if (subjName == subject.Name)
                {
                    foreach (var exam in student.Exams)
                    {
                        if ((dni == student.Dni) && (subjName == subject.Name))
                        {
                            Console.WriteLine($"Exam {subjName} actual score: {exam.Mark}.");
                            Console.WriteLine("Enter new score: ");
                            var newMark = double.Parse(Console.ReadLine());
                            exam.Mark = newMark;
                        }
                        Console.WriteLine("Exam has been updated with these values:");
                        Console.WriteLine($"{exam.Student.Dni} {exam.Student.Name}: {exam.Subject.Name} {exam.Mark}");
                    }
                }
                else
                {
                    Console.WriteLine("Enter correct subject");
                }
            }
            else
            {
                Console.WriteLine("Enter correct dni");
            }
            ShowExamMenuOptions();
        }
        static void ShowAverage()
        {
            var average = Exams.Values.Average(x => x.Mark);
            Console.WriteLine($"Actual average score is: {average}");
            Console.WriteLine();
        }

        static void ShowMinimum()
        {
            var min = Exams.Values.Min(x => x.Mark);
            Console.WriteLine($"Minimum grade is: {min}");
            Console.WriteLine();
        }

        static void ShowMaximum()
        {
            var max = Exams.Values.Max(x => x.Mark);
            Console.WriteLine($"Maximum grade is: {max}");
            Console.WriteLine();
        }
        // ------------------------- MAIN MENU ------------------------->>
        static void ShowMainMenu()
        {
            Console.WriteLine("Return to main menu");
            Console.WriteLine("Enter option a: to manage students");
            Console.WriteLine("Enter option s: to manage student subjects");
            Console.WriteLine("Enter option e: to manage student exams and statistics");
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

    }
}
