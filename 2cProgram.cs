#c. Which of the following words is the longest:
Supercalifragilisticexpialidocious, Honorificabilitudinitatibus, or
Bababadalgharaghtakamminarronnkonn?
    
using System;

public class longestword
{
    public static void Main()
    {
        string[] words = { "Supercalifragilisticexpialidocious", "Honorificabilitudinitatibus", "Bababadalgharaghtakamminarronnkonn" };

        int longestLength = words.Max(w => w.Length);

        Console.WriteLine("The longest word is {0} characters long.", longestLength);
    }
}
