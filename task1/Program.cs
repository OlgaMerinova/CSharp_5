//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


//int[] array = new int[] {345, 897, 568, 234};
int N = new Random().Next();
int[] array = new int[N];
for (int index = 0; index < N; index++)
{
   array[index] = new Random().Next(100, 1000);
}

int count = 0;
int i = 0;
while (i < array.Length)
{  
    if (array [i] % 2 == 0)
    {
       count++;
    }
    i++;
}
Console.WriteLine(count);


