//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int MinMax(int[] array)
{   
    int max = array[0];
    int min = max;
    for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                {
                    max = array[i];
                }        
            if (array[i] < min)
                {
                    min = array[i];
                }
        }
        return max - min;
}


int[] array = new int [] {2,3,4,10,6,7,15};
int NewMinMax = MinMax(array);
Console.WriteLine(NewMinMax);