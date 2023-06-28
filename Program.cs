﻿/*

34. Задайте массив, заполненный случайными положительными трехзначными числами.
Напишите программу, кот. покажет количество четных чисел в массиве.


int Input(string message)
{
   Console.WriteLine(message);
   return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
   return new int[size];
}

void FillArray(int[]array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 1000); 
    
}
string PrintArray(int[] array)
{
   string res = String.Empty;
   for (int i = 0; i < array.Length; i++)
   {
      res += array[i] + " ";
   }
   return res;
}

int EvenNumbered(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
        return count;
}   

int size = Input("Введите размер массива: ");
int [] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
int count = EvenNumbered(myArray);
Console.WriteLine($"Количество четных чисел в массиве равно: {count}."); 


35. Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, находящихся на нечетных позициях.
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(); 
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int Sum(int [] array)
{
    int num = 0;
    for (int i = 1; i < array.Length; i+=2)
    num += array[i];
    return num;
}
int size = InputNum("Введите размер массива: ");
int [] myArray = CreateArray(size);
FillArray(myArray);
string res = PrintArray(myArray);
Console.WriteLine(res);
int num = Sum(myArray);
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {num}.");

/*

int size = Input("Введите размер массива: ");
int [] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
int count = EvenNumbered(myArray);
Console.WriteLine($"Количество четных чисел в массиве равно: {count}."); 
38. Задайте массив вещественных чисел. 
 Найдите сумму между минимальным и максимальным значениями массива.


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(double[] array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(); 
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
    Console.WriteLine("]");
}

void MinMax(int[] array)
{
int max = 0;
int min = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = i;
        else if (arr[i] < min) min = i;
    }
}

Console.WriteLine("Найти сумму макс и мин элементов массива вещественных чисел.");
int size = InputNum("Введите размер массива: ");
CreateArray(size);
FillArray(arr);
PrintArray(arr);
MinMax(int[] arr);
Console.WriteLine($"Сумма макс и мин значений равна: {arr[max] - arr[min]}");
*/


