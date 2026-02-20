// Main Program

public class MainClass
{
    public static void Main(string[] args)
    {
        Account account = new Account(1111, 5050);
       double intAmount = account.CalInterest();
        Console.WriteLine("Interest Amount: " + intAmount);
    }
}

// Unit test to check check correct interest amount
// write unit test to validate prinple amount