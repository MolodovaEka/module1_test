// Напишите программу, которая из имеющегося массива строк
// сформирует массив из строк, длина которых меньше либо равна 3 символа.

Console.WriteLine("Enter any number of strings of characters separated by spaces");
string[] array = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int countLength = DefineLength(array); 
Console.Write($"[{String.Join(",", FillNewArray(countLength))}]");

//---------------- methods --------------------------

int DefineLength(string[] array)
{
    int count = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3) count = count + 1;
        i++;
    }
    return count;
}

string[] FillNewArray(int countLength)
{
    int j = 0;
    string[] newArray = new string[countLength];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}