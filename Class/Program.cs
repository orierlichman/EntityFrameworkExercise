namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void AddStudent(string name)
        {
            StudentsAndGradesContext DB = new StudentsAndGradesContext();
            Student s = new Student();
            s.StudentName = name;

            DB.Students.Add(s);
            DB.SaveChanges();
        }

        static void AddGradeByID(int ID, int grade)
        {
            StudentsAndGradesContext DB = new StudentsAndGradesContext();
            StudentGrade g = new StudentGrade();
            g.Score = grade;
            foreach (Student student in DB.Students)
            {
                if(student.StudentId!=null)
                {
                    if(student.StudentId == ID)
                    {
                        DB.StudentGrades.Add(g);
                        DB.SaveChanges();
                    }
                }
            }
        }
    }
}


