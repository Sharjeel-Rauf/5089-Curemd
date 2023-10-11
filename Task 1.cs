
Console.WriteLine("Please enter a number n:");
int Number = Convert.ToInt32(Console.ReadLine());

int[] search = new int[4];
search[0] = 1;
search[1] = 2;
search[2] = 3;
search[3] = 4;
int a = 1;
for (int i=0; i<search.Length; i++)
{
    if (Number == search[i])
    {
        Console.WriteLine("Number found!!!");
        a = 0;
        break;
    }
    a = 1;
}
if (a==1)
{
    Console.WriteLine("Number not found!!!");
}


