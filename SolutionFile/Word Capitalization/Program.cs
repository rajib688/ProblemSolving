
class Program
{
    static void Main()
    {
       string str = UppercaseFirst(Console.ReadLine());
       Console.WriteLine(str);
    }
    static string UppercaseFirst(string s)
    {    
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }      
        return char.ToUpper(s[0]) + s.Substring(1);
    }
}
