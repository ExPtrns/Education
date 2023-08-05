/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
/*//Решение задачи 64
void ShowNums(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNums(num - 1);

}
ShowNums(30);*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/
/*//Решение задачи 66
int SumElMN(int numM, int numN)
{
    if (numM < 1)
    {
        if (numN != 0) return SumElMN(numM, numN - 1) + numN;
    }

    else
    {
        if (numN >= numM) return SumElMN(numM, numN - 1) + numN;
    }
    return 0;
}

Console.WriteLine(SumElMN(-10, 15));*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29*/
//Решение задачи 68
int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}

int m = 3, n = 2;
Console.WriteLine($"A({m},{n}) -> {Akkerman(m,n)}");