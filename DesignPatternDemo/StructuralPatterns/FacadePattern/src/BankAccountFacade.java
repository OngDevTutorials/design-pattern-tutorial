public class BankAccountFacade {
    private String accountName;
    private int securityCode;

    AccountChecker accountChecker;
    SecurityCodeChecker securityCodeChecker;
    CashManager cashManager;
    public BankAccountFacade(String accountName, int securityCode) {
        this.accountName = accountName;
        this.securityCode = securityCode;

        accountChecker = new AccountChecker(accountName);
        securityCodeChecker = new SecurityCodeChecker(securityCode);
        cashManager = new CashManager(1000.00);
    }

    public void depositCash(double cashAmount) {
        if(accountChecker.isValid(accountName) && securityCodeChecker.isValid(securityCode)) {
            cashManager.deposit(cashAmount);
            System.out.println("Xong goi");
        } else {
            System.out.println("Hong pe oi");
        }
    }

    public void withdrawCash(double cashAmount) {
        if(accountChecker.isValid(accountName)
                && securityCodeChecker.isValid(securityCode)
                && cashManager.haveEnoughMoney(cashAmount)) {
            cashManager.withdraw(cashAmount);
            System.out.println("Xong goi");
        } else {
            System.out.println("Hong pe oi");
        }
    }
}

















