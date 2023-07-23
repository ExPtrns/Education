//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

/*int CounterPositive(int quantity)
{
    int count = 0;
    for (int i = 0; i < quantity; i++)
    {
        Console.Write("Введите {0} число ", i + 1);
        if (Convert.ToInt32(Console.ReadLine()) > 0)
            count++;
    }
    return count;
}

Console.Write("Сколько будет элементов в проверке: ");
int q = Convert.ToInt32(Console.ReadLine());
int count = CounterPositive(q);
Console.WriteLine("Положительных значений - " + count);*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

/*void PointIntersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
            Console.WriteLine("Прямые совпадают - количество точек пересечения бесконечно.");
        else Console.WriteLine("Прямые паралельны - точек пересечения нет.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2); 
        double y = (k1 * x) + b1;
        Console.WriteLine("Точка пересечения прямых - ({0}; {1})", x, y);
    }
}

Console.Write("Введите значение k1 из уравнения y = k1 * x + b1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1 из уравнения y = k1 * x + b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 из уравнения y = k2 * x + b2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 из уравнения y = k2 * x + b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

PointIntersection(k1, b1, k2, b2);*/

