using System.Xml;

Console.WriteLine("Scegli un numero tra 1 - 11 per visualizzare lo snack corrispondente");
string? prompt = Console.ReadLine();
//Inserimento Controlli sull'input

int flag = Convert.ToInt32(prompt);

switch (flag)
{
    case 1:
        Console.WriteLine("Snack - 1");
        int maximum = 0;
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Inserisci un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (i == 0)
            {
                maximum = num;
                continue;
            }
            else
            {
                if (num > maximum)
                {
                    maximum = num;
                }
            }
        }

        Console.WriteLine($"Il numero massimo è {maximum}");
        break;
    case 2:
        Console.WriteLine("Snack - 2");

        Console.Write("Inserisci una parola: ");
        string? firstWord = Console.ReadLine();
        if (firstWord == null)
        {
            firstWord = "";
        }

        Console.Write("Inserisci la seconda parola: ");
        string? secondWord = Console.ReadLine();
        if (secondWord == null)
        {
            secondWord = "";
        }

        string res = (firstWord.Length >= secondWord.Length) ? firstWord + " " + secondWord : secondWord + " " + firstWord;
        Console.WriteLine(res);

        break;
    case 3:
        break;
}
