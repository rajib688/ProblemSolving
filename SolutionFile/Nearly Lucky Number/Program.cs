

long n = Int64.Parse(Console.ReadLine());
int Count = 0;
while (n!=0)
{
	if (n%10 == 4 || n%10 == 7)
	{
		Count = Count + 1;
	}
	n = n / 10;
}
if (Count == 4 || Count == 7 )
{
	Console.WriteLine("YES");
}
else
{
	Console.WriteLine("NO");	
}