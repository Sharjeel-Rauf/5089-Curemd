int[] arr1 = { 1, 3, 2, 3};
int target = 5;
for (int i=0; i<arr1.Length; i++)
{
    for (int j=i+1; j<arr1.Length; j++)
    {
        if (arr1[i] + arr1[i+1] == target)
        {
            Console.WriteLine("["+i + ","+ j+"]");
            break;
        }
    }
}