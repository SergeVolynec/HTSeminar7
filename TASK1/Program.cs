double[,] GetMatrix(int rows, int cols)
{
    double [,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble()*10),1)*ChooseSign ();
        }

    }
    return matrix;
}

void PrintMatrix(double [,] matr)
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

//Функция задает произвольный знак
int ChooseSign ()
{
    var arr1 = new[]{-1,1,};
    var sign = arr1[new Random().Next(2)];
    return sign;
}

Console.Write ("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] resultMatrix = GetMatrix(rows, columns);
PrintMatrix(resultMatrix);