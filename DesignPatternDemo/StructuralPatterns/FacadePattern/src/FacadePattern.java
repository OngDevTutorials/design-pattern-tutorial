public class FacadePattern {
    public static void main(String[] args) {
        BankAccountFacade bankAccountFacade = new BankAccountFacade("ongdevacc", 1234);
        bankAccountFacade.withdrawCash(900000.00);
        bankAccountFacade.depositCash(1000000.00);

    }
}
