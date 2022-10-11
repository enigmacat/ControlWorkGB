// ищем в массиве элементы с длиной <=3 и создаем новый
string[] GenArray(string[] arr)
{
    // определяем длину будущего массива с элементами нужной длины
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    // создаем итоговый массив
    string[] newarr = new string[count];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarr[j] = arr[i];
            j++;
        }
    }
    return newarr;
}

// печатаем массив
void Print1DArr(string[] arr)
{
    Console.Write("[");
    if (arr.Length > 1)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1] + "]");
    }
    if (arr.Length == 1)
    {
        Console.WriteLine(arr[0] + "]");
    }
    if (arr.Length == 0)
    {
        Console.WriteLine("]");
    }
}

string[] array = { "hello", "GB", "world", "is", "geek", "fun", ":-)" };
// string[] array = { "hello", "GB", "world", "geek" };
// string[] array = { "hello", "world", "geek" };
string[] newarr = GenArray(array);
Print1DArr(array);
Console.WriteLine();
Print1DArr(newarr);