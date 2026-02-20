

namespace TestBankAccountProject;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void Test_CalInterest()
    {
        //Arrange 
        Account acc1 = new Account(1212, 5050);
        double intAmount;



        // Act
        intAmount = acc1.CalInterest();



        // Assert
        Assert.AreEqual(1388.75, intAmount);

    }

    // write a unit test to validate the pronciple amount i.e. principle amount should be a non zero, positive value 
    
    [TestMethod]
    public void Test_ValidateAmountForNegativeValue()
    {
        // Arrange
        Account acc1 = new Account(1212, -5050);

        // Act 

        bool flag = acc1.ValidateAmount();


        // Assert
        Assert.IsFalse(flag);
        //Assert.IsTrue(flag);
    }
    // Test3 : Validate for positive value 

    [TestMethod]

    public void Test_ValidateAmountForPositiveValue()
    {
        // Arrange
        Account acc1 = new Account(1212, 5050);

        // Act 

        bool flag = acc1.ValidateAmount();


        // Assert
        Assert.IsTrue(flag);
    }

    // Validate for zero amount 

    [TestMethod]

    public void Test_ValidateAmountForZeroValue()
    {
        // Arrange
        Account acc1 = new Account(1212, 0);

        // Act 

        bool flag = acc1.ValidateAmount();


        // Assert
        Assert.IsFalse(flag);
    }

}
