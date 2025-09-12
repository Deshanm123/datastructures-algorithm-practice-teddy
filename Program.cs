int[] intArr = { 6, 5, 1, 7, 2, 4 };

foreach (var digit in BubbleSort(intArr)) {
    Console.WriteLine(digit);
}

 int[] BubbleSort(int[] arr)
{
    //iteration loop
    for (int pointer = 0; pointer < arr.Length; pointer++)
    {
        //sorting loop
        for (int sorter = 0; sorter < arr.Length - pointer - 1; sorter++)
        {
            // int currrent = arr[sorter];
            //int next = arr[sorter + 1];
            if (arr[sorter] > arr[sorter + 1])
            {
                int temp = arr[sorter + 1];
                arr[sorter + 1] = arr[sorter];
                arr[sorter] = temp;
            }
        }

    }
    return arr;
}