// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int N=Convert.ToInt32(Console.ReadLine());

// string PrintNumber (int end, int start)
// {
//     if (end==start)
//     {
//         return end.ToString();
//     }

//     return(end+" "+PrintNumber(end-1, start));

// }
// Console.WriteLine(PrintNumber(N,1));

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите первое число");
// int M=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int N=Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int start, int end)
// {
//     if (end==start)
//     {
//         return end;
//     }
   
//     return(start+SumNumbers(start+1,end));

// }
// Console.WriteLine(SumNumbers(M,N));

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());


int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else
    {
        return (AkkermanFunc(m - 1, AkkermanFunc(m, n - 1)));
    }
}
Console.WriteLine("A("+m+","+n+")"+"="+AkkermanFunc(m, n)); 