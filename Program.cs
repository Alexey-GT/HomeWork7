

/* //Задайте двумерный массив размером mxn, заполненный
//случайными вещественными числами.
Console.Clear();
Console.WriteLine("Введите числo строк: ");
int numberRow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числo столбцов: ");
int numberCol = int.Parse(Console.ReadLine()!);
double[,] array = new double[numberRow, numberCol];
FillArray(array);
PrintArray(array);

void FillArray(double[,] array)
{
    Random randGenerator = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(randGenerator.Next(-10, 10) + randGenerator.NextDouble(), 1);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine("");
    }
} */



/* //Напишите программу, которая на вход принимает позиции
//элемента в двумерном массиве, и возвращает значение этого
//элемента или же указание, что такого элемента нет.
Console.Clear();
Console.WriteLine("Введите позицию элемента в столбце: ");
int rowPosition = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию элемента в строке: ");
int colPosition = int.Parse(Console.ReadLine()!);
int[,] array = new int[5, 8];
FillArray(array);
PrintArray(array);
SearchPosition(array, rowPosition, colPosition);

void SearchPosition(int[,] array, int rowPosition, int colPosition)
{
    if (rowPosition < array.GetLength(0) && colPosition < array.GetLength(1))
    {
        Console.Write($"Элемент: {array[rowPosition,colPosition]}");
    }
    else
    {
         Console.Write($"Такого элемента нет");
    }
}

void FillArray(int[,] array)
{
    Random randGenerator = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = randGenerator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine("");
    }
} */


/* 
//Задайте двумерный массив из целых чисел. Найдите
//среднее арифметическое элементов в каждом столбце.
Console.Clear();
Console.WriteLine("Введите числo строк: ");
int numberRow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числo столбцов: ");
int numberCol = int.Parse(Console.ReadLine()!);
int[,] array = new int[numberRow, numberCol];
FillArray(array);
PrintArray(array);
double[] colAverage = FuncAverageColumn(array);
PrintColAverage(colAverage);

double[] FuncAverageColumn(int[,] array)
{
    double[] colAv = new double[array.GetLength(1)];
    for (int j=0; j<array.GetLength(1); j++)
    {   
        colAv[j] = 0;
        for (int i=0; i<array.GetLength(0); i++)
        {
            colAv[j] += array[i,j];
        }
        colAv[j] /= array.GetLength(0);
    }
    return colAv;
}

void PrintColAverage(double[] colAv)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int j=0; j<array.GetLength(1)-1; j++)
    {
        Console.Write($"{colAv[j]:f1}; ");
    }
    Console.Write($"{colAv[array.GetLength(1)-1]:f1}.");
}

void FillArray(int[,] array)
{
    Random randGenerator = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = randGenerator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine("");
    }
} */

