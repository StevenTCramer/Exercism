public static class Leap
{
  public static bool IsLeapYear(int aYear) =>
    aYear % 4 == 0 &&  (aYear % 100 != 0 || aYear % 400 == 0);
}