int[] arr1 = {1,2,3,1};

//for (int i = 0; i < arr1.Length; i++)
//{
//    Console.WriteLine("Please enter the " + i + " element:");
//    arr1[i] = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("The " + i + " element of the array is:" + arr1[i]);
//}

for (int j = 0; j < arr1.Length; j++)
{
    for (int i = 0; i < arr1.Length; i++)
    {


        if (arr1[j] == arr1[i])
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

    }
}






