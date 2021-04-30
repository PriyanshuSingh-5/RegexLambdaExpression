using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegisLambdaExpression;

namespace MSTestUserLambda
{
    [TestClass]
    public class UnitTest1
    {

        RegexPattern pattern = new RegexPattern();

        [TestMethod]

        public void GivenUserFistName_WhenValidate_ShouldReturnresult()
        {
            
            bool expected = true;
            //Act
            bool output = pattern.ValidateFirstName("Priyanshu");
            //Assert
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void GivenLastNameShouldReturnHappy()
        {
            bool expected = true;
            bool output = pattern.ValidateLastName("Singh");
            Assert.AreEqual(expected, output);
        }

       
        [TestMethod]
        public void GivenValidEmailIdShouldReturnHappy()
        {
            //Arrange
            bool expected = true;
            //Act
            bool output = pattern.ValidateEmail("abc@gmail.com");
            // Assert
            Assert.AreEqual(expected, output);
        }


        
        [TestMethod]
        public void GivenValidMobileShouldReturnHappy()
        {
            bool expected = true;
            bool output = pattern.ValidatePhoneNumber("91 9146293697");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Password should return true
        /// </summary>
        [TestMethod]
        public void GivenValidPasswordShouldReturnHappy()
        {
            bool expected = true;
            bool output = pattern.ValidatePassword("Shaloo@05");
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenValidEmailListShouldReturnsTrue(string email)
        {
            bool expected = true;
            var result = pattern.ValidateEmailList(email);
            Assert.AreEqual(expected, result);
        }
    }
}