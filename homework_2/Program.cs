// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число");
int number=Convert.ToInt32(Console.ReadLine());
int centernumber=0;

if (number>=100)
{
    if (number<1000) 
    {
        centernumber=(number%100)/10;
        Console.WriteLine(centernumber);
    }
    else 
    {
        Console.WriteLine("Вы ввели неверное число");
    }
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
int num3=0;

if (num>=100)
{
    while (num>=1000)
    {
        
        num=num/10;
       
    }
    num3=num%10;
    Console.WriteLine(num3);
}
else
    {
        Console.WriteLine("Третьей цифры нет");
    }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int daynumber=Convert.ToInt32(Console.ReadLine());

if (daynumber<=0)
{
    Console.WriteLine("Такого дня нет");
}
else if (daynumber<6)
{
    Console.WriteLine("Нет");
}
else if (daynumber<8)
{
    Console.WriteLine("Да");
}
else if (daynumber>7)
{
    Console.WriteLine("Такого дня нет");
}
