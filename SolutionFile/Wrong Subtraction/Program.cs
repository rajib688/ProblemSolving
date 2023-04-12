


int n = int.Parse(Console.ReadLine());

int a = int.Parse(Console.ReadLine());

for ( int i = 0; i < a; i++)
{
   
	if (n%10==0)
	{
		n = n / 10;
	}
	else
	{
		n = n - 1;
	}
}
Console.WriteLine(n);