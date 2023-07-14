/*//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int Sum(int number)
{
    int count = 0;
    int sum = 0;
    while (count <= number)
    {
        sum += count;// sum = sum + count;
        count++;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат = {0}",Sum(number));*/

/*//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int Count(int number)
{
        int count = 1;
    while (number /10 > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В числе {0} - {1} разряда.",count,Count(count));*/

/*//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int Multiply (int number)
{
    int mult = 1;
    int count = 1;
    while(count < number)
    {
        mult *= count; count++;
    }

    return mult;
}

Console.Write("Введите чиссло больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат = " + Multiply(number));*/


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);