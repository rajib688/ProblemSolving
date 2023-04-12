

string a = Console.ReadLine();  
string b = Console.ReadLine();

string lower = a.ToLower();
string lower1 = b.ToLower();

if (lower == lower1)
{
    Console.WriteLine("0");
}
else
{
	for (int i = 0; i < lower.Length; i++)
	{
		if (lower[i] < lower1[i])
		{
			Console.WriteLine("-1");
			break;
		}
		if (lower[i] > lower1[i])
		{
            Console.WriteLine("1");
            break;
        }
	}
}