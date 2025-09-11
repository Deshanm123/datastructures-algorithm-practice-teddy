int[] intArr = { -22, -15, 7, 20, 30, 54 };

Console.WriteLine(BinarySearch(intArr,7)); 


int BinarySearch(int[] sorrtedNumberArr, int key)
{
    int start = 0;
    int end = sorrtedNumberArr.Length-1;
    while (start <= end)
    {
        int mid = (start + end )/ 2;
        if (sorrtedNumberArr[mid] == key)
        {
            return mid;
        }
        else if (sorrtedNumberArr[mid] > key)
        {
            end = mid-1;
        }
        else if (sorrtedNumberArr[mid] < key)
        {
            start = mid+1 ;
        }
    }

    return -1;
}