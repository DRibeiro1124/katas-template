using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
    public static int GetAverage(int[] marks)
    {
        return marks.Sum() / marks.Length;
    }
}

/* OTHER SOLUTIONS:

using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
    return (int)marks.Average();
  }
}
-----------------------------------------------------
using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
      return (int)(Math.Floor(marks.Average()));
  }
}

-----------------------------------------------------
using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
      return (int)(Math.Floor(marks.Average()));
  }
}
-----------------------------------------------------
