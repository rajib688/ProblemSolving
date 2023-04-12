

int[] arr = new int[100];
int n = Console.Read();
int j = Console.Read();

int p = 0;

for (int i = 0; i < n; i++)
{
    arr[i] = Console.Read();
}
for (int i = 0; i < n; i++)
{
	if (arr[i] >= arr[j-1] && arr[i]>0)
	{
		p++;
	}
}
Console.WriteLine(p);