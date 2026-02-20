// Definaton of class Account

public class Account
{
    
    private int _accNO;
    private double _PAmount, _balance, _interestAmount;
    public static float ROI;
    static Account ()
    {
        ROI = 5.5f;
    }
    public Account(int accNO, double amount)
    {
        this._accNO = accNO;
        this._PAmount = amount;
        _balance = amount;
        _interestAmount = CalInterest();

    }

    public double CalInterest()
    {
        _interestAmount = (_PAmount * 5 * ROI) / 100;
        _balance = _PAmount + _interestAmount;
        return (_interestAmount);

    }
    // Validate the amount
    public bool ValidateAmount()
    {
        if (_PAmount <= 0)
        {
            return false;
        }
            
        else 
        {
            return true;
    }
        
    }

}