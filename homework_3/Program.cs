// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число");
string numbers=Console.ReadLine();

if (numbers.Length==5)
{
    if (numbers[0]==numbers[4]&&numbers[1]==numbers[3])
        {
        Console.WriteLine("Да");
        }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным");
}


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты X для точки 1");
int X1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y для точки 1");
int Y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z для точки 1");
int Z1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X для точки 2");
int X2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y для точки 2");
int Y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z для точки 2");
int Z2=Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
Console.WriteLine(d);

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=num; i++)
{
    Console.Write("," + i*i*i);
}
