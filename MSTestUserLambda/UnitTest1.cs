using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegisLambdaExpression;

namespace MSTestUserLambda
{
    [TestClass]
    public class Test
    {
        //valid first name
        [TestMethod]
        public void GivenFirstNameShouldReturnHappy()
        {
            try
            {
                //Act
                bool output = pattern.ValidateFirstName("Priyanshu");
            }

            catch (RegistrationException e)
            
            {
                //Assert
                Assert.AreEqual("Invalid First Name,Name should be first letter capital", e.Message);
            }
        }

       //valid last name 
        [TestMethod]
        public void GivenLastNameShouldReturnHappy()
        {
            try
            {
                bool output = pattern.ValidateLastName("Singh");
            }
            catch (RegistrationException e)
            {
                Assert.AreEqual("Invalid Last Name,Name should be first letter capital", e.Message);
            }
        }

      // ValidateEmails
        [TestMethod]
        public void GivenValidEmailIdShouldReturnHappy()
        {

            try
            {
                //Act
                bool output = pattern.ValidateEmail("abc@gmail.com");
            }
            catch (RegistrationException e)
            {
                // Assert
                Assert.AreEqual("Invalid Email", e.Message);
            }
        }


        //valid mobile number or not
        [TestMethod]
        public void GivenValidMobileShouldReturnHappy()
        {
            try
            {
                bool output = pattern.ValidateMobileNo("91 9146293697");
            }
            catch (RegistrationException e)
            {
                Assert.AreEqual("Invalid Mobile number,number should be predefined format", e.Message);
            }
        }

        //valid password or not
        public void GivenValidPasswordShouldReturnHappy()
        {
            try
            {
                bool output = pattern.ValidatePassword("Shaloo@123");
            }
            catch (RegistrationException e)
            {
                Assert.AreEqual("Invalid Password,Password should be in format", e.Message);
            }

        }

       //Email
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
            try
            {
                var result = pattern.validateEmailList(email);
            }
            catch (RegistrationException e)
            {
                Assert.AreEqual("Invalid Email.Email should be in format", e.Message);
            }
        }
    }
}
