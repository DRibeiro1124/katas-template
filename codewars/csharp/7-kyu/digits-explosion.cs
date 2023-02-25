using System;
using System.Linq;

public class Digits
{
    public static string Explode(string s)
    {
        return string.Join("", s.Select(answer => new String(answer, int.Parse(answer.ToString()))));
    }
}