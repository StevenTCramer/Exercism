using System;

public static class Gigasecond
{
  public static DateTime Add(DateTime aMoment) => aMoment.AddSeconds(1e9);
}