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
