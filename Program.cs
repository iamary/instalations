// See https://aka.ms/new-console-template for more information

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("enter your age:");
      int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(""+age); 
    }
  }
}
