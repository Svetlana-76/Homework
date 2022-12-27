// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A");
int numA=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numB=Convert.ToInt32(Console.ReadLine());

int i=1;
while (numB>0)
{
   i*=numA;
   numB=numB-1;
}
Console.WriteLine(i);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число");
int numbers1=Convert.ToInt32(Console.ReadLine());
string num1=Convert.ToString(numbers);
int sum1=0;
for (int ind1=0; ind1<num1.Length; ind1++)
{
   sum1=sum1+Convert.ToInt32(num1[ind1].ToString());
}
         
Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] Array8 ()
{
   int [] array=new int [8];
   for (i=0; i<array.Length; i++)
   {
      Console.WriteLine("Введите элемент массива");
      array[i]=Convert.ToInt32(Console.ReadLine());
   }
   return array;
}
Console.WriteLine(string.Join(",", Array8()));
