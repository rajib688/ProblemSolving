


string str;
int temp = 0;
str = Console.ReadLine();
for (int i = 0; i < str.Length; i++)
{
	if (str[i]>=33 && str[i]<=126)
	{
		if (str[i] == 'H' || str[i] == 'Q' || str[i] == '9')
		{
			temp = 1;
		}
	}	
}
if (temp == 1)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
