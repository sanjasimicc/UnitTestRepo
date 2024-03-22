namespace PrimeService.Tests;

public class LeapYearTests
{
    [Fact]
    public void LeapYear_IsLeapYear_ReturnTrue()
    {
        var leapYear = new LeapYear();
        bool result = leapYear.IsLeapYear(2000);
        Assert.True(result);
    }

     [Fact]
     public void LeapYear_IsLeapYear_ReturnFalse()
    {
        var leapYear = new LeapYear();
        bool result = leapYear.IsLeapYear(2001);
        Assert.False(result);
    }
}