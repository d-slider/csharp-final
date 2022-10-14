Console.Clear();
string[] array = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

string[] SelectArray(string[] array)
{
    string temp = "";

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            temp += array[i];
            if (i < array.Length - 1) temp += "#"; // # - это разделитель. Доп. условие нужно, чтобы не добавлять крайний разделитель.
        }
    }
    string[] selectedArray = temp.Split('#'); // разбиваем строку обратно в массив 

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