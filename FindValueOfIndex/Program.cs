int[,] FillArray()
{
    int[,] array = new int[6, 5];
    for(int i = 0; i < 6; i++)
        for(int j = 0; j < 5; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    return array;
}

void ShowArray(int[,] array)
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

void ShowValueOfIndex(int rowIndex, int columnIndex, int[,] array)
{
    if(rowIndex < array.GetLength(0) && columnIndex < array.GetLength(1)) Console.WriteLine(array[rowIndex, columnIndex]);
    else Console.WriteLine("index dont exist");
}

Console.WriteLine("Input row index: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input column index: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray();

ShowArray(array);

ShowValueOfIndex(rowIndex, columnIndex, array);
