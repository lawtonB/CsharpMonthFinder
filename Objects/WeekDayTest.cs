using System.Collections.Generic;
using Xunit;
using WeekDaynamespace;


namespace  WeekDaynamespace
{
  public class WeekDayTest
  {
    // [Fact]
    // public void Testforinput_dayfinder_true()
    // {
    //   int daytest = 3;
    //
    //   Assert.Equal ("Wednesday", WeekDay.dayfinder(daytest));
    // }
    // [Fact]
    // public void Testforinput_monthfinder_true()
    // {
    //   int MonthTest = 15;
    //
    //   Assert.Equal ("Monday", WeekDay.dayfinder(MonthTest));
    // }
    [Fact]
    public void Testforinput_Daysarefunnny_Monday()
    {
      int month = 2;
      int day = 15;

      Assert.Equal ("Thursday", WeekDay.monthfinder(month,day));
    }
  }
}
