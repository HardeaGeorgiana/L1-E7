using System;

namespace L1_E7
{
    /* Scrieti un program care va verifica daca un numar
       citit de la tastatura este par sau impar
    */
    class Program
    {
        static void Main(string[] args)
        {
            int numar;

            Console.WriteLine("Introduceti un numar");
            numar = int.Parse(Console.ReadLine());

            if (numar % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            
        }
    }
}
