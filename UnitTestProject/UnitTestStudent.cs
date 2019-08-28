using System;
using System.Security.Cryptography.X509Certificates;
using BrushUp;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTestStudent
    {
        private Student _student;
        [TestInitialize]
        public void testIni()
        {
            _student = new Student("Line", "4700 Næstved", 3, Gender.Female);
        }

        #region Name

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Line", _student.Name);

            _student.Name = "Nikolas";

            Assert.AreEqual("Nikolas", _student.Name);
        }
        //TODO Smart måde at teste at der ikke bliver kastet en exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameExceptionEmpty()
        {
            _student.Name = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameExceptionNull()
        {
            _student.Name = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameExceptionWhiteSpace()
        {
            _student.Name = " ";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameToSmall()
        {
            _student.Name = "I";
        }

        #endregion

        #region Adress

        [TestMethod]
        public void TestAdress()
        {
            Assert.AreEqual("4700 Næstved", _student.Adress);
            _student.Adress = "Kegnæsvej";
            Assert.AreEqual("Kegnæsvej", _student.Adress);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAdressExceptionNull()
        {
            _student.Adress = null;
        }

        #endregion

        #region Semester

        [TestMethod]
        public void TestSemester()
        {
            Assert.AreEqual(3, _student.Semester);
            _student.Semester = 4;
            Assert.AreEqual(4, _student.Semester);
        }

        [TestMethod]
        public void TestSemesterIndefor()
        {
            _student.Semester = 1;
            Assert.AreEqual(1, _student.Semester);
            _student.Semester = 2;
            Assert.AreEqual(2, _student.Semester);
            _student.Semester = 7;
            Assert.AreEqual(7, _student.Semester);
            _student.Semester = 8;
            Assert.AreEqual(8, _student.Semester);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterExceptionToSamll()
        {
            _student.Semester = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterExceptionToHeigh()
        {
            _student.Semester = 9;
        }


        #endregion


    }


}
