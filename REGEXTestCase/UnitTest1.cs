using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using REGEXProblemsWithExceptionHandling;

namespace REGEXTestCase
{
    [TestClass]
    public class ExceptionHandling
    {
        [TestMethod]
        public void REGEXMethod()
        {
            ///Arrange
            string password = "Rajakongara";
            string expected = "Valid";
            REGEXExceptionHandling regex = new REGEXExceptionHandling(password);//creating a object for a class
            ///Act
            string actual = regex.ValidatingUserRegistration();//hear we check for validating password
            ///Assert
            Assert.AreEqual(expected, actual);
        }
         //The End 
    }
}
