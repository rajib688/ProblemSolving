
string Str = Console.ReadLine();

string s = Str.ToLower();

int count = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i]!= 'a' && s[i]!= 'e' && s[i]!= 'i' && s[i]!= 'o' && s[i]!= 'u' && s[i]!= 'y')
    {
        count++;
    }
}
Console.Write(".");

int pount = 0;
for (int j = 0; j < s.Length; j++)
{
    if (s[j] != 'a' && s[j] != 'e' && s[j] != 'i' && s[j] != 'o' && s[j] != 'u' && s[j] != 'y' && pount!=count-1)
    {
        Console.Write(s[j]+".");
        pount++;
    }
    else if (s[j] != 'a' && s[j] != 'e' && s[j] != 'i' && s[j] != 'o' && s[j] != 'u' && s[j] != 'y' && pount == count - 1)
    {
        Console.WriteLine(s[j]);
    }
}
