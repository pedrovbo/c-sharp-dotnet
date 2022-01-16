using System;

class DIO
{

   static void Main(string[] args)
   {

       for (int i = 1; i <= 9; i = i*3)
       {
           for (int j = 7; j >= 5; j--)
           {
               Console.WriteLine($"I={i} J={j}");
           }
       }
   }

}