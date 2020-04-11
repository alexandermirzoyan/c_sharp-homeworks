using System;
using System.Text;

namespace SnakeGame {
    class Program {
        static String[,] initTheWorld(int x, int y) {
            String[,] matrix = new string[x,y];
            for (int i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    matrix[i,j] = "*";
                }
            }
            return matrix;
        }

        static String snakeRandomCordinate(int x, int y) {
            Random random = new Random();
            int randomX = random.Next(0, x);
            int randomY = random.Next(0, y);

            return $"{randomX},{randomY}";
        }

        static void Main(string[] args) {
            String[,] world = initTheWorld(5,5);

            // GetUpperBound(0) and GetUpperBound(1) return 4 in 5x5 matrix
            int matrixRowCount = world.GetUpperBound(0) + 1;
            int matrixColumnCount = world.GetUpperBound(1) + 1;
            
            String randomSnakeCordinate = snakeRandomCordinate(matrixRowCount, matrixColumnCount);
            int randomSnakeCordinateX = Convert.ToInt32(randomSnakeCordinate[0].ToString());
            int randomSnakeCordinateY = Convert.ToInt32(randomSnakeCordinate[2].ToString());

            world[randomSnakeCordinateX, randomSnakeCordinateY] = "A";

            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    Console.Write(world[i, j] + " ");
                }
                Console.WriteLine();
            }

            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            StringBuilder output = new StringBuilder(String.Format("You pressed {0}", input.Key.ToString()));
            
        }
    }
}
