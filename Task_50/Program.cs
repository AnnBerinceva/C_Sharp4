Console.Write("Введите строку ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет ");
}
else
{
    Console.WriteLine($"Элемент {n} строки и {m} столбца равен {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
        {        
            for (int b = 0; b < array.GetLength(1); b++)
            {
                array [a,b] = new Random().Next(-100, 100)/10;
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
            Console.Write(array[a,b] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}