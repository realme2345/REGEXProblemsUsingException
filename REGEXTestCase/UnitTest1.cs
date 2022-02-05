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
            string lastName = "Raja";
            string expected = "Valid";
            REGEXExceptionHandling regex = new REGEXExceptionHandling(lastName);//creating a object for a class
            ///Act
            string actual = regex.ValidatingFirstName();//hear we check for validating firstName
            ///Assert
            Assert.AreEqual(expected, actual);
        }
         //The End 
    }
}
