

string input = Console.ReadLine();

int a=0, b=0, c=0;

for (int i = 0; i < input.Length; i++)
{
	if (input[i] == '1')
	{
		a++;
		b = 0;
	}
	else
	{
		b++;
		a = 0;
	}
	if (a==7 || b==7)
	{
		c = 1;
	}
}
if (c==1)
{
	Console.WriteLine("YES");
}
else
{
	Console.WriteLine("NO");
}