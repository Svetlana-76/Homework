// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите число строк");
// int rous=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int columns=Convert.ToInt32(Console.ReadLine());
// GetArray();
// int [,] matrix=GetArray();
// PrintArray(matrix);
// Console.WriteLine();
// PrintArray(ChangeArray(matrix));

// int [,] GetArray ()
// {
//     int [,]result=new int [rous,columns];
//         for (int i = 0; i < result.GetLength(0); i++)
//         {
//             for (int j  = 0; j < result.GetLength(1); j++)
//             {
//                 result[i,j]=new Random().Next(10);
                
//             }  
//         }
//      return result;
// }

// int [,] ChangeArray (int[,] result)
// {
//     int change=0;
//     int [,]newArray=new int [result.GetLength(0),result.GetLength(1)];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
            
//             for (int m = 0; m < result.GetLength(1)-1; m++)
//             {
//                 if (result[i,m]<result[i,m+1])
//                 {
//                     change=result[i,m+1];
//                     result[i,m+1]=result[i,m];
//                     result[i,m]=change;
//                 }          
//             }
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i, j]+" ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] rectangle = new int[4, 6];
GetArray_2(rectangle);
PrintArray_2(rectangle);
Console.WriteLine();
RowMinSum(rectangle);


void GetArray_2(int[,] array_2)
{
    for (int i = 0; i < array_2.GetLength(0); i++)
    {
        for (int j = 0; j < array_2.GetLength(1); j++)
        {
            array_2[i, j] = new Random().Next(10);
        }
    }
}

void RowMinSum(int[,] array_2)
{
    int minsum =int.MaxValue;
    int minrow = 0;
    int sum = 0;
    
    for (int i = 0; i < rectangle.GetLength(0); i++)
    {
        for (int j = 0; j < rectangle.GetLength(1); j++) 
        {
            sum= sum+rectangle[i, j];
        }
        if (sum < minsum)
            {
            minsum = sum;
            minrow = i+1;
            }
        sum = 0;
    }       
        
    Console.Write(minrow +" строка  ");
}
    



void PrintArray_2(int[,] array_2)
{
    for (int i = 0; i < array_2.GetLength(0); i++)
    {
        for (int j = 0; j < array_2.GetLength(1); j++)
        {
            Console.Write(array_2[i, j]+" ");
        }
        Console.WriteLine();
    }
}



