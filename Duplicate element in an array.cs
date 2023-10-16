int[] arr1 = new int[4];

for (int i = 0; i < arr1.Length; i++)
{
    Console.WriteLine("Please enter the " + i + " element:");
    arr1[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The " + i + " element of the array is:" + arr1[i]);
}
int a = 1;
for (int j = 0; j < arr1.Length; j++)
{
    for (int i = j + 1; i < arr1.Length; i++)
    {
        if (arr1[j] == arr1[i])
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
    if (a==0)
    {
    Console.WriteLine("True");
}






