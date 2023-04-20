
int n, Count = 0;
n = int.Parse(Console.ReadLine());
int[] a = new int[n];
string userinput = Console.ReadLine();
var inputitem = userinput.Split(' ');
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputitem[i]);
    if (a[i] == 1)
    {
        Count++;
    }
}
if (Count == 0)
{
    Console.WriteLine("EASY");
}
else
{
    Console.WriteLine("HARD");
}