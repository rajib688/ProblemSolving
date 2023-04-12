


string str = Console.ReadLine();
string h = "hello";
int j=0;
for (int i = 0; i < str.Length; i++)
{
	if (str[i] == h[j])
	{
		j++;
		if (j==h.Length)
		{
			break;
		}	
	}
}
if (j == h.Length)
{
	Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}