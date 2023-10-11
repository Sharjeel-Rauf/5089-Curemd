
Console.WriteLine("Please enter a string");
string enterString = Console.ReadLine();

char[] Thestring = enterString.ToCharArray();
int left;
int right = Thestring.Length - 1;
for (left = 0; left < right; left++, right--)
{
    if (Thestring[left] != Thestring[right])
    {
        Console.WriteLine("It is not a palindrome");
    }
    else
    {
        Console.WriteLine("It is a palindrome");
        break;
    }

}





