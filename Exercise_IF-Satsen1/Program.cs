using System;

namespace Exercise_IF_Satsen1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Är det fint väder?");
            string fintVäder = Console.ReadLine();

            if (fintVäder == "J"){
                Console.WriteLine("Vi går på en promenad!");
            }else if (fintVäder == "N"){
                Console.WriteLine("Vi stannar inne och läser en bok!");

                //testar att git fungerar på hemdator
            }
        }
    }
}
