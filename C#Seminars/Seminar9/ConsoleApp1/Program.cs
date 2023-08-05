//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void ShowNums(int num)
{
    if (num > 0) ShowNums(num - 1);
    Console.Write(num + " ");
}
//ShowNums(5);
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SumOfDigits(int num)
{
    if (num != 0) return SumOfDigits(num / 10) + num % 10;
    return 0;
}
//Console.WriteLine(SumOfDigits(1234));

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNumsMN(int numM, int numN)
{
    if (numN > numM)
    {
        ShowNumsMN(numN - 1, numM);
        Console.Write(numN + " ");
        
    }
    
    else if (numM < numN) { }
    {
        ShowNumsMN(numM - 1, numN);
        Console.Write(numM + " ");

    }


}

//ShowNumsMN(1, 5);

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double ShowPower(double num, int pow)
{
    if (pow > 0)
    {
        return ShowPower(num, pow - 1) * num;
    }
    else if (pow < 0)
    {
        return ShowPower(num, pow + 1) / num;
    }
    else return 1;
}

Console.Write("Input the number: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the power: ");
int pow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowPower(num, pow));