using System;

namespace Cas20
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ovo je moj prvi program
             * viselinijski komentar */
             Console.WriteLine("koji je tvoj omiljeni broj?");

            int mojBroj = Convert.ToInt32(Console.ReadLine());
            
           

            Console.WriteLine("Kvadrat tvog omiljenog broja je  " + mojBroj * mojBroj);


            // Ovo je jednolinijski komentar
            Console.ReadKey();
        }
    }
}
