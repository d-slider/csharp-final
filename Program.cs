Console.Clear();
string[] array = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

string[] SelectArray(string[] array)
{
    var myList = array.ToList(); // Создаём коллекцию из массива.

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3)
        {
            myList.Remove(array[i]); // Удаляем ненужные элементы из коллекции.
        }
    }
    string[] selectedArray = myList.ToArray(); // Преобразуем коллекцию обратно в массив.
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
