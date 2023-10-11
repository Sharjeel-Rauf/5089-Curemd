int[] unsortedarray = new int[5];
unsortedarray[0] = 3;
unsortedarray[1] = 4;
unsortedarray[2] = 9;
unsortedarray[3] = 8;
unsortedarray[4] = 4;
int Maxnum = unsortedarray[0];
int Minnum = unsortedarray[0];
for (int i = 1; i < unsortedarray.Length; i++)
{
    if (unsortedarray[i] > Maxnum)
    {
        Maxnum = unsortedarray[i];
    }
    if (unsortedarray[i] < Minnum)
    {
        Minnum = unsortedarray[i];
    }
}
Console.WriteLine("The maximum no. in the array is:"+Maxnum);
Console.WriteLine("The minimum no. in the array is:"+Minnum);
