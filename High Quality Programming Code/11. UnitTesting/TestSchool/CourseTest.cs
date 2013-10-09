using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace TestSchool
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseNameTest()
        {
            string name = "Math";
            Course course = new Course("Math");
            Assert.AreEqual(name, course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseEmptyStringNameValueTest()
        {
            string name = "";
            Course course = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseNullNameValueTest()
        {
            string name = null;
            Course course = new Course(name);
        }

        [TestMethod]
        public void AddStudentAtsCourseMethodTest()
        {
            Course course = new Course("Math");
            Student student = new Student("Gosho", "Ivanov", 12345);
            course.AddStudent(student);
            Assert.AreEqual(student.ID, course.ListOfStudents[0].ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTwiseTest()
        {
            Course course = new Course("Math");
            Student student = new Student("Gosho", "Ivanov", 12345);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        public void RemoveStudentFromCourseMethodTest()
        {
            Course course = new Course("Math");
            int studentsInCourse = course.ListOfStudents.Count;
            Student student = new Student("Gosho", "Ivanov", 12345);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(studentsInCourse, course.ListOfStudents.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(MissingMemberException))]
        public void RemoveMissingStudentTest()
        {
            Course course = new Course("Math");
            Student student = new Student("Gosho", "Ivanov", 12345);
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentInFullClassTest()
        {
            Course course = new Course("Math");
            string firstName = "Test";
            string lastName = "Testov";
            for (int i = 0; i < 30; i++)
            {
                course.AddStudent(new Student(firstName, lastName, 10000 + i));
            }
            Student student = new Student("Gosho", "Ivanov", 12345);
            course.AddStudent(student);
        }

    }
}
