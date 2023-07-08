/*//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutFirstNLast(int numToCut)
{
    numToCut = numToCut / 10 % 10;
    if (numToCut < 0) numToCut *= -1;
    return numToCut;
}

int hundredsNum,newNum;

Console.WriteLine("Программа показывает 2 цифру 3-хзначного числа.");
Console.Write("Введите трехзначное число ");
hundredsNum = Convert.ToInt32(Console.ReadLine()); //верим что пользователь умеет читать и введет число

if ((hundredsNum >= 100 && hundredsNum < 1000) || (hundredsNum <= -100 && hundredsNum > -1000))//но все же проверим трехзначное ли число..
{
    newNum = CutFirstNLast(hundredsNum);
    Console.WriteLine("Вторая цифра числа {0} - {1}", hundredsNum, newNum);
}
else
    Console.WriteLine("{0} - НЕ трехзначное число!", hundredsNum);*/

/*//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.

int ThirdNum (int number)
{
    if (number < 0) number *= -1;
    while (number > 999)
        number /= 10;
    return number % 10;
}

int number, rank;

Console.WriteLine("Программа показывает 3 разряд числа.");
Console.Write("Введите число ");
number = Convert.ToInt32(Console.ReadLine());//проверку на отрицательное число делаю в блоке if для закрепления операторов &&  и ||

if (number >= 100 || number <= -100) 
{
    rank = ThirdNum(number);
    Console.WriteLine("Третий разряд числа {0} - {1}!", number, rank);
}
else
    Console.WriteLine("У числа {0} нет разряда 3 порядка",number);*/

/*//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool IsVacation (int dayOfWeek)
{
    if (dayOfWeek == 6 || dayOfWeek == 7) return true;
    return false;
}

int dayOfWeek; bool vacation;

Console.WriteLine("Программа показывает является ли введенный номер дня недели выходным в России.");
Console.Write("Введите номер дня недели: ");
dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek >= 1 && dayOfWeek <= 7)
{
    if (vacation = IsVacation(dayOfWeek)) Console.WriteLine("{0} день недели - это выходной день.",dayOfWeek);
    else Console.WriteLine("{0} день недели - это рабочий день.", dayOfWeek);
}
else
    Console.WriteLine("В неделе 7 дней!");*/
