/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
/* //Решение задачи 54
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
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = 0; k < array.GetLength(1)-j-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
}


int[,] myArray = CreateRandomIntArray(5, 4, 10, 99);
ShowArray(myArray);
SortArray(myArray);
ShowArray(myArray);*/
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*//Решение задачи 56
int[,] CreateRandomIntQuadArray(int elements, int minValue, int maxValue)
{
    int[,] array = new int[elements, elements];
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

int SumByRows(int[,] array)
{
    int line = -1;
    int sum = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            line = i;
        }
    }

    return line + 1;
}

int[,] myArray = CreateRandomIntQuadArray(4, 1, 9);
ShowArray(myArray);
Console.WriteLine($"Строка с наименьшей суммой элементов - {SumByRows(myArray)}!");
*/
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/*//Решение 58 задачи
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
int[,] MatrixMutiply(int[,] myArray1, int[,] myArray2)
{
    int[,] resultArray = new int[myArray1.GetLength(0), myArray2.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray1.GetLength(1); k++)
                resultArray[j, i] += myArray1[j, k] * myArray2[k, i];
        }

    return resultArray;
}

bool MatrixMutiplyValidate(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(0) == matrix2.GetLength(1)) return true;
    return false;
}



int[,] myArray1 = CreateRandomIntArray(2, 2, 0, 5);
ShowArray(myArray1);
Console.WriteLine("  Х");
Console.WriteLine();
int[,] myArray2 = CreateRandomIntArray(2, 2, 0, 5);
ShowArray(myArray2);
if (MatrixMutiplyValidate(myArray1, myArray2))
{
    int[,] multypliedArray = MatrixMutiply(myArray1, myArray2);
    Console.WriteLine($"  | |   ");
    Console.WriteLine($"--   --  ");
    Console.WriteLine($"\\     /");
    Console.WriteLine($" \\   /");
    Console.WriteLine($"  \\ /");
    Console.WriteLine();

    ShowArray(multypliedArray);
}
else
    Console.WriteLine("Матрицы не соответствуют правилу произведения матриц");*/
/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)*/
/*//Решение задачи 60
int[,,] Create3DIntArray(int lengthValue, int widthValue, int heightValue)
{
    int[,,] myarray = new int[lengthValue, widthValue, heightValue];
    int count = 10;
    for (int i = 0; i < lengthValue; i++)
        for (int j = 0; j < widthValue; j++)
            for (int k = 0; k < heightValue; k++)
            {
                myarray[i, j, k] = (count);
                count++;
            }

    return myarray;
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] myArray = Create3DIntArray(3, 4, 5);
Show3DArray(myArray);*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

//Решение задачи 62
int[,] SpiralFillArray(int rows, int columns)
{
    int[,] myArray = new int[rows, columns];
    int i = 0;
    int j = 0;
    int round = 0;
    int counter = 0;
    while (counter < myArray.Length)
    {
        for (; j < myArray.GetLength(1) - round && counter < myArray.Length; j++, counter++) myArray[i, j] = counter;
        i++;
        j--;

        for (; i < myArray.GetLength(0) - round && counter < myArray.Length; i++, counter++) myArray[i, j] = counter;
        j--;
        i--;

        for (; j >= 0 + round && counter < myArray.Length; j--, counter++) myArray[i, j] = counter;
        i--;
        j++;

        for (; i > 0 + round && counter < myArray.Length; i--, counter++) myArray[i, j] = counter;
        j++;
        i++;

        round++;
    }
    return myArray;
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

int[,] spiralFilledArray = SpiralFillArray(7, 7);
ShowArray(spiralFilledArray);
