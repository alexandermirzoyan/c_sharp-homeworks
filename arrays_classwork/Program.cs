using System;

namespace arrays_classwork {
    class Program {
        static void Main(string[] args) {
            /*
            Console.Write("Input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100,100);
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            int max = arr[0], min = arr[0];
            int maxIndex = 0, minIndex = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (max < arr[i]) {
                max = arr[i];
                maxIndex = i;
                }
                if (min > arr[i]) {
                min = arr[i];
                minIndex = i;
                }
            }
        ​
            Console.WriteLine();
            Console.WriteLine("Before swaping");
            Console.WriteLine($"Max = {max}, Min = {min}");
        ​
            Console.WriteLine();
            Console.WriteLine("After swaping");
            int tmp = max;
            max = min;
            min = tmp;
            Console.WriteLine($"Max = {max}, Min = {min}");
        ​
            int tmp2 = arr[maxIndex];
            arr[maxIndex] = arr[minIndex];
            arr[minIndex] = tmp2;
        ​
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        ​
            Console.Write("Input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
        ​
            for (int i = 0; i < arr.Length; i++) {
                int randomNumber = random.Next(1,20);
                for (int j = 2; j < randomNumber/2; j++) {
                if (randomNumber % 2 != 0) {
                    randomNumber = 0;
                }
                }
                arr[i] = randomNumber;
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            */
​
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int t;
            Console.WriteLine("Original array :");
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 10);
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            for (int i = 0; i <= arr.Length; i++) {
                for (int j = 0; j <= arr.Length - 2; j++) {
                    if (arr[j] > arr[j + 1]) {
                        t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

        }
    }
}
