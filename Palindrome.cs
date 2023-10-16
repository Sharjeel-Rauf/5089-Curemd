//int[] arr1 = { 1, 3, 2, 3 };
//int target = 5;
//for (int i = 0; i < arr1.Length; i++)
//{
//    for (int j = i + 1; j < arr1.Length; j++)
//    {
//        if (arr1[i] + arr1[i + 1] == target)
//        {
//            Console.WriteLine("[" + i + "," + j + "]");
//            break;
//        }
//    }
//}

using System.ComponentModel.DataAnnotations;
string sa = "maham";
Console.WriteLine("Please enter a string");
string s = Console.ReadLine();
char[] char1 = s.ToCharArray();
int j = 0;
j = char1.Length - 1;
for (int i = 0; i < j ; i++,j--)
{
    if (char1[i] == char1[j])
    {
        Console.WriteLine("Palindrome");
        break;
    }
    else
    {
        Console.WriteLine("not a Palindrome");
        break;
    }
}