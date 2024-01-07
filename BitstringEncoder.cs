using System;
using System.Text;

namespace Jvu.Test.SharedLib.NoDeps
{
  public class BitstringEncoder
  {
    public string ConvertStringToBinary(string inputString)
    {
      var sb = new StringBuilder();

      foreach(var ch in inputString.ToCharArray())
      {
        var binary = Convert.ToString(ch, 2).PadLeft(8, '0');
        sb.Append(binary);
      }

      return sb.ToString();
    }

    public string ConvertBinaryToString(string binaryString)
    {
      // ensure binary string length is multiple of 8
      int remainder = binaryString.Length % 8;
      if (remainder != 0)
      {
        throw new ArgumentException("Invalid binary string length.");
      }

      var sb = new StringBuilder();

      // convert each 8 bit chunk back to a char
      for (int i = 0; i < binaryString.Length; i += 8)
      {
        string chunk = binaryString.Substring(i, 8);
        char ch = (char) Convert.ToByte(chunk, 2);
        sb.Append(ch);
      }

      return sb.ToString();
    }
  }
}
