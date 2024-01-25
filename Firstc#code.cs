using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Ethan Collier"; //My name
      int many = 1500; //What I could probably afford for a new laptop
      int slight = 700; //Probably about what I'll get in my tax return
     int results = many-slight; //What I still need to find somehow
      Console.WriteLine(name);
      Console.WriteLine("I need $");
      Console.WriteLine(results);
     }
  }
}
