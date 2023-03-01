//In C# Write function RemoveExclamationMarks which removes all exclamation marks from a given string.

using System;
public class Kata
{
    public static string RemoveExclamationMarks(string s)
    {
        return s.Replace("!", "");
    }
}

/* OTHER SOLUTIONS FROM USERS IN CODEWARS:

public class Kata
{
  public static string RemoveExclamationMarks(string s) => s.Replace("!", "");
}

public class Kata
{
  public static string RemoveExclamationMarks(string s) => s.Replace("!", string.Empty);
}

public class Kata
{
  public static string RemoveExclamationMarks(string s) => string.Join("", s.Split('!'));
}

*/

