namespace TDD_Demo;

public class Tests
{
    bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    [TestCase(1,ExpectedResult=false)]
    [TestCase(2,ExpectedResult=true)]
    [TestCase(3,ExpectedResult=false)]
    public bool Test_IsEven_ExpectedResult(int number)
    {
       return IsEven(number);
    }

    [Test]
    public void Test_IsEven()
    {
        int number = 2;
        if (IsEven(number))
            Assert.Pass();
        else
            Assert.Fail();
    }

    // [Test]
    // public void Test_BankIsOnline()
    // {
    //     if (HasInternetConnection() && IsSecuredConnection() && IsBankBranchOnline(12))
    //         Assert.Pass();
    //     else
    //         Assert.Fail();
    // }

    // bool HasInternetConnection()
    // {
    //     return true;
    // }

    // bool IsSecuredConnection()
    // {
    //     return false;
    // }
    // bool IsBankBranchOnline(int branchID)
    // {
    //     return true;
    // }
}