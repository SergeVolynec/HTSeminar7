int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(0,100);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

void GetElement (int [,] matrix)
{
    Console.Write ("Введите номер строки: ");
    int rowPosiion = Convert.ToInt32(Console.ReadLine());
    Console.Write ("Введите номер столбца: ");
    int columnPosition = Convert.ToInt32(Console.ReadLine());

    if (rowPosiion > matrix.GetLength(0)||columnPosition > matrix.GetLength(1))
        Console.WriteLine ("Такой позиции в массиве нет");
    else
        Console.WriteLine ("Это число " + matrix [rowPosiion-1, columnPosition-1]);
}

int[,] resultMatrix = GetMatrix(3, 4);
PrintMatrix(resultMatrix);
GetElement (resultMatrix);