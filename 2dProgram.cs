class Program
{
    static void Main()
    {
        string[] a = new string[]
        {
            "Berlioz",
            "Borodin",
            "Brian",
            "Bartok",
            "Bellini",
            "Buxtehude",
            "Bernstein",
        };
        Array.Sort(a);
        foreach (string s in a)
        {
            Console.WriteLine(s);
        }
    }
}

