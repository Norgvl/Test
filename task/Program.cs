Console.Clear();

string[] arr = new string[5];
FillArr(arr);
Console.WriteLine($"Новый массив: ['{String.Join("','", ChangeArr(arr))}']");

void FillArr(string[] list) // заполнение массива с клавиатуры
{
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"Введите {i+1}-ю строку массива: ");
        list[i] = Console.ReadLine();
    }
}

string[] ChangeArr(string[] array)
{
    int size = 0; 
    foreach (string el in array) // размер нового массива
    {
        if (el.Length <= 3)
        {
            size++;
        }
    }
    if (size == 0) // Если в массиве нет подходящий элементов - вернуть массив состоящий из пустой строки
    { 
        string[] arr = new string[1];
        arr[0] = String.Empty;
        return arr;

    }
    else // иначе создать и заполнить массив с размером size, вернуть его
    {
        string[] newArr = new string[size];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArr[j] = array[i];
                j++;
            }
        }
        return newArr;
    }
}