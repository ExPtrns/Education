/*//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16
int DegreeNumber (int number,int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
        result *= number;
    return result;
}

Console.Write("Введите число для возведения в степень: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень возвести число {0}: ",number);
int degree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0}^{1} = {2}", number, degree, DegreeNumber(number, degree));
*/

/*//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int ToSum(int number)
{
    int sum = 0;
    if (number < 0) number *= -1;
    if (number < 10) return number;
    while (number / 10 > 0) 
    {
        sum += number % 10;
        number /= 10;
    }
    return sum+number;
}

Console.Write("Введите число для нахождения суммы цифр данного числа: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр числа {0} = {1}.",number,ToSum(number)); 
*/

/*//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size),
//генерирующий массив на основе данных, вводимых пользователем.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]



int[] CreateUserArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число - {0} элемент массива: ",i+1);
        array[i] = Convert.ToInt32(Console.ReadLine());
     }

    return array;
}
void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1)
            Console.Write(",");
    }


    Console.WriteLine("]");
}

Console.Write("Введите число - размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateUserArray(length);
Console.Write("Создан массив: ");
ShowArray(myArray);*/