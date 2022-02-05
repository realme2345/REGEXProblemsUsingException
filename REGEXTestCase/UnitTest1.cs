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
            string mobile = "+91 8987645233";
            string expected = "Valid";
            REGEXExceptionHandling regex = new REGEXExceptionHandling(mobile);//creating a object for a class
            ///Act
            string actual = regex.ValidatingUserRegistration();//hear we check for validating firstName
            ///Assert
            Assert.AreEqual(expected, actual);
        }
         //The End 
    }
}
