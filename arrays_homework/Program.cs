using System;
using System.Collections.Generic;

namespace arrays_homework {
    class Program {

        static void xndir_teladrac_1() {
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

        static void xndir_teladrac_2() {
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

        static void xndir_teladrac_3() {
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

        static void xndir_1() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            double sum = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 2 == 0) {
                    sum += Math.Pow(arr[i], 2);
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Zuyg arjeq unecox tarreri qarakusineri gumar@ = {sum}");
        }

        static void xndir_2() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 2 == 0) {
                    count++;
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Zuyg arejq unecox tarreri qanak@ = {count}");
        }

        static void xndir_3() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int sum = 0;
            int artadryal = 1;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 2 == 0) {
                    artadryal *= arr[i];
                    sum += arr[i];
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Zuyg arejq unecox tarreri artadryal@ = {artadryal}");
            Console.WriteLine($"Zuyg arejq unecox tarreri gumar@ = {sum}");
        }

        static void xndir_4() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 2 != 0) {
                    sum += arr[i];
                    count++;
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            int average = sum / count;

            Console.WriteLine($"Kent arejq unecox tarreri mijin tvabanakan@ = {average}");
        }

        static void xndir_5() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            double sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 2 != 0) {
                    sum += Math.Pow(arr[i], 2);
                    count++;
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            double average = sum / count;

            Console.WriteLine($"Kent arejq unecox tarreri mijin qarakusayin@ = {average}");
        }

        static void xndir_6() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int artadryal = 1;
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 2 != 0) {
                    artadryal *= arr[i];
                    count++;
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Kent arejq unecox tarreri artadryal@ = {artadryal}");
            Console.WriteLine($"Kent arejq unecox tarreri qanak@ = {count}");
        }

        static void xndir_7() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-2, 2);
                if (arr[i] == 0) {
                    count++;
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Zro arejq unecox tarreri qanak@ = {count}");
        }

        static void xndir_8() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int count = 0;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 3 == 0) {
                    count++;
                    sum += arr[i];
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
                
            if (count != 0) {
                Console.WriteLine($"3-in bazmapatik tarreri mijin tvabanakan@ = {sum / count}");
            } else {
                Console.WriteLine($"3-in bazmapatik tarreri mijin tvabanakan@ = 0");
            }
        }

        static void xndir_9() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int count = 0;
            double sum = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 5 == 0) {
                    count++;
                    sum += Math.Pow(arr[i], 2);
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
                
            if (count != 0) {
                Console.WriteLine($"5-in bazmapatik tarreri mijin tvabanakan@ = {sum / count}");
            } else {
                Console.WriteLine($"5-in bazmapatik tarreri mijin tvabanakan@ = 0");
            }
        }

        static void xndir_10() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 7 == 0) {
                    count++;
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
                
            Console.WriteLine($"5-in bazmapatik tarreri qanak@ = {count}");
        }

        static void xndir_11() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please input K = ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % k == 0) {
                    sum += arr[i];
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
                
            Console.WriteLine($"{k}-in bazmapatik tarreri gumar@ = {sum}");
        }

        static void xndir_12() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please input M = ");
            int m = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int artadryal = 1;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % m == 0) {
                    artadryal *= arr[i];
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
                
            Console.WriteLine($"{m}-in bazmapatik tarreri artadryal@ = {artadryal}");
        }

        static void xndir_13() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please input T = ");
            int t = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % t == 0) {
                    count++;
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
                
            Console.WriteLine($"{t}-in bazmapatik tarreri qanak@ = {count}");
        }

        static void xndir_14() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();
            int artadryal = 1;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] % 5 == 3) {
                    artadryal *= arr[i];
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
                
            Console.WriteLine($"5-in bazmapakelis mnacord = 3-i tarreri artadryal@ = {artadryal}");
        }

        static void xndir_15() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();
            double sum = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] + i % 3 == 0) {
                    sum += Math.Pow(arr[i], 2);
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
                
            Console.WriteLine($"Ayn tarreri qarakusineri gumar@, voronc indexneri ev elementneri gumar@ aranc mnacord bajanvum e 3-i = {sum}");
        }

        static void xndir_16() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();
            int sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                Console.WriteLine($"arr[{i}] = {arr[i]}");
                bool t = true;

                for (int j = 2; j <= Math.Sqrt(i); j++) {
                    if ((i % j == 0) && (i != 2)) {
                        t = false;
                    }
                }
                if (t) {
                    sum += arr[i];
                    count++;
                }
            }

            Console.WriteLine($"Ayn tarreri mijin tvabanakan@, voronc index@ voreve bnakan tvi qarakusi e = {sum / count}");
        }

        static void xndir_17() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            double sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
                if (arr[i] > i) {
                    sum += Math.Pow(arr[i], 2);
                    count++;
                }
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Ayn tarreri mijin qarakusayin@, voronc arjeq@ mec e indexic = {sum / count}");
        }

        static void xndir_18() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please, input K = ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int sum = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);

                if (Math.Pow(arr[i] + i, 2) % k == 0) {
                    sum += arr[i];
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Sum = {sum}");
        }

        static void xndir_19() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please, input K = ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int count = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);

                if (i != 0) {
                    if (Math.Abs(arr[i] / i) > k) {
                        count++;
                    }
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Count = {count}");
        }

        static void xndir_20() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();
            double artadryal = 1;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);

                if ((arr[i] % 3 == 2) && (i % 3 == 2)) {
                    artadryal *= Math.Pow(arr[i], 2);
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Artadryal = {artadryal}");
        }

        static void xndir_21() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int max = arr[0];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);

                if (max < arr[i]) {
                    max = arr[i];
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Max = {max}");
        }

        static void xndir_22() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int min = arr[0];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);

                if (min > arr[i]) {
                    min = arr[i];
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Min = {min}");
        }

        static void xndir_23() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int min = arr[0], max = arr[0];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);

                if (min > arr[i]) {
                    min = arr[i];
                }

                if (max < arr[i]) {
                    max = arr[i];
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine();
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine();
            Console.WriteLine($"Max + Min = {max + min}");
        }

        static void xndir_24() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int min = arr[0], max = arr[0];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);

                if (min > arr[i]) {
                    min = arr[i];
                }

                if (max < arr[i]) {
                    max = arr[i];
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine();
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine();
            Console.WriteLine($"Max * Min = {max * min}");
        }

        static void xndir_25() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int max = arr[0];
            int indexOfMax = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);

                if (max < arr[i]) {
                    max = arr[i];
                    indexOfMax = i;
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Max = {max}");
            Console.WriteLine();
            Console.WriteLine($"Max + indexOfMax = {max + indexOfMax}");
        }

        static void xndir_26() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int min = arr[0];
            int indexOfMin = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-100, 100);

                if (min > arr[i]) {
                    min = arr[i];
                    indexOfMin = i;
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Min = {min}");
            Console.WriteLine();
            Console.WriteLine($"Min + indexOfMin = {min + indexOfMin}");
        }

        static void xndir_27() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int max = arr[0];
            int indexOfMax = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-5, 5);

                if (max < arr[i]) {
                    max = arr[i];
                    indexOfMax = i;
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"index Of First Max value = {indexOfMax}");

        }

        static void xndir_28() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int max = arr[0];
            int indexOfMax = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-5, 5);

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            for (int i = arr.Length - 1; i > 0; i--) {
                if (max < arr[i]) {
                    max = arr[i];
                    indexOfMax = i;
                }
            }

            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"index Of Last Max value = {indexOfMax}");
        }

        static void xndir_29() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int min = arr[0];
            int indexOfMin = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-5, 5);

                if (min > arr[i]) {
                    min = arr[i];
                    indexOfMin = i;
                }

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"index Of First Min value = {indexOfMin}");
        }

        static void xndir_30() {
            Console.Write("Please, input length of array = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random random = new Random();

            int min = arr[0];
            int indexOfMin = 0;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(-5, 5);

                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            for (int i = arr.Length - 1; i > 0; i--) {
                if (min > arr[i]) {
                    min = arr[i];
                    indexOfMin = i;
                }
            }

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"index Of First Min value = {indexOfMin}");
        }

        static void Main(string[] args) {
            //xndir_teladrac_1();
            //xndir_teladrac_2();
            //xndir_teladrac_3();

            //xndir_1();
            //xndir_2();
            //xndir_3();
            //xndir_4();
            //xndir_5();
            //xndir_6();
            //xndir_7();
            //xndir_8();
            //xndir_9();
            //xndir_10();
            //xndir_11();
            //xndir_12();
            //xndir_13();
            //xndir_14();
            //xndir_15();
            //xndir_16();
            //xndir_17();
            //xndir_18();
            //xndir_19();
            //xndir_20();
            //xndir_21();
            //xndir_22();
            //xndir_23();
            //xndir_24();
            //xndir_25();
            //xndir_26();
            //xndir_27();
            //xndir_28();
            //xndir_29();
            //xndir_30();
        }
    }
}
