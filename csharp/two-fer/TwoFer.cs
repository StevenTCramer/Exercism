public static class TwoFer
{
  public static string Name(string? aName = null)
  {
    if (string.IsNullOrWhiteSpace(aName))
      aName = "you";

    return $"One for {aName}, one for me.";
  }
}
