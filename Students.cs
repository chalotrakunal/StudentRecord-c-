using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    struct StudentRecord
    {
        public string _studentName;
        public int _studentId;
        public int _studentMarks;
        public StudentRecord(string studentName, int studentId, int studentMarks)
        {
            _studentName  = studentName;
            _studentId    = studentId;
            _studentMarks = studentMarks;
        }
    }
    public class Students
    {
        List<StudentRecord> records = new List<StudentRecord>();
        List<StudentRecord> studrecords;
        public void StoreStudentRecords(string studentName, int studentId, int studentMarks)     // storing each record dynamically to list of Student record
        {
            var record = new StudentRecord();
            record._studentName  = studentName;
            record._studentId    = studentId;
            record._studentMarks = studentMarks;
            records.Add(record);
        }
        public void SortStudentRecords()                                  //sorting the records
        {
            var linq = (from record in records orderby record._studentMarks descending select record).ToList();
            studrecords = linq.ToList();
        }
        public void DisplayStudentRecords()                                 // display student records with rank
        {
            
            int studentRank = 0;
            foreach (var record in studrecords)
            {
                ++studentRank;
                Console.WriteLine("Name of the student is :" + record._studentName);
                Console.WriteLine("Id of student is : " + record._studentId);
                Console.WriteLine("Marks of student is :" + record._studentMarks);
                Console.WriteLine("Rank of the student is :" + studentRank);
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("\n");
        }

    }
}

    

