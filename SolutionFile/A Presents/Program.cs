

int n = int.Parse(Console.ReadLine());
int[] a = new int[n];

string UserInput = Console.ReadLine();

var splititem = UserInput.Split(' ');

for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(splititem[i]);
}

for (int j = 1; j <= n; j++)
{
    for (int i = 0; i < n; i++)
    {
        if (a[i] == j)
        {
            Console.Write(i + 1 + " ");
            break;
        }
    }
}