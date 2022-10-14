// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

string[] array = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};

string[] SelectArray(string[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count += 1;
        }
    }
    
    string[] selectedArray = new string[count];
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) 
            {
                selectedArray[j] = array[i];
                j += 1;
            }
        }
    }
    return selectedArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

string[] result = SelectArray(array);
PrintArray(result);