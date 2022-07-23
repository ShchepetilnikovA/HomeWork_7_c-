int[,] FillArray()
{
    int[,] array = new int[3, 4];
    for(int i = 0; i < 3; i++)
        for(int j = 0; j < 4; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    return array;
}

void Show2dArray(int[,] array)
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

void ShowArray(double[] array)
{
    for(int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + " ");
        }
}

double[] AverageInColumns(int[,] array)
{
    double[] arrayAverage = new double[array.GetLength(1)];
    int average = 0;
    int k = 0;   
        for(int j = 0; j < array.GetLength(1); j++)
        {    
            for(int i = 0; i < array.GetLength(0); i++)
            {
              average += array[i, j];
            }
            arrayAverage[k] = Math.Round((double)average / array.GetLength(0), 1);
            k++;
            average = 0;
        }
    return arrayAverage;
}

int[,] array = FillArray();

Show2dArray(array);

double[] arrayAverage = AverageInColumns(array);

ShowArray(arrayAverage);

