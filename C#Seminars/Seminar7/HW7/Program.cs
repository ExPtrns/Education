/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*//Решение задачи 47
double[,] CreateRandomDoubleArray(int rows, int columns, int minVavue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().Next(minVavue, maxValue+1) + new Random().NextDouble(), 2);
    return array;
}

void Show2dArray(double[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array.Length == (i + 1) * (j + 1)) Console.WriteLine(array[i, j] + "]");
            else Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }

}

double[,] newArray = CreateRandomDoubleArray(rows: 5, columns: 8, 10, 99);
Show2dArray(newArray);
*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7->числа с такими индексами в массиве нет*/
/*//Решение задачи 50
 double[,] CreateRandomDoubleArray(int rows, int columns, int minVavue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().Next(minVavue, maxValue + 1) + new Random().NextDouble(), 2);
    return array;
}

void ShowDoubleArray(double[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array.Length == (i + 1) * (j + 1)) Console.WriteLine(array[i, j] + "]");
            else Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

void GetElementFrom2dArray(double[,] array, int valueX, int valueY)
{
    if (valueX < array.GetLength(0) && valueY < array.GetLength(1) && valueX >= 0 && valueY >= 0)
        Console.WriteLine(array[valueX, valueY]);
    else Console.WriteLine("Числа с индексами ({0}, {1}) в массиве нет", valueX, valueY);
}

double[,] newArray = CreateRandomDoubleArray(5, 5, 10, 99);
ShowDoubleArray(newArray);
GetElementFrom2dArray(newArray, 3, 4);
*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*//Решение задачи 52
int[,] CreateRandomIntArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array.Length == (i + 1) * (j + 1)) Console.WriteLine(array[i, j] + "]");
            else Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }

}
void FindArithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.WriteLine($"Среднее арифметическое по {i + 1} столбцу = " + sum / array.GetLength(0));
    }
}

int[,] myArray = CreateRandomIntArray(rows: 5, columns: 10, minValue: 0, maxValue: 10);
ShowArray(myArray);
FindArithmeticMean(myArray);
*/
