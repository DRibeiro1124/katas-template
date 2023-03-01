using System;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        static bool IsIsogram(string str)
        {
            str = str.ToLower();
            int size = str.Length;

            char[] arr = str.ToCharArray();

            Array.Sort(arr);
            for (var i = 0; i < size; i++)
            {
                if (arr[i] == arr[i + 1])
                    return false;
            }
            return true;
        }
    }
}

/*
-Couldn't figure out how to beat this Kata and got the answer online. 
-Found other solutions that I don't quite understand yet. 

using System;
using System.Linq;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    // Code on you crazy diamond!
    return str.ToUpper().GroupBy(s => s).All(s => s.Count() <= 1);
  }
}

-Will come back at later time and see if I can figure this out without help
*/