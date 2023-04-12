

int n, ans = 0;
int[]  num=new int[] { 5, 4, 3, 2, 1 };
n = int.Parse(Console.ReadLine());
for (int i = 0; i < 5; i++)
{
    ans = ans+ n / num[i];
    n=n % num[i];
}
Console.WriteLine(ans);