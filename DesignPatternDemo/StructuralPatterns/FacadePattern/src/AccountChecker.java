public class AccountChecker {
    private String accName;
    public AccountChecker(String accountName) {
        accName = accountName;
    }

    public boolean isValid(String accountName) {
        return accName == accountName;
    }
}
