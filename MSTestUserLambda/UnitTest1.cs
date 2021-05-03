using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegisLambdaExpression;

namespace MSTestUserLambda
{

    [TestClass]
    public class Test
    {
        private readonly RegexPattern User;
    public Test()
    {
        User = new RegexPattern(); //create object
    }
    
        //validate first name
    [TestMethod]
    public void validateFirstName()
    {
        var Result = User.ValidateFirstName("Priyanshu");
        Assert.AreEqual(true, Result);
    }

    [TestMethod]
    public void validateLastName()
    {
        var Result = User.ValidateLastName("Singh");
        Assert.AreEqual(true, Result);
    }

    [TestMethod]
    public void Validate_Email()
    {
        var Result = User.ValidateEmail("priya12@gmail.com");
        Assert.AreEqual(true, Result);
    }

    [TestMethod]
    public void Validate_PhonNum()
    {
        var Result = User.ValidatePhoneNumber("91 9865432666");
        Assert.AreEqual(true, Result);
    }

    [TestMethod]
    public void Validate_Password()
    {
        var Result = User.ValidatePassword("shiva@12");
        Assert.AreEqual(true, Result);

    }

    /// <summary>
    /// Validation using lambda expressions
    /// </summary>
    [TestMethod]
    public void FirstNameUsingLambdaExpression()
    {
        var Result = User.ValidateFirstName("Shaloo");
        Assert.AreEqual(true, Result);
    }

    [TestMethod]
    public void LastNameUsingLambdaExpression()
    {
        var Result = User.ValidateLastName("Singh");
        Assert.AreEqual(true, Result);
    }

    [TestMethod]
    public void EmailUsingLambdaExpression()
    {
        var Result = User.ValidateEmail("shaloo@gmail.com");
        Assert.AreEqual(true, Result);
    }

    [TestMethod]
    public void MobileNumberUsingLabdaExpression()
    {
        var Result = User.ValidatePhoneNumber("91 9975833272");
        Assert.AreEqual(true, Result);
    }

    [TestMethod]
    public void PasswordUingLambdaExpression()
    {
        var Result = User.ValidatePassword("Ranu@123");
        Assert.AreEqual(true, Result);
    }
}
}

