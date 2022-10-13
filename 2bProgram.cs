#b. Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring? 
    
using System;
class substring
{
    static void Main(string[] args)
    {
        String str = "Supercalifragilisticexpialidocious";
        String value = "ice";
        Boolean result = str.Contains(value);
        Console.WriteLine($"Does string contain specified substring? {result}");
    }
}
