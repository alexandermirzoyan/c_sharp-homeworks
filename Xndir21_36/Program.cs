using System;

namespace Xndir21_36 {
    class Program {
        static void xndir21() {
            Random random = new Random();

            int a = random.Next(1, 100);
            int b = random.Next(1, 100);
            int c = random.Next(1, 100);

            if (a != b && b != c) {
                int max = a;
                if (max < b) {
                    max = b;
                }
                if (max < c) {
                    max = c;
                }
                Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");
                Console.WriteLine($"MAX = {max}");
            }
            else {
                Console.WriteLine("Please reRun the program, numbers are equal each other");
            }
        }
        static void xndir22() {
            Random random = new Random();

            int a = random.Next(1, 100);
            int b = random.Next(1, 100);
            int c = random.Next(1, 100);
            if (a != b && b != c) {
                int min = a;
                if (min > b) {
                    min = b;
                }
                if (min > c) {
                    min = c;
                }
                Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");
                Console.WriteLine($"MIN = {min}");
            }
            else {
                Console.WriteLine("Please reRun the program, numbers are equal each other");
            }
        }
        static void xndir23() {
            Random random = new Random();

            int a = random.Next(1, 5);
            int b = random.Next(1, 5);
            int c = random.Next(1, 5);
            Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");

            if ((a != b && b != c) && (a == 1 || b == 1 || c == 1)) {
                Console.WriteLine("true");
            }
            else {
                Console.WriteLine("false");
            }
        }
        static void xndir24() {
            Random random = new Random();

            int a = random.Next(1, 3);
            int b = random.Next(1, 3);
            int c = random.Next(1, 3);
            Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");

            if ((a != b && b != c) && (a == 2 && b == 2 || a == 2 && c == 2 || b == 2 && c == 2)) {
                Console.WriteLine("true");
            }
            else {
                Console.WriteLine("false");
            }
        }
        static void xndir25() {
            Random random = new Random();

            int a = random.Next(1, 5);
            int b = random.Next(1, 5);
            int c = random.Next(1, 5);
            Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");

            //cankacac 2 koxmeri gumar@ petq e mec lini 3rd koxmic
            if ((a != b && b != c) && (a + b > c || b + c > a || a + c > b)) {
                Console.WriteLine("y=1");
            }
            else {
                Console.WriteLine("y=2");
            }
        }
        static void xndir26() {
            Random random = new Random();

            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);
            Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");

            if ((a != b && b != c) && (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)) {
                Console.WriteLine("1");
            }
            else {
                Console.WriteLine("2");
            }
        }
        static void xndir27() {
            Random random = new Random();

            int a = random.Next(1, 30);
            int b = random.Next(1, 30);
            int c = random.Next(1, 30);
            Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");

            // mejtexi tvic hanum enq arajin@, ete havasar e verjinic hanac mejtexin@ => tvabanakan progresia
            if ((a != b && b != c) && (b - a == c - b)) {
                Console.WriteLine("true");
            }
            else {
                Console.WriteLine("false");
            }
        }
        static void xndir28() {
            Random random = new Random();

            int a = random.Next(1, 30);
            int b = random.Next(1, 30);
            int c = random.Next(1, 30);
            Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");

            // mejtexi tiv@ bajanum enq arajinin, ete havasar e verjini tiv@ bajanac mejtexinin => erkrachapakan progresia
            if ((a != b && b != c) && (b / a == c / b)) {
                Console.WriteLine("true");
            }
            else {
                Console.WriteLine("false");
            }
        }
        static void xndir29() {
            Random random = new Random();

            int a = random.Next(1, 30);
            int b = random.Next(1, 30);
            int c = random.Next(1, 30);
            Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");

            int max, min;
            if (a > b) {
                max = a;
                min = b;
            }
            else {
                max = b;
                min = a;
            }
            
            if (max < c) {
                max = c;
            }
            if (min > c) {
                min = c;
            }

            int mid = (a + b + c) - (max + min);
            Console.WriteLine();
            Console.WriteLine($"MIN = {min} \nMID = {mid} \nMAX={max}");
        }
        static void xndir30() {
            Random random = new Random();

            int a = random.Next(1, 30);
            int b = random.Next(1, 30);
            int c = random.Next(1, 30);
            Console.WriteLine($"A = {a} \nB = {b} \nC = {c}");

            int max, min;
            if (a > b) {
                max = a;
                min = b;
            }
            else {
                max = b;
                min = a;
            }

            if (max < c) {
                max = c;
            }
            if (min > c) {
                min = c;
            }

            int mid = (a + b + c) - (max + min);
            Console.WriteLine();
            Console.WriteLine($"MAX = {max} \nMID = {mid} \nMIN={min}");
        }
        static void xndir31() {
            Random random = new Random();

            int a = random.Next(1, 30);
            int b = random.Next(1, 30);
            int c = random.Next(1, 30);
            int d = random.Next(1, 30);
            if (a != b && b != c && c!= d) {
                Console.WriteLine($"A = {a} \nB = {b} \nC = {c} \nD = {d}");

                int max = a;
                if (max < b) {
                    max = b;
                }
                if (max < c) {
                    max = c;
                }
                if (max < d) {
                    max = d;
                }
                Console.WriteLine($"MAX = {max}");
            }
            else {
                Console.WriteLine("Please reRun the program, numbers are equal each other");
            }
        }
        static void xndir32() {
            Random random = new Random();

            int a = random.Next(1, 30);
            int b = random.Next(1, 30);
            int c = random.Next(1, 30);
            int d = random.Next(1, 30);
            if (a != b && b != c && c != d) {
                Console.WriteLine($"A = {a} \nB = {b} \nC = {c} \nD = {d}");

                int min = a;
                if (min > b) {
                    min = b;
                }
                if (min > c) {
                    min = c;
                }
                if (min > d) {
                    min = d;
                }
                Console.WriteLine($"MIN = {min}");
            }
            else {
                Console.WriteLine("Please reRun the program, numbers are equal each other");
            }
        }
        static void xndir33() {
            Random random = new Random();

            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);
            int d = random.Next(1, 10);
            if (a != b && b != c && c != d) {
                Console.WriteLine($"A = {a} \nB = {b} \nC = {c} \nD = {d}");

                if (a == 1 || b == 1 || c == 1 || d == 1) {
                    Console.WriteLine("true");
                }
                else {
                    Console.WriteLine("false");
                }
            }
            else {
                Console.WriteLine("Please reRun the program, numbers are equal each other");
            }
        }
        static void xndir34() {
            Random random = new Random();

            //int a = random.Next(1, 30);
            //int b = random.Next(1, 30);
            //int c = random.Next(1, 30);
            //int d = random.Next(1, 30);
            int a = 2;
            int b = 4;
            int c = 1;
            int d = 5;
            if (a != b && b != c && c != d) {
                Console.WriteLine($"A = {a} \nB = {b} \nC = {c} \nD = {d}");

                if (a + b == c + d || a + c == b + d || a + d == c + b) {
                    Console.WriteLine("true");
                }
                else {
                    Console.WriteLine("false");
                }
            }
            else {
                Console.WriteLine("Please reRun the program, numbers are equal each other");
            }
        }
        static void xndir35() {
            Random random = new Random();

            //int a = random.Next(1, 30);
            //int b = random.Next(1, 30);
            //int c = random.Next(1, 30);
            //int d = random.Next(1, 30);
            int a = 1;
            int b = 6;
            int c = 3;
            int d = 10;
            if (a != b && b != c && c != d) {
                Console.WriteLine($"A = {a} \nB = {b} \nC = {c} \nD = {d}");

                if (a == b + c + d || b == a + c + d || c == a + b + d || d == a + b + c) {
                    Console.WriteLine("true");
                }
                else {
                    Console.WriteLine("false");
                }
            }
            else {
                Console.WriteLine("Please reRun the program, numbers are equal each other");
            }
        }
        static void xndir36() {
            Random random = new Random();

            //int a = random.Next(1, 30);
            //int b = random.Next(1, 30);
            //int c = random.Next(1, 30);
            //int d = random.Next(1, 30);
            int a = 6;
            int b = 1;
            int c = 3;
            int d = 4;
            if (a != b && b != c && c != d) {
                Console.WriteLine($"A = {a} \nB = {b} \nC = {c} \nD = {d}");

                if ((a % 2 != 0 && b % 2 != 0) || (a % 2 != 0 && c % 2 != 0) ||
                    (a % 2 != 0 && d % 2 != 0) || (b % 2 != 0 && a % 2 != 0) ||
                    (b % 2 != 0 && c % 2 != 0) || (b % 2 != 0 && d % 2 != 0) ||
                    (c % 2 != 0 && a % 2 != 0) || (c % 2 != 0 && b % 2 != 0) ||
                    (c % 2 != 0 && d % 2 != 0) || (d % 2 != 0 && a % 2 != 0) ||
                    (d % 2 != 0 && b % 2 != 0) || (d % 2 != 0 && c % 2 != 0)) {
                    Console.WriteLine("true");
                }
                else {
                    Console.WriteLine("false");
                }
            }
            else {
                Console.WriteLine("Please reRun the program, numbers are equal each other");
            }
        }
        static void Main(string[] args) {
            xndir21();
            //xndir22();
            //xndir23();
            //xndir24();
            //xndir25();
            //xndir26();
            //xndir27();
            //xndir28();
            //xndir29();
            //xndir30();
            //xndir31();
            //xndir32();
            //xndir33();
            //xndir34();
            //xndir35();
            //xndir36();
        }
    }
}
