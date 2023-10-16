int[] arr2 = { 1,0,1,1};
int k = 1;
int a = 1;
for(int i=0; i<=arr2.Length;i++)
{
    for (int j=i+1; j<arr2.Length && Math.Abs(i-j)<= k;j++)
    {
        if (arr2[i] == arr2[j])
        {
            Console.WriteLine("True");
            a = 0;
            break;
        }
    }
  
}
if (a==1)
{
    Console.WriteLine("False");
}

