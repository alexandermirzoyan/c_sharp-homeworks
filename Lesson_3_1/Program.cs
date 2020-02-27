using System;

namespace Lesson_3_1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Number 1 = ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2 = ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3 = ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 4 = ");
            int number4 = Convert.ToInt32(Console.ReadLine());

            int max = number1;
            if (max < number2) {
                max = number2;
            }
            if (max < number3) {
                max = number3;
            }
            if (max < number4) {
                max = number4;
            }

            int min = number2;
            if (min > number1) {
                min = number1;
            }
            if (min > number3) {
                min = number3;
            }
            if (min > number4) {
                min = number4;
            }

            Console.WriteLine($"Max = {max}, Min = {min}");
        }
    }
}
