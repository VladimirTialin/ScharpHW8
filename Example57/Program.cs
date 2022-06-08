/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/
int[,] NumberArray(int[,] numberArray)
{
    for (var i = 0; i < numberArray.GetLength(0); i++)
    {
        for (var j = 0; j < numberArray.GetLength(1); j++)
        {
            numberArray[i, j] = new Random().Next(1, 9);
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
void FindArray(int[,] array)
{
    int row=0;
    for (int column = 0; column < array.GetLength(0);column++)
    {
        int t=0;
        int temp=array[column,row];
    for (row = 0; row < array.GetLength(0); row++)
        {
            for (int i = 0; i<array.GetLength(1); i++)
            {
                if (temp == array[row, i])
                {
                     t++;
                }
            }
          
        }
        Console.WriteLine(t);  
    }
    
}
Console.WriteLine("Сортировка массива в порядке убывания.\n");
Console.Write("Введите размер двумерного массива:\nширина m = ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("длина  n = ");
int row = Convert.ToInt32(Console.ReadLine());
var arrRandom = new int[column, row];
int[,] result = NumberArray(arrRandom);
PrintArray(result);
FindArray(result);
