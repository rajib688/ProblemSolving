

int n=int.Parse(Console.ReadLine());

int a, b;
int sum = 0, k = 0;
for (int i = 0; i < n; i++)
{
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());

    //(int a, int b) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

    sum = (a + k) - b;
    if (sum < 0)
    {
        k = 0;
    }
    else
    {
        k = sum;
    }
}
Console.WriteLine(sum);
