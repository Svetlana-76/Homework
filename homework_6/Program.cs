// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел");
int num=Convert.ToInt32(Console.ReadLine());

int i=1;
int count=0;

while (i<=num)
{
    Console.WriteLine("Введите число");
    int num1=Convert.ToInt32(Console.ReadLine());
    i++;
    if (num1>0)
    {
        count++;
    }
}
Console.WriteLine(count);
