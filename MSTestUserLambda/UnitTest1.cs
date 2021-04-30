using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegisLambdaExpression;

namespace MSTestUserLambda
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void GivenUserFistName_WhenValidate_ShouldReturnresult()
        {
            RegexPattern pattern = new RegexPattern();//Create Object
            bool expected = true;
            //Act
            bool output = pattern.ValidateFirstName("Priyanshu");
            //Assert
            Assert.AreEqual(expected, output);
        }
    }
}

