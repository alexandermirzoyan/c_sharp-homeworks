using System;

namespace ampopich_xndir {
    class Program {
        static void Main(string[] args) {
            int inputedNumber;
            bool t;

            do {
                Console.Write("Number = ");
                string inputedString = Console.ReadLine();
                t = int.TryParse(inputedString, out inputedNumber);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please input again!");
                Console.ResetColor();
            } while ((t == false) && (inputedNumber) > 1000 || (inputedNumber) < 999);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Duq mutqagrel eq {inputedNumber}");
            Console.ResetColor();
            int miavor = inputedNumber % 10;
            int tasnavor = inputedNumber / 10 % 10;
            int haryuravor = inputedNumber / 100 % 10;
            int hazaravor = inputedNumber / 1000;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Tasnavori ev haryuravori qanord@ = {tasnavor / haryuravor}");
            Console.WriteLine();
            Console.ResetColor();

            int sorted = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Yst achman kargi` ");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; sorted < 4; i++) {
                int numberOfSorted = 0;
                if (i == miavor) {
                    sorted++;
                    numberOfSorted++;
                }
                if (i == tasnavor) {
                    sorted++;
                    numberOfSorted++;
                }
                if (i == haryuravor) {
                    sorted++;
                    numberOfSorted++;
                }
                if (i == hazaravor) {
                    sorted++;
                    numberOfSorted++;
                }
                for (int j = 0; j < numberOfSorted; j++) {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Dzevapoxutyunic araj");
            Console.WriteLine(inputedNumber);
            Console.ResetColor();

            // swap hazaravor and miavor
            int tmp = hazaravor;
            hazaravor = miavor;
            miavor = tmp;

            int afterSwap = Convert.ToInt32(hazaravor + "" + haryuravor + "" + tasnavor + "" + miavor);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Dzevapoxutyunic heto");
            Console.WriteLine(afterSwap);
            Console.ResetColor();
            Console.WriteLine();

            if (afterSwap > inputedNumber) {
                Console.Write("Dzevapoxvac tiv@ aveli mec e = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(true);
                Console.ResetColor();
            } else {
                Console.Write("Dzevapoxvac tiv@ aveli mec e = ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(false);
                Console.ResetColor();
            }
        }
    }
}
