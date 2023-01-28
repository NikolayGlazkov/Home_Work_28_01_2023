
//Найдите разницу между максимальным и минимальным элементов случайного массива массива.


int[] array = new int[4]; // создание массива длинной 10 чисел
Random random = new Random(); //рандом


for(int i = 0; i < array.Length; i++) //заполняет цикл случайными числами, самый сложный момент для понимания мною
{
    array[i] = random.Next(100,1000);
}

int min = array.AsEnumerable().Min();
int max = array.AsEnumerable().Max();



for (int i = 0; i < array.Length; i++)   // вывод массива в кансоль
{
    Console.Write(array[i] + " ");
}


int anser = (max  - min);
Console.WriteLine("Разность между максимальным и минимальным элементом: " + anser);

