

int k, n, w;
k = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
w = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i <= w; i++)
{
	sum = sum + i;
}
int d = (sum * k) - n;
if (d<0)
{
	Console.WriteLine("0");
}
else
{
	Console.WriteLine(d);
}