﻿/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь. */

// Вариант 1
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
    Console.WriteLine("Введите число через Enter, для завершения - end");
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

// Вариант 2 по материалам семинара
Console.WriteLine("Введите числа через запятую");
string s = Console.ReadLine();
string [] nums = s.Split(',');
int NegativeNums = 0;
for (int i = 0; i < nums.Length; i ++)
  {
    Console.Write(nums[i] + " ");
    int num = int.Parse(nums[i]); 
    if (num < 0)
    {
        NegativeNums ++;
    }
  }
Console.WriteLine();
Console.WriteLine($"Отрицательных чисел: {NegativeNums}");