using System;

class MatrixGenerator
{
    static void Main()
    {
        string[] parameters = Console.ReadLine().Split(' ');
        string matrixType = parameters[0];
        int rows = int.Parse(parameters[1]);
        int cols = int.Parse(parameters[2]);
        int[][] matrix = new int[rows][];
        int currValue = 1;
        int origRows = rows;
        int origCols = cols;

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new int[cols];
        }

        if (matrixType == "A")
        {
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row][col] = currValue;
                    currValue++;
                }
            }
        }
        else if (matrixType == "B")
        {
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    int currRow = row;

                    if (currRow == 0 && col != 0)
                    {
                        currRow = rows - 1;
                    }
                    else if (currRow == rows - 1 && col != 0)
                    {
                        currRow = 0;
                    }

                    matrix[currRow][col] = currValue;
                    currValue++;
                }
            }
        }
        else if (matrixType == "C")
        {
            for (int col = 0; col < cols; col++)
            {
                for (int row = rows - 1; row >= 0; row--)
                {
                    int currRow = row;
                    int currCol = col;

                    if (currCol != 0)
                    {
                        currRow = 0;
                    }

                    while (currRow < rows)
                    {
                        matrix[currRow][currCol] = currValue;
                        currValue++;
                        currRow++;
                        currCol++;
                    }

                    if (col > 0)
                    {
                        rows--;
                        break;
                    }   
                }
            }
        }
        else if (matrixType == "D")
        {
            for (int col = 0; col < cols; col++)
            {
                if ((currValue - 1) == (origCols * origRows))
                {
                    break;
                }

                for (int row = 0; row < rows; row++)
                {
                    int currRow = row;
                    int currCol = col;

                    while (currRow < rows)
                    {
                        matrix[currRow][currCol] = currValue;
                        currValue++;
                        currRow++;
                    }

                    currCol = 1;
                    currRow = rows - 1;

                    while (currCol < cols)
                    {
                        matrix[currRow][currCol] = currValue;
                        currValue++;
                        currCol++;
                    }

                    currRow = rows - 2;
                    currCol = cols - 1;

                    while (currRow >= 0)
                    {
                        matrix[currRow][currCol] = currValue;
                        currValue++;
                        currRow--;
                    }

                    currRow = 0;
                    currCol = cols - 2;

                    while (currCol > 0)
                    {
                        matrix[currRow][currCol] = currValue;
                        currValue++;
                        currCol--;
                    }

                    currCol = 1;
                    currRow = 1;

                    while (currCol < cols - 1)
                    {
                        matrix[currRow][currCol] = currValue;
                        currValue++;
                        currCol++;
                    }

                    if ((currValue - 1) == (origCols * origRows))
                    {
                        break;
                    }        
                }
            }
        }

        for (int r = 0; r < origRows; r++)
        {
            for (int c = 0; c < origCols; c++)
            {
                Console.Write(matrix[r][c] + " ");
            }

            Console.WriteLine();
        }       
    }
}

