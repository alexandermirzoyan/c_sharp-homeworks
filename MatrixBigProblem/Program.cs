using System;

namespace MatrixBigProblem {
    class Program {
        static void Main(string[] args) {
            Matrix matrix = new Matrix(8,8);
            int[,] matrixFromObjectAutomat = matrix.printMatrixAutomat();
            //int[,] matrixFromObjectManual = matrix.printMatrixManual();

            /*Console.WriteLine();
            matrix.printMatrixMainDiagonalWithColor(matrixFromObjectAutomat);
            Console.WriteLine();
            matrix.printMatrixSecondaryDiagonalWithColor(matrixFromObjectAutomat);
            Console.WriteLine();
            matrix.printTriangleWithMainDiagonal(matrixFromObjectAutomat);
            Console.WriteLine();
            matrix.getListFromMatrix(matrixFromObjectAutomat);
            Console.WriteLine();
            matrix.findNumberThatDevidesToK(matrixFromObjectAutomat, 3);
            Console.WriteLine();
            matrix.sortMatrixRows(matrixFromObjectAutomat);*/
        }
    }
}
