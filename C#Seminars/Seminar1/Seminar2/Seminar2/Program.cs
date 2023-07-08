//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int MaxNumber(int decNum)
{
    int firstNum = decNum / 10;
    int secondNum = decNum % 10;
    if(firstNum > secondNum) return firstNum;
    else return secondNum;
}

Console.Write("Введите двузначное число: ");
int decNum = Convert.ToInt32(Console.ReadLine());