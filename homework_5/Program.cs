// Задайте массив заполненный случайными положительными 
// трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел 
// в массиве.

// [345, 897, 568, 234] -> 2

int [] array = new int [4];
int count=0;
for (int i = 0; i < array.Length; i++)
{
    array [i]=new Random().Next(100,1000);
    Console.Write(array[i]+"  ");
    if (array [i]%2==0)
    {
        count++;
    }
}
Console.WriteLine(count);


// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] array2=new int[5];
int sumodd=0;

for (int i = 0; i < array2.Length; i++)
{
    array2[i]=new Random().Next(0,501);
    Console.Write(array2[i]+"  ");

    if (i%2>0)
    {
        sumodd=sumodd+array2[i];
    }
}
Console.WriteLine(sumodd);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] array3=new int[4];
int max=int.MinValue;
int min=int.MaxValue;
int result=0;
for (int i = 0; i < array3.Length; i++)
{
    array3[i]=new Random().Next(1,20);
    Console.Write(array3[i]+"  ");
    if (array3[i]>max)
    {
        max=array3[i];
    }
    if (array3[i]<min)
    {
        
        min=array3[i];
        
    }
    result=(max-min);
}
Console.WriteLine(result);

