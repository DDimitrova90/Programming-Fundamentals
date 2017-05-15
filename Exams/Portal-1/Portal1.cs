using System;
using System.Collections.Generic;

public class Portal1
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        List<string> matrix = new List<string>();
        int currRow = 0;
        int currCol = 0;
        int turns = 0;

        for (int row = 0; row < rows; row++)
        {
            matrix.Add(Console.ReadLine());

            if (matrix[row].Contains("S"))
            {
                currRow = row;
                currCol = matrix[row].IndexOf("S");
            }
        }

        string path = Console.ReadLine();

        for (int i = 0; i < path.Length; i++)
        {
            turns++;
            char step = path[i];

            switch (step)
            {
                case 'D':

                    while (true)
                    {
                        currRow++;
                        if (currRow > matrix.Count - 1)
                        {
                            currRow = 0;

                            if (currCol > matrix[currRow].Length - 1)
                            {
                                continue;
                            }
                            break;
                        }
                        if (currCol > matrix[currRow].Length - 1)
                        {
                            continue;
                        }
                        break;
                    }
                    break;

                case 'U':
                    
                    while(true)
                    {
                        currRow--;

                        if (currRow < 0)
                        {
                            currRow = matrix.Count - 1;

                            if (currCol > matrix[currRow].Length - 1)
                            {
                                continue;
                            }

                            break;
                        }

                        if (currCol > matrix[currRow].Length - 1)
                        {
                            continue;
                        }

                        break;
                    }

                    break;

                case 'R':
                    currCol++;

                    if (currCol > matrix[currRow].Length - 1)
                    {
                        currCol = 0;
                    }

                    break;

                case 'L':
                    currCol--;

                    if (currCol < 0)
                    {
                        currCol = matrix[currRow].Length - 1;
                    }

                    break;
            }

            if (matrix[currRow][currCol] == 'E')
            {
                Console.WriteLine($"Experiment successful. {turns} turns required.");
                return;
            }
        }

        Console.WriteLine($"Robot stuck at {currRow} {currCol}. Experiment failed.");
    }
}

