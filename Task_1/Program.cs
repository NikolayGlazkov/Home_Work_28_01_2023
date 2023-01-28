// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = new int[4]; // создание массива длинной 10 чисел
Random random = new Random(); //рандом


for(int i = 0; i < array.Length; i++) //заполняет цикл случайными числами, самый сложный момент для понимания мною
{
    array[i] = random.Next(100,1000);
}

int counter = 0;


for(int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)

{
    counter +=1;
   
}
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine(counter);
