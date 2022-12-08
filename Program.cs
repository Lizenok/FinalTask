Console.WriteLine("Введите колличество эллементов массива:");
int userInt = Convert.ToInt32(Console.ReadLine());
string[] usersArray = fillArray(userInt);
printArray(usersArray);
int count = 0;
for (int i = 0; i < usersArray.Length; i++)
{
    if(usersArray[i].Length <= 3)
    {
        count++;
    }
}
string[] newArray = new string[count];
fillNewArray(usersArray, newArray);
printArray(newArray);

string[] fillArray(int number)
{
    string[] arrayOfStrings = new string[number];
    for (int i = 0; i < number; i++)
    {
       Console.WriteLine($"Введите значение {i + 1} элемента");
       arrayOfStrings[i] =  Console.ReadLine();
    }
    return arrayOfStrings;
}

void printArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",\t");
        }
    }
        Console.WriteLine("]");
}

void fillNewArray(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}