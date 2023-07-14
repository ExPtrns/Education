/*//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.
int firstNum, secondNum;

Console.WriteLine("Программа находит большее из двух чисел.");
Console.Write("Введите первое число ");
firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum) Console.WriteLine($"Из двух чисел {firstNum} и {secondNum} большее число - {firstNum}");
else Console.WriteLine($"Из двух чисел {firstNum} и {secondNum} большее число - {secondNum}");
*/
/*//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int firstNum, secondNum, thirdNum, maxNum;

Console.WriteLine("Программа находит максимальное из 3 чисел.");
Console.Write("Введите первое число ");
firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
thirdNum = Convert.ToInt32(Console.ReadLine());

maxNum = firstNum;
if (secondNum > maxNum) maxNum = secondNum;
if (thirdNum > maxNum) maxNum = thirdNum;

Console.WriteLine("Максимальное число - " + maxNum);*/
/*//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int checkNum;

Console.WriteLine("Программа определяет является ли число четным");
Console.Write("Введите число для проверки ");
checkNum = Convert.ToInt32(Console.ReadLine());

if (checkNum % 2 == 0) Console.WriteLine("Число {0} - четное", checkNum);
else Console.WriteLine("Число {0} - НЕ четное", checkNum);*/
/*//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int number, count = 2;

Console.WriteLine("Программа выводит четные числа от 1 до введенного.");
Console.Write("Введите число ");
number = Convert.ToInt32(Console.ReadLine());
if (number <=2)
    Console.WriteLine("Нечего выводить.");
while (count < number)
{
    Console.Write(count + " ");
    count += 2;
}
*/
int number = Convert.ToInt32(Console.ReadLine());
int chet = 1;
while (chet <= number)
{
    if (number % 2 ==0)
        Console.Write(chet + " ");
    chet++;
}