namespace Bank.Items;

public class Money
{
    private int amount;

    /**
     * Money constructor
     */
    public Money(int amount)
    {
        this.amount = amount;
    }

    /**
     * Get the amount of money
     */
    public int GetAmount()
    {
        return this.amount;
    }

    /**
     * Set the amount of money (but kinda useless because we should only set money in the constructor - used only in Bank max money)
     */
    public void SetAmount(int amount)
    {
        this.amount = amount;
    }
}