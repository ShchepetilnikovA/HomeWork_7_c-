double[,] FillDoubleArray(int mRows, int nColumns)
{
    double[,] array = new double[mRows, nColumns];
    for(int i = 0; i < mRows; i++)
        for(int j = 0; j < nColumns; j++)
        {
            array[i, j] = new Random().Next(-99, 100-1) + new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j], 1);
        }
    return array;
}

void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

Console.WriteLine("Input value of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input value of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = FillDoubleArray(m, n);

ShowArray(array);