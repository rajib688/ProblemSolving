
int up = 0, lo = 0;
string s = Console.ReadLine();
for (int i = 0; i < s.Length; i++)
{
    if (Char.IsUpper(s[i]))
    {
        up++;
    }
    else
    {
        lo++;
    }
}
if (up < lo)
{
    for (int i = 0; i < s.Length; i++)
    {
        //s[i] = Char.ToLower(s[i]);
    }
    Console.WriteLine(s);
}
if (up > lo)
{
    for (int i = 0; i < s.Length; i++)
    {
        //s[i] = Char.ToUpper(s[i]);
    }
    Console.WriteLine(s);
}
if (up == lo)
{
    for (int i = 0; i < s.Length; i++)
    {
        //s[i] = Char.ToLower(s[i]);
    }
    Console.WriteLine(s);
}