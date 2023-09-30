namespace Bank.Items;

public class CreditCard
{
    private double number;
    private sbyte ccv;
    private string expDate;
    
    public CreditCard(double number, sbyte ccv, string expDate)
    {
        this.number = number;
        this.ccv = ccv;
        this.expDate = expDate;
    }

    /**
     * Get the credit card number
     */
    public double GetNumber()
    {
        return this.number;
    }

    /**
     * Get the credit card CCV
     */
    public sbyte GetCCV()
    {
        return this.ccv;
    }

    /**
     * Get the expiration date of the credit card | format : mm/yy
     */
    public string GetExpirationDate()
    {
        return this.expDate;
    }
}