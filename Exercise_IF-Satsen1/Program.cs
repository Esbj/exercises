using System;

namespace Exercise_IF_Satsen1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Är det fint väder?");

                string fintVäder = Console.ReadLine();
                string awnser = fintVäder.ToUpper();
                
                if (awnser == "J"){
                    Console.WriteLine("Vi går på en promenad!");
                }else if (awnser == "N"){
                    Console.WriteLine("Vi stannar inne och läser en bok!");
                }
            }
        }
    }
}
