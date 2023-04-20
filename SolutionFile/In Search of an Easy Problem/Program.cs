

//int n = int.Parse(Console.ReadLine());
//int[] a = new int[n];
//string userInput = Console.ReadLine();
//var SplitItem = userInput.Split(' ');
//for (int i = 0; i < n; i++)
//{
//    a[i] = int.Parse(SplitItem[i]);
//}
//for (int i = 0; i < n; i++)
//{
//	if (a[i] == 0)
//	{
//		Console.WriteLine("EASY");
//	}
//	else
//	{	
//		Console.WriteLine("HARD");
//    }
//}


int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
string userinput = Console.ReadLine();
var inputitem = userinput.Split(' ');
while (n>0)
{
	a[n-1] = int.Parse(inputitem[n-1]);
	
	if (a[n] == 1)
	{
		Console.WriteLine("HARD");
	}
	n--;
}
Console.WriteLine("EASY");