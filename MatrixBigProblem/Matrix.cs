using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MatrixBigProblem {
    class Matrix {
        int sizeX, sizeY;
        public Matrix(int sizeX, int sizeY) {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        public int[,] printMatrixAutomat() {
            int[,] matrix = new int[this.sizeX, this.sizeY];
            int matrixRowCount = matrix.GetUpperBound(0) + 1;
            int matrixColumnCount = matrix.GetUpperBound(1) + 1;
            Random random = new Random();
            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    matrix[i, j] = random.Next(10, 99);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            return matrix;
        }

        public int[,] printMatrixManual() {
            int[,] matrix = new int[this.sizeX, this.sizeY];
            int matrixRowCount = matrix.GetUpperBound(0) + 1;
            int matrixColumnCount = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    Console.Write($"Please input {i},{j} index value = ");
                    int inputedNumber = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = inputedNumber;
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            return new int[1,1];
        }

        public void printMatrixMainDiagonalWithColor(int[,] matrix) {
            int matrixRowCount = matrix.GetUpperBound(0) + 1;
            int matrixColumnCount = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    if (i == j) {
                        ConsoleColor[] randomColorsArray = { ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.DarkYellow };
                        Random random = new Random();
                        int randomIndexFromColorsArray = random.Next(0, randomColorsArray.Length - 1);
                        Console.ForegroundColor = randomColorsArray[randomIndexFromColorsArray];
                        Console.Write($"{matrix[i, j]} ");
                        Console.ResetColor();
                    }
                    else {
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void printMatrixSecondaryDiagonalWithColor(int[,] matrix) {
            int matrixRowCount = matrix.GetUpperBound(0) + 1;
            int matrixColumnCount = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    if (i + j == matrixRowCount - 1) {
                        ConsoleColor[] randomColorsArray = {ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.DarkYellow };
                        Random random = new Random();
                        int randomIndexFromColorsArray = random.Next(0, randomColorsArray.Length - 1);
                        Console.ForegroundColor = randomColorsArray[randomIndexFromColorsArray];
                        Console.Write($"{matrix[i, j]} ");
                        Console.ResetColor();
                    }
                    else {
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void printTriangleWithMainDiagonal(int[,] matrix) {
            int matrixRowCount = matrix.GetUpperBound(0) + 1;
            int matrixColumnCount = matrix.GetUpperBound(1) + 1;
            int max = matrix[0, 0];
            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    if (i > j) {
                        if (matrix[i,j] > max) {
                            max = matrix[i, j];
                        }
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Max value of bottom side trinagle = {max}");
        }

        public void getListFromMatrix(int[,] matrix) {
            ArrayList arrayList = new ArrayList();
            int matrixRowCount = matrix.GetUpperBound(0) + 1;
            int matrixColumnCount = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    bool t = true;
                    for (int k = 2; k <= Math.Sqrt(matrix[i,j]); k++) {
                        if (matrix[i,j] % k == 0 && matrix[i,j] != 2) {
                            t = false;
                        }
                        if (t) {
                            arrayList.Add(matrix[i, j]);
                            // break enq anum vor nuyn tiv@ mi qani angam chhashvi
                            break;
                        }
                    }
                }
            }

            Console.Write("Prim(simple) numbers = ");
            for (int i = 0; i < arrayList.Count; i++) {
                Console.Write($"{arrayList[i]} ");
            }
        }

        public void findNumberThatDevidesToK(int[,] matrix, int k) {
            int matrixRowCount = matrix.GetUpperBound(0) + 1;
            int matrixColumnCount = matrix.GetUpperBound(1) + 1;
            Console.Write($"Row elements that devides to {k} = ");
            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    if (i % k == 0) {
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
            }
        }

        public void sortMatrixRows(int[,] matrix) {
            int matrixRowCount = matrix.GetUpperBound(0) + 1;
            int matrixColumnCount = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    for (int k = 0; k < matrixColumnCount - j - 1; k++) {
                        if (matrix[i,k] > matrix[i,k+1]) {
                            int tmp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = tmp;
                        }
                    }
                }
            }

            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
