using System;

namespace Xndir51_60 {
    class Program {
        static void xndir51() {
            Console.Write("Number = ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            int miavor = number % 10;
            int tasnavor = number / 10 % 10;
            int haryuravor = number / 100;

            bool t = false;
            if (miavor == tasnavor + haryuravor) {
                t = true;
            }
            Console.WriteLine(t);
        }

        static void xndir52() {
            Console.Write("Number = ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            int miavor = number % 10;
            int tasnavor = number / 10 % 10;
            int haryuravor = number / 100;

            bool t = false;
            if (miavor == tasnavor || tasnavor == haryuravor || haryuravor == miavor) {
                t = true;
            }
            Console.WriteLine(t);
        }

        static void xndir53() {
            Console.Write("Number = ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("K = ");
            int k = Convert.ToInt32(Console.ReadLine());
            
            int miavor = number % 10;
            int tasnavor = number / 10 % 10;
            int haryuravor = number / 100;
            
            if (number > k) {
                int gumariHaraberutyun = number / (miavor + tasnavor + haryuravor);
                Console.WriteLine($"Gumari haraberutyun = {gumariHaraberutyun}");
            } else {
                int gumariHaraberutyun = number / miavor;
                Console.WriteLine($"Gumari haraberutyun = {gumariHaraberutyun}");
            }
        }

        static void xndir54() {
            Console.Write("Number = ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            int miavor = number % 10;
            int tasnavor = number / 10 % 10;
            int haryuravor = number / 100;

            int max = miavor;
            if (max < tasnavor) {
                max = tasnavor;
            }
            if (max < haryuravor) {
                max = haryuravor;
            }

            Console.WriteLine($"Max = {max}");
        }

        static void xndir55() {
            Console.Write("Number = ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            int miavor = number % 10;
            int tasnavor = number / 10 % 10;
            int haryuravor = number / 100;

            int min = miavor;
            if (min > tasnavor) {
                min = tasnavor;
            }
            if (min > haryuravor) {
                min = haryuravor;
            }

            Console.WriteLine($"Min = {min}");
        }

        static void xndir56() {
            Console.Write("Number = ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            int miavor = number % 10;
            int tasnavor = number / 10 % 10;
            int haryuravor = number / 100;

            if (miavor > tasnavor) {
                Console.WriteLine($"Gumari haraberutyun = {number / (miavor + tasnavor + haryuravor)}");
            }
        }

        static void xndir57() {
            int miavor, tasnavor, haryuravor, number;
            do {
                Console.Write("Number = ");
                number = Convert.ToInt32(Console.ReadLine());
                
                miavor = number % 10;
                tasnavor = number / 10 % 10;
                haryuravor = number / 100;
                if (miavor == 0) {
                    Console.WriteLine("Xndrum enq, vor mutqagrac tvi miavor@ lini 0-ic tarber");
                }
            } while (miavor == 0);

            if (number > 300) {
                Console.WriteLine($"Tasnavori ev miavori haraberutyun = {tasnavor / miavor}");
            }
            else {
                Console.WriteLine($"Haryuravori ev miavori haraberutyun = {haryuravor / miavor}");
            }
        }

        static void xndir58() {
            Console.Write("Number = ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            int miavor = number % 10;
            int tasnavor = number / 10 % 10;
            int haryuravor = number / 100;

            char f = 'b';
            if  (tasnavor + haryuravor < 5) {
                f = 'a';
            }
            Console.WriteLine(f);
        }

        static void xndir59() {
            Console.Write("Number = ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            int miavor = number % 10;
            int tasnavor = number / 10 % 10;
            int haryuravor = number / 100;

            int max = miavor;
            if (max < tasnavor) {
                max = tasnavor;
            }
            if (max < haryuravor) {
                max = haryuravor;
            }

            int min = miavor;
            if (min > tasnavor) {
                min = tasnavor;
            }
            if (min > haryuravor) {
                min = haryuravor;
            }

            int mid = (miavor + tasnavor + haryuravor) - (max + min);

            Console.WriteLine($"Yst achman kargi ::: {min} ; {mid} ; {max}");
        }

        static void xndir60() {
            Console.Write("Number = ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            int miavor = number % 10;
            int tasnavor = number / 10 % 10;
            int haryuravor = number / 100;

            int max = miavor;
            if (max < tasnavor) {
                max = tasnavor;
            }
            if (max < haryuravor) {
                max = haryuravor;
            }

            int min = miavor;
            if (min > tasnavor) {
                min = tasnavor;
            }
            if (min > haryuravor) {
                min = haryuravor;
            }

            int mid = (miavor + tasnavor + haryuravor) - (max + min);

            Console.WriteLine($"Yst nvazman kargi ::: {max} ; {mid} ; {min}");
        }
        static void Main(string[] args) {
            xndir51();
            //xndir52();
            //xndir53();
            //xndir54();
            //xndir55();
            //xndir56();
            //xndir57();
            //xndir58();
            //xndir59();
            //xndir60();
        }
    }
}
