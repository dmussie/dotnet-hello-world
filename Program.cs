using System;

namespace dotnet_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


//Opposties attract katas
using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        //Moment of truth...
      if (flower1%2 == 0 || flower2%2 == 0) 
      {
        return true;
      }
      else
      {
        return false;
      }
    }
}

// You only need one kata (need clarification on this)
public class Kata
{
  public static bool Check(object[] a, object x)
  {
    if (a.Equals(x))
  {
    return true;
  }
    else
  {
    return false;
  }
  }
}

// Sum of postivies kata 
using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    // Your code here
    int sum = 0;
    for (int i=0; i < arr.Length; i++)
    {
      if (arr[i] > 0) 
        sum += arr[i];
    }
    return sum;
  }
}
