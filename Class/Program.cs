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
    }
}


