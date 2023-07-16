/*//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


bool Palindrom5 (int number)
{
    bool pal;
    int temp = number % 10;
    if ((number / 10000) == temp )
    {
        number = number % 10000;
        number = number / 10;
        temp = number % 10;
        if ( number / 100 == temp ) return true;
        else return false;
    }
    else return false;
    
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Palindrom5(number)) Console.WriteLine("Число {0} это палиндром.", number);
else Console.WriteLine("Число {0} это НЕ палиндром.", number);*/

/*//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B(2, 1, -7), -> 15.84
//A(7, -5, 0); B(1, -1, 9)-> 11.53
double Distanse2(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)),2);
}

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int aZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int bZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между точкой А({0},{1},{2}) и точкой B({3},{4},{5}) равно - {6}", aX,aY,aZ,bX,bY,bZ,Distanse2(aX, aY, aZ, bX, bY, bZ));
*/

/*//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//4
//1 - 1
//2 - 8
//3 - 27
//4 - 64
void CubeToN(int number)
{
    int count = 1;
    while (count < number + 1)
    {
        Console.WriteLine("{0}^3 = {1}", count, count * count * count);
        count++;
    }
}

Console.WriteLine("Таблица кубов от 1 до N. Введите N: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeToN(number);*/