// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// Console.WriteLine("Введите количество строк");
// int m=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n=Convert.ToInt32(Console.ReadLine());

// double [,] table=new double [m,n];

// for (int i = 0; i < table.GetLength(0); i++)
// {
//     for (int j  = 0; j < table.GetLength(1); j++)
//     {
//         table[i,j]=Convert.ToDouble(new Random().Next(100))/5;
//         Console.Write(table[i,j]+" ");
//     }
//     Console.WriteLine();
// }
// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер строки");
// int m=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int n=Convert.ToInt32(Console.ReadLine());

// int [,] array=new int [4,5];



// if (m > array.GetLength(0) || n > array.GetLength(1))
// {
//      Console.WriteLine("Такого элемента нет");

// }
// else 
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j  = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]=Convert.ToInt32(new Random().Next(100));
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(array[m-1, n-1]);
// }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] numbers=new int [4,4];



for (int i = 0; i < numbers.GetLength(0); i++)
    {
        double average=0;
        int summ=0;
        for (int j  = 0; j < numbers.GetLength(1); j++)
        {
            
            numbers[i,j]=Convert.ToInt32(new Random().Next(100));
            summ=summ+numbers[i,j];
            Console.Write(numbers[i,j]+" ");
        }
        
        Console.WriteLine();
        average=Convert.ToDouble(summ)/Convert.ToDouble(numbers.GetLength(1));
        Console.WriteLine("Среднее арифметическое: "+average);
    }
   
