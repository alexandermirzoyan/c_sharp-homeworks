using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 4 digit number");
            Console.Write("Number = ");
            int inputedNumber = Convert.ToInt32(Console.ReadLine());
            int haz = inputedNumber / 1000;
            int har = inputedNumber / 100 % 10;
            int tas = inputedNumber / 10 % 10;
            int miav = inputedNumber % 10;

            int min = miav;

            Console.WriteLine($"Hazaravor = {haz}");
            Console.WriteLine($"Haryuravor = {har}");
            Console.WriteLine($"Tasnavor = {tas}");
            Console.WriteLine($"Miavor = {miav}");

            if (min > tas) {
                min = tas;
            }
            if (min > har) {
                min = har;
            }
            if (min > haz) {
                min = haz;
            }

            Console.WriteLine($"Min value = {min}");
        }
    }
}
