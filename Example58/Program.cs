/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
*/
//Формируем массив случайных чисел
int[,] NumberArray(int[,] numberArray)
{
    
    for (var i = 0; i < numberArray.GetLength(0); i++)
    {
        for (var j = 0; j < numberArray.GetLength(1); j++)
        {
            numberArray[i, j] = new Random().Next(30, 90);
        }
    }
    return numberArray;
}
// Выводим массива случайных чисел
void PrintArray(int[,] arrayToPrintMatrixOne,int[,] arrayToPrintMatrixTwo)
{
    for (int i = 0; i < arrayToPrintMatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrintMatrixOne.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrintMatrixOne[i, j]} ");
            Console.Write(" | ");
            for (j = 0; j < arrayToPrintMatrixTwo.GetLength(1); j++)
            {
                Console.Write($"{arrayToPrintMatrixTwo[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
}

//Произведение матриц
int[,] MultiplicationMatrix(int[,] MatrixOne,int[,] MatrixTwo)
{
    for (var i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (var j = 0; j < MatrixOne.GetLength(1); j++)
        {
            int temp = MatrixOne[i, j] * MatrixTwo[i, j];
            MatrixOne[i, j] = temp;
        }
    }
    return MatrixOne;
}
Console.Write("Введите размер матрицы: ");
int sizeMatrix = Convert.ToInt32(Console.ReadLine());
var MatrixOne = new int[sizeMatrix, sizeMatrix];
var MatrixTwo = new int[sizeMatrix, sizeMatrix];
int[,] MatrixArrOne = NumberArray(MatrixOne);
int[,] MatrixArrTwo = NumberArray(MatrixTwo);
PrintArray(MatrixArrOne,MatrixArrTwo);
int[,] result = MultiplicationMatrix(MatrixArrOne, MatrixArrTwo);
//PrintArray(result,"Произведение матриц");
Console.ReadLine();