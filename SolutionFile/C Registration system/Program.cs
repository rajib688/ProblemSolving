

using NHibernate.Mapping;
using System.Configuration;
using System.Linq;

int n = int.Parse(Console.ReadLine());

Dictionary<string, int> database = new Dictionary<string, int>();

string s;
while (n<0)
{
    s = Console.ReadLine();

    if (database.Count() == 0)
    {
        Console.WriteLine("OK");
        database[s] = 1;
    }
    else
    {
        Console.WriteLine($"{s}" + database[s]);       
        database[s] += 1;
    }
}