string PrintArr(string[] array)
{
    return string.Join(", ", array);
}

void Print(string text)
{
    Console.WriteLine(text);
}

int FindCount(string[] array, int size)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            count++;
        }
    }
    return count;
}



string[] FindLengthThree(string[] array, int size, int count)
{
    string[] newArray = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

int sizeFindLength = 3;
string[] array = { "12341", "15671", "-2", "computer science", "22", "HELLO!!!!!", "-98" };
int count = FindCount(array, sizeFindLength);
string[] newArray = FindLengthThree(array, sizeFindLength, count);
Print($"The string array is shorter {sizeFindLength} characters => [{PrintArr(newArray)}]");

