﻿// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4]{345, 898, 568, 234}; // создание массива длинной 10 чисел

int counter = 0;


for(int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)

{
    counter +=1;
   
}
}
Console.WriteLine(counter);
