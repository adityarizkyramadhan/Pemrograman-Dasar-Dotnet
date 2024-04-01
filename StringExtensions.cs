using System.Globalization;

public class StringExtensions
{
  public static int CountCharacters(string input)
  {
    int count = 0;
    if (string.IsNullOrEmpty(input))
    {
      return count;
    }
    var enumerator = StringInfo.GetTextElementEnumerator(input);
    while (enumerator.MoveNext())
    {
      count++;
    }
    return count;
  }
}
