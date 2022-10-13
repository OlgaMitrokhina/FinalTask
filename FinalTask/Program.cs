string [] array1 = new string [7] {"Hello", "Russia", "2", "1234", "123", "Computer", "12"};
string [] array2 = new string[array1.Length];

void NewFormedArray (string [] array1, string [] array2)
{
    int count =0;
    for (int i =0; i < array1.Length; i++)
    {
        if(array1[i].Length <=3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray (string [] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

NewFormedArray(array1, array2);
Console.WriteLine("Исходный массив: ");
PrintArray(array1);
Console.WriteLine("Новый массив: ");
PrintArray(array2);