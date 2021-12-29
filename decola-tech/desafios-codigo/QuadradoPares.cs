using System;

class DIO
{

    static void Main(string[] args)
    {

        int numeroLimite = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroLimite; i++)
        {

            if (i % 2 == 0)
            {
                Console.WriteLine($"{i}^{2} = {(long)Math.Pow(i, 2)}");
            }
        }

    }

}