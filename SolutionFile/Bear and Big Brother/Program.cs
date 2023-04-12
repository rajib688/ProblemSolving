



int a, b, c = 0;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if (a>b)
{
    c = 0;
}
else
{
    while (a <= b)
    {
        a = a * 3;
        b = b * 2;
        c++;
    }
    Console.WriteLine(c);
}
