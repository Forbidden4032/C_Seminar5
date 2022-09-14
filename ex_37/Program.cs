//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

int[] Array(int[] array)
{
    int[] NewArray = new int [array.Length/2];
    for(int i = 0, j = array.Length - 1; i < (array.Length/2); i++, j-- )
        {
            NewArray[i] = array[i] * array[j];
        }
    return NewArray;
}

int[] array = new int [] {1,4,7,8,9,5,6};
int[] ShowArray = Array(array);
for(int i = 0; i < ShowArray.Length; i++)
    {
        Console.WriteLine(ShowArray[i]);
    }


