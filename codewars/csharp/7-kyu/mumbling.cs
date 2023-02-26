using System;
using System.Linq;
public class Accumul
{
    public static String Accum(string s)
    {
        return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
}

/*Other solutions

using System;

public class Accumul 
{
	public static String Accum(string s) 
  {
     // your code
    string result = "";
    char[] stringArray;
    stringArray = s.ToCharArray();
    for (int i = 0; i < stringArray.Length; i++)
    {
       char.ToLower(stringArray[i]); 
       for(int j = 0; j <= i; j++)
       {
           if (j == 0)
           {
               result = result + char.ToUpper(stringArray[i]);
           }
           else
           {
               result = result +  char.ToLower(stringArray[i]);
           }
       }
       if (i != stringArray.Length - 1)
       {
           result = result + '-';
       }
       
    }
    return result;  
  }
}


*/
