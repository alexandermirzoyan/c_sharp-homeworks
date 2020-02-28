using System;

namespace Xndir1_15 {
    class Program {
        static void xnidr1() {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 100; i++) {
                if (i % n == 0) {
                    Console.Write($"{i}; ");
                }
            }
        }

        static void xnidr2() {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= 100; i++) {
                if (i % n == 2) {
                    sum += i;
                }
            }
            Console.WriteLine($"1-100 tver@ {n}-in bajanelis mnacord kmna 2-i gumar@ = {sum}");
        }

        static void xnidr3() {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3-i bajanvox tver@ 100-1000 mijakayqum`");
            for (int i = 100; i <= 1000; i++) {
                if (i % n == 3) {
                    Console.Write($"{i}; ");
                }
            }
        }

        static void xnidr4() {
            Console.WriteLine("3-in bazmapatik erknish tver@`");
            for (int i = 10; i <= 99; i++) {
                if (i % 3 == 0) {
                    Console.Write($"{i}; ");
                }
            }
        }

        static void xnidr5() {
            int sum = 0;
            for (int i = 10; i <= 99; i++) {
                if ((i % 3 == 0) && (i % 5 == 0)) {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        static void xndir6() {
            int art = 1;
            for (int i = 100; i <= 999; i++) {
                if (i % 5 != 0) {
                    art *= i;
                }
            }
            Console.WriteLine(art);
        }

        static void xndir7() {
            for (int i = 100; i <= 999; i++) {
                if ((i % 2 != 0) && (i % 3 != 0)) {
                    Console.Write($"{i}; ");
                }
            }
        }

        static void xndir8() {
            for (int i = 100; i <= 999; i++) {
                if ((i % 3 == 1) || (i % 4 == 2)) {
                    Console.Write($"{i}; ");
                }
            }
        }

        static void xndir9() {
            for (int i = 100; i <= 999; i++) {
                if (Math.Sqrt(i * 10) % 2 == 0 || Math.Sqrt(i * 10) % 2 == 1) {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void xndir10() {
            for (int i = 1000; i <= 9999; i++) {
                if (Math.Sqrt(i * 26) % 2 == 0 || Math.Sqrt(i * 26) % 2 == 1) {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void xndir11() {
            for (int i = 9999; i >= 1000; i--) {
                if (Math.Sqrt(i * 14) % 2 == 0 || Math.Sqrt(i * 14) % 2 == 1) {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void xndir12() {
            for (int i = 999; i >= 100; i--) {
                if (Math.Sqrt(i * 18) % 2 == 0 || Math.Sqrt(i * 18) % 2 == 1) {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void xndir13() {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 100; i <= 999; i++) {
                if (Math.Sqrt(i) > n) {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static bool checkIfIsPowerOf3(int n) {
            /* The maximum power of 3 value that integer can hold is 1162261467 ( 3^19 ) .*/
            // /www.geeksforgeeks.org/find-whether-given-integer-power-3-not/
            return 1162261467 % n == 0;
        }
        static bool checkIfIsPowerOf4(int n) {
            // www.geeksforgeeks.org/find-whether-a-given-number-is-a-power-of-4-or-not/
            return n != 0 && ((n & (n - 1)) == 0) && (n & 0xAAAAAAAA) == 0;
        }
        static void xndir14() {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool t = false;
            if (checkIfIsPowerOf3(n)) {
                t = true;
            }

            Console.WriteLine(t);
        }

        static void xndir15() {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool t = false;
            if (checkIfIsPowerOf4(n)) {
                t = true;
            }

            Console.WriteLine(t);
        }

        static void Main(string[] args) {
            xnidr1();
            //xnidr2();
            //xnidr3();
            //xnidr4();
            //xnidr5();
            //xndir6();
            //xndir7();
            //xndir8();
            //xndir9();
            //xndir10();
            //xndir11();
            //xndir12();
            //xndir13();
            //xndir14();
            //xndir15();
        }
    }
}
