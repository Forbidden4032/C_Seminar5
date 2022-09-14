//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateArray(int size)
    {
        int[] array = new int[size];
        var random = new Random();
        for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
    return array;
    }

int Summ(int[] array)
    {
        int summ = 0;
        for(int i = 0; i < array.Length; i++)
            {
                if(i%2 != 0)
                    {
                        summ = summ + array[i];
                    }
            }
    return summ;
    }

int[] newArray = CreateArray(10);
int newSumm = Summ(newArray);
Console.WriteLine($"Сумма элементов на нечетных позициях: {newSumm}");



