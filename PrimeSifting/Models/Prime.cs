using System.Collections.Generic;
using System;

namespace PrimeSifting.Models
{
  public class Prime
  {
    
    public int Numbers { get; set; }
    private static List<Prime> _instances = new List<Prime> {};
    public Prime(int numbers)
    {
      Numbers = numbers;
      _instances.Add(this);
    }

    public static List<Prime> PrimeNumbers()
    {
      return _instances;
    }
    /* 
      UI:
      WriteLine("input a number");
      string stringNumber = ReadLine();
      int number = Parse.Int(stringNumber);
      Prime(number)
     */
  }
}