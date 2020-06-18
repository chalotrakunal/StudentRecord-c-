using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students();
            TestClass testClass = new TestClass();
            testClass.TestGit();
            Console.WriteLine("How many no of  student records you want : ");          //specify  the count of student for which we want to store the record
            var record = Console.ReadLine();
            int noOfStudent = Convert.ToInt32(record);
            for (int k = 0; k < noOfStudent; k++)
            {
                Console.WriteLine("Enter the name of student :");           // enter name
                var studentName = Console.ReadLine();
                Console.WriteLine("Enter the Id of student :");            // enter Id
                var id = Console.ReadLine();
                int studentId = Convert.ToInt32(id);
                Console.WriteLine("Enter the marks scored by student :");  // enter the marks
                var marks = Console.ReadLine();
                int studentMarks = Convert.ToInt32(marks);
                student.StoreStudentRecords(studentName, studentId, studentMarks);    // call to method which will store the stident records
            }
          
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Rank of the student after sorting  based on marks are as follow :");
            Console.WriteLine("----------------------------------------");
            student.SortStudentRecords();
            student.DisplayStudentRecords();
            
        }

        
    }
}
