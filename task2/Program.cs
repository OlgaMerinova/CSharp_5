//Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, 
//стоящих на нечётных позициях (позиция - индекс элемента в массиве).

//[3, 7, 23, 12] -> 12
//[4, 6, 8, 1, 4] -> 6

int N = new Random().Next();
int[] array = new int[N];
Random rand = new Random();
for (int i = 0; i < N; i++)
{
   array[i] = rand.Next();
}

int sum = 0;
for (int i=0; i<N; i++)
{
    if (i % 2 > 0)
    {
        if (array[i] % 2 == 0)
        {
            
            sum = sum + array[i];
        }
    }
}
Console.WriteLine(sum);
