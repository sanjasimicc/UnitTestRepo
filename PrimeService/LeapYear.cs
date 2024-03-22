namespace PrimeService;

public class LeapYear
{
    public bool IsLeapYear(int year) {
        if ((year % 400 == 0) || ((year % 100 != 0) && (year % 4 == 0))) {
            return true;
        }

        return false;

    }

}
