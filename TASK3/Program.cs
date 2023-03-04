int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(1,10);
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

void ColumnAverage (int [,] matrix)
{
    int rowQuantity =  matrix.GetLength(0);
    int columnQuantity = matrix.GetLength(1);
    for (int i = 0; i < columnQuantity; i++)
    {
        int sum = 0;
        for (int m = 0; m < rowQuantity; m++)
        {
            sum = sum + matrix [m,i];
        }  
        double avg = Math.Round(Convert.ToDouble(sum)/Convert.ToDouble(rowQuantity),1);
        Console.WriteLine($"Среднее арифметическое в {i+1}-ом столбце равно: {avg}");
    }
}

int[,] resultMatrix = GetMatrix(3, 4);
PrintMatrix(resultMatrix);
ColumnAverage (resultMatrix);