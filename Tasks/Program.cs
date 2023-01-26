/* Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите 1-ое число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a, i = 1;
while (i < b)
{
    result = result * a;
    i++;
}
Console.WriteLine(result); */


/* Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
int sum = 0;
while (n > 0)
{
    m = n % 10;
    sum = sum + m;
    n = n / 10;
}
Console.WriteLine(sum); */

/* Задача 29: 
Напишите программу, которая принимает на вход 8 элементов массива и выводит массив на экран.

Console.Clear();
int[] array = new int[8];
Console.Write("Введите элементы массива: ");
for (int i = 0; i < 8; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: [{string.Join(", ", array)}]"); */
 
/* Гипотеза Гольдбаха.

Console.Clear();
int n1 = 0, n2 = 0;
Console.Write("Введите четное число от 4 до 998: ");
int n = Convert.ToInt32(Console.ReadLine());
bool f(int chislo)
{
    for (int j = 2; j < chislo - 1; j++)
        if (chislo % j == 0)
            return false;
    return true;
}
for (int i = 2; i < n / 2 + 1; i++)
    if (f(i) && f(n - i))
    {
        n1 = i;
        n2 = n - i;
        break;
    }
Console.WriteLine("{0}+{1}={2}", n1, n2, n);*/