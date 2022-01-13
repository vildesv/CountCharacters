using System;

namespace CountCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            int totalLetters = 0;
            string text = "something";

            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine() ?? string.Empty;
                foreach (var character in text.ToUpper())
                {
                    totalLetters++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var percentage = 100 * (double)counts[i] / totalLetters;
                        string output = character + " - " + percentage.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}


/* OPPGAVE

1. Start Visual Studio og lag et nytt prosjekt "Console App" under "Windows Classic Desktop".

2. Legg inn koden under og finn ut hva den gjør. Hvis du står fast, kan du se begynnelsen på neste undervisningsvideo.

var range = 250;
var counts = new int[range];
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    foreach (var character in text ?? string.Empty)
    {
        counts[(int)character]++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            Console.WriteLine(character + " - " + counts[i]);
        }
    }
}

3. Endre det så det håndterer store og små bokstaver likt (bruk google/stackoverflow.com)

4. Tell i prosent

5. Skriv ut tall høyrejustert, se eksempel:
                                          1
                                          20
                                          300

 */