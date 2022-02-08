public class CashManager {
    private double cashInAccount;
    public CashManager(double cashAmount) {
        this.cashInAccount = cashAmount;
    }

    public void deposit(double cashAmount) {
        cashInAccount += cashAmount;
        System.out.println("Cash in account: " + cashInAccount);
    }

    public boolean haveEnoughMoney(double cashAmount) {
        return cashInAccount > cashAmount;
    }

    public void withdraw(double cashAmount) {
        cashInAccount -= cashAmount;
        System.out.println("Cash in account: " + cashInAccount);
    }
}
