Console.WriteLine("Please enter a string:");
string thestring = Console.ReadLine();
char[] newstring = thestring.ToCharArray();

for(int i = 0; i<= newstring.Length - 1; i++)
{
    Console.WriteLine(newstring[i]);
}
