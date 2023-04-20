int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
var userInput = str.Split(' ');
while (n>0)
{
    int[] arr = new int[3];
	for (int i = 0; i <=2; i++)
	{
		arr[i] = int.Parse(userInput[i]);
	}
	//Array.Sort(arr, arr + 3);
}