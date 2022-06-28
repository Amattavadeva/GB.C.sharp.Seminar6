/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь. */

/* int[] GeneralArr = new int[100];
int i = 0;
string EnteringNum;
int count = 0;

void CheckNumber(int[] array)
{
    int NegativeNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            NegativeNum++;
        }
    }
    System.Console.WriteLine($"Отрицательных чисел: {NegativeNum}");
}

void Print(int[] array)
{
    Console.WriteLine("Ваш массив: ");
    for (int j = 0; j < count; j++)
    {
        Console.Write(GeneralArr[j] + " ");
    }
}

do
{
    Console.WriteLine("Введите числа через Enter, для завершения - end");
    EnteringNum = Console.ReadLine();
    if (EnteringNum == "end")
        break;
    GeneralArr[i] = Convert.ToInt32(EnteringNum);
    i++;
    count++;
}
while (true);


Print(GeneralArr);
Console.WriteLine();
CheckNumber(GeneralArr); */

/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем. */

