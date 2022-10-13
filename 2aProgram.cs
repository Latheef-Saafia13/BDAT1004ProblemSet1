#2)write (and evaluate) C# expressions that answer these questions:
#a. How many letters are there in 'Supercalifragilisticexpialidocious'?

using System;

public class Countthestring
{
    public static void Main()
    {
        String string1 = "Supercalifragilisticexpialidocious";
        int count = 0;

        for (int i = 0; i < string1.Length; i++)
        {
            if (string1[i] != ' ')
                count++;
        }

        Console.WriteLine("Total number of characters in a string: " + count);
    }
}
