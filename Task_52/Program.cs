Console.WriteLine("Количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[x, y];
FillArrayRandomNumbers(numbers);


for (int b = 0; b < numbers.GetLength(1); b++)
{
    double avarage = 0;
    for (int a = 0; a < numbers.GetLength(0); a++)
    {
        avarage = (avarage + numbers[a, b]);
    }
    avarage = avarage / x;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[a, b] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
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