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
void PrintMatrixs(int[,] arrayToPrintMatrixOne,
                  int[,] arrayToPrintMatrixTwo,
                  string nameMatrixOne,
                  string nameMatrixTwo)              
{
    Console.SetCursorPosition((arrayToPrintMatrixOne.GetLength(1)*2+5)-nameMatrixOne.Length,Console.CursorTop);
    Console.Write(nameMatrixOne);
    Console.SetCursorPosition((arrayToPrintMatrixTwo.GetLength(1)*6+10)-nameMatrixTwo.Length,Console.CursorTop);
    Console.WriteLine(nameMatrixTwo);
    for (int i = 0; i < arrayToPrintMatrixOne.GetLength(0); i++)
    {  
        Console.Write("|");
        for (int j = 0; j < arrayToPrintMatrixOne.GetLength(1); j++)
        {
            Console.Write($" {arrayToPrintMatrixOne[i, j]} "); 
        }
        Console.Write("|   |");
        for (int j = 0; j < arrayToPrintMatrixTwo.GetLength(1); j++)
        {
            Console.Write($" { arrayToPrintMatrixTwo[i, j]} ");
        }
        Console.Write("|");
        System.Console.WriteLine();
    }
}
void PrintMatrixMulti(int[,] arrayToPrint,string name)              
{
    Console.SetCursorPosition((arrayToPrint.GetLength(1)*3/2)+arrayToPrint.GetLength(1)*3-name.Length/2,Console.CursorTop);  
    Console.WriteLine(name);
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {  Console.SetCursorPosition((arrayToPrint.GetLength(1)*3)/2,Console.CursorTop);
        Console.Write("|");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($" {arrayToPrint[i, j]} "); 
        }
        Console.Write("|");
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
PrintMatrixs(MatrixArrOne,MatrixArrTwo,"Matrix1","Matrix2");
int[,] result = MultiplicationMatrix(MatrixArrOne, MatrixArrTwo);
PrintMatrixMulti(result, "Result");
