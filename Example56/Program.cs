/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
*/
//Формируем массив случайных чисел
int[,] NumberArray(int[,] numberArray)
{
    for (var i = 0; i < numberArray.GetLength(0); i++)
    {
        for (var j = 0; j < numberArray.GetLength(1); j++)
        {
            numberArray[i, j] = new Random().Next(20, 80);
        }
    }
    return numberArray;
}
// Выводим массива
void PrintArray(int[,] arrayToPrint)
{
    int minIndex = MinIndexRow(arrayToPrint);
    int result=0;
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        int temp = 0;
        if (minIndex == i)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.Write("|");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            temp += arrayToPrint[i, j];

            Console.Write(" "+arrayToPrint[i, j] + " ");
        }
        Console.Write($"|    = {temp}");
        Console.ResetColor();
        Console.WriteLine();
        if (minIndex == i)
        {
            result = temp;
        }
    }
    Console.WriteLine($"\nМинимальная сумма элементов строки находится под индекcом [{minIndex}] = {result}");
}
//Функция поиска минимальной суммы строки
int MinIndexRow(int[,] arrayToPrint)
{
    int temp;
    int sumRow = int.MaxValue;
    int minIndex = 0;
    for (int column = 0; column < arrayToPrint.GetLength(0); column++)
    {
        temp = 0;
        for (int row = 0; row < arrayToPrint.GetLength(1); row++)
        {
            temp += arrayToPrint[column, row];   
        }
        if (temp < sumRow)
        {
            sumRow = temp;
            minIndex= column;
        }
    }
    return minIndex;
}
//Console.WriteLine($"Минимальная сумма элементов массива находится в строке {column} = {sumRow}");
Console.WriteLine("Находим строку с наименьшей суммой элементов.\n");
Console.Write("Введите размер двумерного массива:\nширина m = ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("длина  n = ");
int row = Convert.ToInt32(Console.ReadLine());
if (column != row)
{
    var arrRandom = new int[column, row];
    int[,] result = NumberArray(arrRandom);
    PrintArray(result);
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Ошибка! Вы ввели массив [ {column},{row} ] с равными сторонами.\nВведите прямоугольный массив!");
    Console.ResetColor();
}