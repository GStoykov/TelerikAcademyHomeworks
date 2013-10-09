using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace TestSchool
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentNameTest()
        {
            string firstName = "Georgi";
            Student student = new Student("Georgi", "Petrov", 12345);
            Assert.AreEqual(firstName, student.FirstName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentNameNullTest()
        {
            string firstName = null;
            Student student = new Student(firstName, "Petrov", 12345);
        }

        [TestMethod]
        public void StudentIdTest()
        {
            int id = 12345;
            Student student = new Student("Georgi", "Petrov", 12345);
            Assert.AreEqual(id, student.ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentIdOutOfMaxRangeTest()
        {
            int id = 100000;
            Student student = new Student("Georgi", "Petrov", id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentIdOutOfMinRangeTest()
        {
            int id = 9999;
            Student student = new Student("Georgi", "Petrov", id);
        }

        [TestMethod]
        public void StudentIdAtMinPossibleValueTest()
        {
            int id = 10000;
            Student student = new Student("Georgi", "Petrov", id);
            Assert.AreEqual(id, student.ID);
        }

        [TestMethod]
        public void StudentIdAtMaxPossibleValueTest()
        {
            int id = 99999;
            Student student = new Student("Georgi", "Petrov", id);
            Assert.AreEqual(id, student.ID);
        }
    }
}
