using Microsoft.VisualStudio.TestTools.UnitTesting;
using Student;
using System.Collections.Generic;

namespace Student.Tests
{
    [TestClass]
    public class StudentsSortingTests
    {
        [TestMethod]
        public void SortStudentRecords_SortsByMarksDescending()
        {
            var students = new Students();
            students.StoreStudentRecords("Alice", 1, 50);
            students.StoreStudentRecords("Bob", 2, 70);
            students.StoreStudentRecords("Carol", 3, 40);
            students.SortStudentRecords();
            var marks = students.GetSortedMarks();
            var expected = new List<int> { 70, 50, 40 };
            CollectionAssert.AreEqual(expected, marks);
        }
    }
}
