//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
// Выводим массива случайных чисел
void PrintArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(" " + arrayToPrint[i, j] + " ");
        }
        Console.WriteLine();
    }

}
//Сортировка массива
 int[,] SortArrayDescending(int[,] array)
{
    for (int column = 0; column < array.GetLength(0);column++)
    {
    for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int i = array.GetLength(1)-1; i >0; i--)
            {
                if (array[row, i] > array[row, i-1])
                {
                    int temp = array[row, i];
                    array[row,i] = array[row, i-1];
                    array[row, i-1] = temp;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Сортировка массива в порядке убывания.\n");
Console.Write("Введите размер двумерного массива:\nширина m = ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("длина  n = ");
int row = Convert.ToInt32(Console.ReadLine());
var arrRandom = new int[column, row];
int[,] result = NumberArray(arrRandom);
Console.ForegroundColor = ConsoleColor.Yellow;
PrintArray(result);
Console.ResetColor();
int[,] sortArray = SortArrayDescending(result);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(sortArray);
Console.ResetColor();