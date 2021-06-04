using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Pangram
{
  //public static bool IsPangram(string input)
  //{
  //  // if lenght < 26 return false
  //  // if remaining length is ever less than number left then return false.
  //  //
  //  int offset = Encoding.ASCII.GetBytes("A")[0];
  //  int min = offset;
  //  int max = Encoding.ASCII.GetBytes("Z")[0];
  //  byte[] asciiBytes = Encoding.ASCII.GetBytes(input.ToUpper());
  //  bool[] map = new bool[max-min+1];
  //  foreach (byte letter in asciiBytes)
  //  {
  //    if(letter >= min && letter <= max) map[letter - offset] = true;
  //  }
  //  return map.All(aX => aX == true);
  //}

  //public static bool IsPangram(string input)
  //{
  //  int min = Encoding.ASCII.GetBytes("A")[0];
  //  int max = Encoding.ASCII.GetBytes("Z")[0];
  //  int letterCount = max - min + 1;
  //  byte[] asciiBytes = Encoding.ASCII.GetBytes(input.ToUpper());
  //  HashSet<byte> hashSet = new HashSet<byte>(asciiBytes.Where(aLetter => aLetter >= min && aLetter <= max));
  //  return hashSet.Count == letterCount;
  //}

  public static bool IsPangram(string input) => 
    input
      .ToLower()
      .Where(aL => char.IsLetter(aL))
      .Distinct()
      .Count() 
      == 26;
}
