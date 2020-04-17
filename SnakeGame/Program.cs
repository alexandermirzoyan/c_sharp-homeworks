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

        static ConsoleKey userInput() {
            ConsoleKeyInfo keyinfo = Console.ReadKey();

            /*do {
                keyinfo = Console.ReadKey();
                Console.WriteLine(keyinfo.Key + " was pressed");
            }
            while (keyinfo.Key != ConsoleKey.Escape);
            // when pressing escape, close application
            Console.WriteLine(keyinfo);*/
            return keyinfo.Key;
        }

        static void printTheWorld(String[,] world) {
            int matrixRowCount = world.GetUpperBound(0) + 1;
            int matrixColumnCount = world.GetUpperBound(1) + 1;

            for (int i = 0; i < matrixRowCount; i++) {
                for (int j = 0; j < matrixColumnCount; j++) {
                    if (world[i, j] == "S") {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(world[i, j]);
                        Console.ResetColor();
                    }
                    else {
                        Console.Write(world[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }

        static void userInputs(String[,] world, String randomSnakeCordinate) {
            int matrixRowCount = world.GetUpperBound(0) + 1;
            int matrixColumnCount = world.GetUpperBound(1) + 1;
            int randomSnakeCordinateX = Convert.ToInt32(randomSnakeCordinate[0].ToString());
            int randomSnakeCordinateY = Convert.ToInt32(randomSnakeCordinate[2].ToString());

            int userInputedSnakeX = randomSnakeCordinateX;
            int userInputedSnakeY = randomSnakeCordinateY;

            do {
                switch (userInput()) {
                    case ConsoleKey.RightArrow:
                        userInputedSnakeY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        userInputedSnakeY--;
                        break;
                    case ConsoleKey.UpArrow:
                        userInputedSnakeX--;
                        break;
                    case ConsoleKey.DownArrow:
                        userInputedSnakeX++;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                int worldSizeX = world.GetUpperBound(0) + 1;
                int worldSizeY = world.GetUpperBound(1) + 1;
                if (userInputedSnakeX >= worldSizeX - 1) {
                    Console.WriteLine($"line 86 ::: {userInputedSnakeX}");
                    world[-userInputedSnakeX, userInputedSnakeY] = "S";
                }
                else if(userInputedSnakeY >= worldSizeY - 1) {
                    Console.WriteLine($"line 90 ::: {userInputedSnakeY}");
                    Console.WriteLine($"line 91 ::: {userInputedSnakeX}");
                    world[userInputedSnakeX, -userInputedSnakeY] = "S";
                }
                else {
                    Console.WriteLine($"line 95 ::: {userInputedSnakeX}, {userInputedSnakeY}");
                    world[userInputedSnakeX, userInputedSnakeY] = "S";
                }
                printTheWorld(world);
            } while (userInput() != ConsoleKey.Escape);
        }

        static void Main(string[] args) {
            String[,] world = initTheWorld(20,50);
            // GetUpperBound(0) and GetUpperBound(1) return 4 in 5x5 matrix
            int matrixRowCount = world.GetUpperBound(0) + 1;
            int matrixColumnCount = world.GetUpperBound(1) + 1;
            
            String randomSnakeCordinate = snakeRandomCordinate(matrixRowCount, matrixColumnCount);
            int randomSnakeCordinateX = Convert.ToInt32(randomSnakeCordinate[0].ToString());
            int randomSnakeCordinateY = Convert.ToInt32(randomSnakeCordinate[2].ToString());

            world[randomSnakeCordinateX, randomSnakeCordinateY] = "S";

            printTheWorld(world);
            userInputs(world, randomSnakeCordinate);
        }
    }
}
