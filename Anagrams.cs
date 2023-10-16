Console.WriteLine("Enter first string: ");
string sr1 = Console.ReadLine();

Console.WriteLine("Enter 2nd string: ");
string sr2 = Console.ReadLine();

char[] char1 = sr1.ToCharArray();
char[] char2 = sr2.ToCharArray();

Array.Sort(char1);
Array.Sort(char2);

bool areEqual = char1.SequenceEqual(char2);

Console.WriteLine("result: " + areEqual);




