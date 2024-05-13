using System.Runtime.ExceptionServices;

namespace x1
{
    public class Student
    {
        private int studentID;
        private string studentFName;
        private string studentLName;
        private char studentGrade;

        public int StudentID
        { get { return studentID; } set { this.studentID = value; } }
        public string StudentFName
        { get { return studentFName; } set { this.studentFName = value; } }
        public string StudentLName
        { get { return studentLName; } set { this.studentLName = value; } }
        public char StudentGrade
        { get { return studentGrade; } set { this.studentGrade = value; } }

    }

    class program
    {


        static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentID = 001;
            student.StudentFName = "First Name";
            student.StudentLName = "Last Name";
            student.StudentGrade = 'A';

            Console.WriteLine("StudentID" + student.StudentID);
            Console.WriteLine("StudentFName" + student.StudentFName);
            Console.WriteLine("StudentLName" + student.StudentLName);
            Console.WriteLine("StudentGrade" + student.StudentGrade);

        }
    }

}









