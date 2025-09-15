int[] array = new int[]{ 1, 2, 3, 4, 5, 66, 6, 8, 9, 12 };
Console.WriteLine(linearSearch(array, 666));

bool linearSearch(int[] array, int key)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == key)
        {
            return true;
        }
    }
    return false;
}