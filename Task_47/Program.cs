Console.Write("Количество строк ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[a, b]= Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        Console.Write("[ ");
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
