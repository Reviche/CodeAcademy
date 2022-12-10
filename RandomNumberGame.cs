using System;

namespace Review
{
  class program
  {
    static void Main(string[] args)
    {
     //Console.WriteLine("Pick a number 1-10");
   // Random rnd = new Random();
    Console.WriteLine("Pick a number 1-1000");
    double userNumber = Convert.ToDouble(Console.ReadLine());
    Random rnd = new Random();

  int random = rnd.Next(1,1000);
  
 while (userNumber != random)
  {

if (userNumber > random)
{
  Console.WriteLine("Too High, try again!");
  userNumber = Convert.ToDouble(Console.ReadLine());
} 
else
{
Console.WriteLine("Too Low, try again!");
userNumber = Convert.ToDouble(Console.ReadLine());
}
  }
  if (userNumber == random)
{
  Console.WriteLine("You Picked Correctly!");
}
    }
  }
}
