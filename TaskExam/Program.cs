/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

void PrintArrayOfStrings(string[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int Count3CharElements (string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string [] NewArrayWith3CharElements (string[] arr, int size)
{
    string[] newArr = new string [size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

string[] array = {"Hello", "2","world", ":-)"};
//string[] array = {"Russia", "Denmark","Kazan"};
Console.Write("[");
PrintArrayOfStrings (array, ", ");
Console.WriteLine("]");

int sizeNewArr = Count3CharElements (array);
if (sizeNewArr == 0) Console.WriteLine ("В данном массиве нет строк с длиной не более 3");
else
{
    string[] newArray = new string [sizeNewArr];
    newArray = NewArrayWith3CharElements (array, sizeNewArr);
    PrintArrayOfStrings (newArray, ", ");
}