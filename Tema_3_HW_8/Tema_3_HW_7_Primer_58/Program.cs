/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


// // Функция задает количество строк (столбцов) в матрице
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }

    return result;
}


// Функция инициализирует массив
int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(-99, 100);
        }
    }

    return matrix;
}


// Функция выводит массив на экран
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}



int countOfRows1 = GetNumber("Введите кол-во строк в первой матрице:");

int countOfColumns1 = GetNumber("Введите кол-во столбцов в первой матрице:");

int[,] matrix1 = InitMatrix(countOfRows1, countOfColumns1);

Console.WriteLine();

PrintMatrix(matrix1);

Console.WriteLine();

int countOfRows2 = GetNumber("Введите кол-во строк во второй матрице:");

int countOfColumns2 = GetNumber("Введите кол-во столбцов во второй матрице:");

int[,] matrix2 = InitMatrix(countOfRows2, countOfColumns2);

Console.WriteLine();

PrintMatrix(matrix2);

Console.WriteLine();

int[,] resultArray = new int [countOfRows1, countOfColumns2];
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            resultArray[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

// Функция вывода нового двумерного массива в терминал 
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray2D(resultArray);

