
string[] array1 = new string[6] {"589", "add", "4578", "67ad", "-78num", "10"};
string[] array2 = new string[array1.Length];
int count = 0;
void InputArray(string[] array1, string[] array2)
{
   
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void ReleaseArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
InputArray(array1, array2);
ReleaseArray(array2);
