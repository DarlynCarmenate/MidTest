// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[] {"One", "foot", "in", "sea", "and", "one", "on", "shore"};
string[] array2 = new string[] {"To", "one", "thing", "constant", "never"};
string[] array3 = new string[] {"Then", "sigh", "not", "so", "but", "let", "them", "go"};

string[] CreateArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        count++;
    }
    string[] arr1 = new string[count];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
        arr1[j] = arr[i];
        j++;
        }
    }
    return arr1;
}

void PrintArray(string[] arr)
{
	int count = arr.Length;
    Console.Write("[");
	for(int pos = 0; pos < count - 1; pos++)
	{
		Console.Write($"{arr[pos]} ");
	}
    Console.Write($"{arr[arr.Length - 1]}] ");
}

PrintArray(array1);
Console.Write("-> ");
string[] new_arr = CreateArray(array1);
PrintArray(new_arr);
Console.WriteLine();

PrintArray(array2);
Console.Write("-> ");
string[] new_arr2 = CreateArray(array2);
PrintArray(new_arr2);
Console.WriteLine();

PrintArray(array3);
Console.Write("-> ");
string[] new_arr3 = CreateArray(array3);
PrintArray(new_arr3);
