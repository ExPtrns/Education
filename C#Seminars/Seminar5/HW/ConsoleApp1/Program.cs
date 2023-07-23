//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//using System.Diagnostics.Metrics;

/*void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(",");
    }


    Console.WriteLine("]");
}

int[] CreateRandomIntArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(min,max);
return array;
}
int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) 
            count++;
    return count;
}

int[] myArray = CreateRandomIntArray(10, 100, 1000);

Console.WriteLine("В массиве:");
ShowArray(myArray);
Console.WriteLine("четных чисел = {0}.",  EvenCount(myArray));*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0
/*int[] CreateRandomIntArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(min, max);
    return array;
}
void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(",");
    }
    Console.WriteLine("]");
}
int SumPerOddElemArray(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length;i+=2)
    {
        sum += array[i];
    }
    return sum;
}

int[] myArray = CreateRandomIntArray(10, 1, 10);
ShowArray(myArray);
Console.WriteLine("Сумма нечетных элементов массива = " + SumPerOddElemArray(myArray));*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/*double[] CreateRandomDoubleArray(int length, int min, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
        array[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
    return array;
}
void ShowArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write("; ");
    }
    Console.WriteLine("]");
}

double DiffMaxNMin(double[] array)
{
    double diff = -1;
    double min = array[0];
    double max = array[0];
    for(int i  = 1; i < array.Length;i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    diff = max - min;

    return Math.Round(diff, 2);

}

double[] myArray = CreateRandomDoubleArray(10, 1, 10);
ShowArray(myArray);
Console.WriteLine(DiffMaxNMin(myArray)); */
