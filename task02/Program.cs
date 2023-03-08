// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = 3;
int n = 3;
int[,] array = new int[m,n];
System.Console.WriteLine("Введите значение: ");
int number = Convert.ToInt32(Console.ReadLine());
FillArray(array);
SearchElementArray(array,number);

void FillArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}
void SearchElementArray(int[,] searchelemen, int usernumber)
{
    bool search = false;
    for(int i =0; i < searchelemen.GetLength(0); i++)
    {
        for(int j =0; j < searchelemen.GetLength(1); j++)
        {
            if(searchelemen[i,j] == usernumber)
            System.Console.WriteLine($"Координаты вашего значения:  строка {i}  столбец {j}");
            search = true;
        }
       
    }
    if(!search)
    System.Console.Write("Такого значения не существует.");
}
