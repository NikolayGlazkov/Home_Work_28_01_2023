// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = new int[4]; // создание массива длинной 10 чисел
Random random = new Random(); //рандом


for(int i = 0; i < array.Length; i++) //заполняет цикл случайными числами, самый сложный момент для понимания мною
{
    array[i] = random.Next(100,1000);
}

int counter = 0;  // будет считать сумму


for(int i = 0; i < array.Length; i++) // цикл проверки условия
{
if (array[i] % 2 != 0)

{
    counter +=array[i];
   
}
}

for (int i = 0; i < array.Length; i++)   // вывод массива в кансоль
{
    Console.Write(array[i] + " ");
}


Console.WriteLine();    //отступ строки
Console.WriteLine(counter);
