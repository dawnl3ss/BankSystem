using Bank.Items;

namespace Bank;

public class Bank
{
    private Money totalMoney = new Money(99999999);

    /**
     * Get total amount of money currently in the bank.
     */
    public long GetMoney()
    {
        return this.totalMoney.GetAmount();
    }

    /**
     * Add money in the bank.
     */
    public void AddMoney(int money)
    {
        this.totalMoney.SetAmount(this.totalMoney.GetAmount() + money);
    }

    /**
     * Remove money from the bank.
     */
    public void DeleteMoney(int money)
    {
        this.totalMoney.SetAmount(this.totalMoney.GetAmount() - money);
    }
}