string[] array1 = { "12345", "variant", "12", "class", "row", "world", ":)"};
string[] array2 = new string[array1.Length];
void FillArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array2)
{
    Console.Write("[");
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            i++;
            Console.Write(array2[count] + ", ");
        }
    }
    Console.Write(array2[array1.Length - 1] + "]");
    Console.WriteLine();
}
FillArray(array1, array2);
PrintArray(array2);