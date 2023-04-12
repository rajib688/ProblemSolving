

Console.Write("Enter your Input: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    String st = Console.ReadLine();
    int length = st.Length;
    if (length <= 10)
    {
        Console.WriteLine(st);
    }
    else
    {
        Console.WriteLine("" + st[0] + (length - 2) + st[length - 1]);
    }
}