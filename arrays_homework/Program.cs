using System;
using System.Collections.Generic;

namespace arrays_homework {
    class Program {

        static void xndir1() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int negativeNumberCount = 0;

            // ete 0 tanq, kara negativ tiv chlini u asi vor negativi index@ = 0. Dra hamar talis enq null
            Nullable<int> negativeElementIndex = null;

            int randomNumberMin = -100;
            int randomNumberMax = 100;

            for (int i = 0; i < arr.Length; i++) {
                int randomNumber = random.Next(randomNumberMin, randomNumberMax);
                arr[i] = randomNumber;
                if (arr[i] < 0) {
                    randomNumberMin = 0;
                    negativeElementIndex = i;
                    negativeNumberCount++;
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            Console.WriteLine($"Bacasakan tveri qanak = {negativeNumberCount}");
            if (negativeElementIndex != null) {
                Console.WriteLine($"Bacasakan arjeqi index@ = {negativeElementIndex}");
            }
        }

        static void xndir2() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int sumOfEvenIndexes = 0;
            int sumOfEvenIndexesElements = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);
                if (i % 2 == 0) {
                    sumOfEvenIndexes += i;
                    sumOfEvenIndexesElements += arr[i];
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Zuyg index unecoxneri gumar@ = {sumOfEvenIndexes}");
            Console.WriteLine($"Zuyg index unecoxneri elementneri gumar@ = {sumOfEvenIndexesElements}");
        }

        static void xndir3() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            List<int> arr = new List<int>();
            List<int> chkrknvoxArr = new List<int>();
            Random random = new Random();

            for (int i = 0; i < n; i++) {
                arr.Add(random.Next(10, 20));
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            for (int i = 0; i < n; i++) {
                int krknvox = 0;
                for (int j = 0; j < i - 1; j++) {
                    if (arr[i] == arr[j]) {
                        krknvox++;
                    }
                }
                for (int k = i + 1; k < n; k++) {
                    if (arr[i] == arr[k]) {
                        krknvox++;
                    }
                    if (arr[i] == arr[i+1]) {
                        i++;
                    }
                }
                if(krknvox == 0) {
                    chkrknvoxArr.Add(arr[i]);
                }
            }

            for (int i = 0; i < chkrknvoxArr.Count; i++) {
                Console.WriteLine($"chkrknvoxArr[{i}] = {chkrknvoxArr[i]}");
            }
        }

        static void Main(string[] args) {
            xndir1();
            //xndir2();
            //xndir3();
        }
    }
}
