public class SecurityCodeChecker {
    private int securityCode;
    public SecurityCodeChecker(int secCode) {
        securityCode = secCode;
    }

    public boolean isValid(int secCode) {
        return securityCode == secCode;
    }
}
