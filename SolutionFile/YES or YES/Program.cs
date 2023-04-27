int n = int.Parse(Console.ReadLine());
while(n>0)
{
    string s = Console.ReadLine();
    int A = 0;
    if (s[0] == 'y' || s[0] == 'Y')
    {
        A++;
    }
    if (s[1] == 'e' || s[1] == 'E')
    {
        A++;
    }
    if (s[2] == 's' || s[2] == 'S')
    {
        A++;
    }
    if (A==3)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
    n--;
}