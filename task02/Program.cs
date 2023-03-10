// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите координату строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] number = new int [10,10];
FillArrayRandomNumbers(number);

if (n > number.GetLength(0) || m > number.GetLength(1))
{
    Console.WriteLine("Такого элемента нет.");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {number[n-1,m-1]}");
}

PrintArray(number);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}


