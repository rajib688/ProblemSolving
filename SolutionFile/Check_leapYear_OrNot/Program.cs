
Console.Write("Enter your Input: ");
int leapYear = int.Parse(Console.ReadLine());

if (leapYear % 4 ==0 || leapYear % 400==0 || leapYear % 100==0)
{
    Console.WriteLine(leapYear + " is a Leap year");
}
else
{
    Console.WriteLine(leapYear + " is not Leap year");
}