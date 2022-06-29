/* Задача 41: Пользователь вводит с клавиатуры M чисел.
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

/* Console.WriteLine("Введите числа через запятую");
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
Console.WriteLine($"Отрицательных чисел: {NegativeNums}"); */

/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1 >>>         k1*x + 1*y + b1 = 0
y = k2 * x + b2 >>>         k2*x + 1*y + b2 = 0 
                            a       b      c
значения b1, k1, b2 и k2 задаются
пользователем. */

Console.WriteLine("Введите параметр b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр k2");
double k2 = double.Parse(Console.ReadLine());
double x;
double y;

if (k1 == k2)
{
    Console.WriteLine("Точек пересечения нет, прямые параллельны");
}
else if (k1 == k2 && k1 * b2 == k2 * b1 &&  b2 == b1 )
{
    System.Console.WriteLine("Прямые совпадают и имеют бесконечное количество решений");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * (b2-b1)/(k1-k2)+b1;
   Console.WriteLine($"Координаты точки пересечения M ({x}, {y})");
}