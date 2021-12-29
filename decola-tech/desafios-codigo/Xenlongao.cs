using System;


namespace Dio
{
    class Xenlongao
    {   
        static void Main(string[] args)
        {
            int casosTeste = Convert.ToInt32(Console.ReadLine());
            int numeroEsferas = Convert.ToInt32(Console.ReadLine());
            int minimoEsferas = 0;
            
            while (casosTeste > 0)
            {
                minimoEsferas = (int)Math.Sqrt(numeroEsferas);
                casosTeste--;
            }
            Console.WriteLine(numeroEsferas - minimoEsferas);
        }
    }
}