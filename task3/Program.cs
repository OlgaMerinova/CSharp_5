//Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


int[] array = new int[] {3, 7, 22, 2, 78};
int max_number = 0;
int min_number = 0;
int mean = 0;
for (int i=0; i<array.Length; i++)
{
    for (int j=i+1; j<array.Length; j++)
    {
        if (array[j] > array[i])
        {
            max_number = array[j];
            min_number = array[i];
        }
    }  
}
mean = max_number - min_number;
Console.WriteLine(mean);
