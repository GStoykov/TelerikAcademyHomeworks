using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSchool
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolNameTest()
        {
            string name = "vazov";
            School.School vazov = new School.School("vazov");
            Assert.AreEqual(name, vazov.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolNameEmptyValueTest()
        {
            string name = "";
            School.School vazov = new School.School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolNameNullValueTest()
        {
            string name = null;
            School.School vazov = new School.School(name);
        }

        [TestMethod]
        public void AddCourseTest()
        {
            School.School school = new School.School("vazov");
            School.Course course = new School.Course("math");
            school.AddCourse(course);
            Assert.AreEqual(course.Name, school.ListOfCourses[0].Name);
        }

        [TestMethod]
        public void RemoveCourseTest()
        {
            School.School school = new School.School("vazov");
            int numberOfCourses = school.ListOfCourses.Count;
            School.Course course = new School.Course("math");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.AreEqual(numberOfCourses, school.ListOfCourses.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(MissingMemberException))]
        public void RemoveMissingCourseTest()
        {
            School.School school = new School.School("vazov");
            School.Course course = new School.Course("math");
            school.RemoveCourse(course);
        }

    }
}
