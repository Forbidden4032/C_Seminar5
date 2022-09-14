// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
    {
        int[] array = new int[size];
        var random = new Random();

        for(int i = 0; i < array.Length; i++)
            {
            array[i] = random.Next(100, 999);
            }
    return array;
    }

int Digital(int[] array)
    {   int summ = 0;
        for(int i = 0; i < array.Length; i++)
            if(array[i]%2 == 0)
                {
                    summ = summ + 1;
                }
    return summ;
    }


int[] newArray = CreateArray(100);
int newDigital = Digital(newArray);
Console.WriteLine($"Количество четных чисел в массиве: {newDigital}");

