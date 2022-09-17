using System.Xml;

//Console.WriteLine("Scegli un numero tra 1 - 11 per visualizzare lo snack corrispondente");
//string? prompt = Console.ReadLine();
////Inserimento Controlli sull'input

//int flag = Convert.ToInt32(prompt);

//switch (flag)
//{
//    case 1:
//        Console.WriteLine("Snack - 1");
//        int maximum = 0;
//        for (int i = 0; i < 2; i++)
//        {
//            Console.Write("Inserisci un numero: ");
//            int numb = Convert.ToInt32(Console.ReadLine());

//            if (i == 0)
//            {
//                maximum = numb;
//                continue;
//            }
//            else
//            {
//                if (numb > maximum)
//                {
//                    maximum = numb;
//                }
//            }
//        }

//        Console.WriteLine($"Il numero massimo è {maximum}");
//        break;
//    case 2:
//        Console.WriteLine("Snack - 2");

//        Console.Write("Inserisci una parola: ");
//        string? firstWord = Console.ReadLine();
//        if (firstWord == null)
//        {
//            firstWord = "";
//        }

//        Console.Write("Inserisci la seconda parola: ");
//        string? secondWord = Console.ReadLine();
//        if (secondWord == null)
//        {
//            secondWord = "";
//        }

//        string res = (firstWord.Length >= secondWord.Length) ? firstWord + " " + secondWord : secondWord + " " + firstWord;
//        Console.WriteLine(res);

//        break;
//    case 3:
//        Console.WriteLine("Snack - 3");

//        int sum = 0;
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write("Inserisci un numero: ");
//            int numbs = Convert.ToInt32(Console.ReadLine());
//            sum += numbs;   
//        }

//        Console.WriteLine($"La somma è {sum}");
//        break;
//    case 4:
//        Console.WriteLine("Snack - 4");

//        int sums = 0;
//        int average = 0;

//        for (int i = 2; i <= 10; i++)
//        {
//            sums += i;
//        }

//        average = sums / 8;

//        Console.WriteLine($"Sum: {sums}, average: {average}");

//        break;
//    case 5:
//        Console.WriteLine("Snack - 5");

//        Console.Write("Inserisci un numero: ");
//        int? num = Convert.ToInt32(Console.ReadLine());
//        if (num % 2 == 0)
//        {
//            Console.WriteLine(num);
//        }
//        else
//        {
//            Console.WriteLine(num+1);
//        }
//        break;
//    case 6:
//        Console.WriteLine("Snack - 6");

//        string[] inviteList = new[] { "Gianni", "Alan", "Paolo", "Giorgio" };
//        Console.Write("Inserisci un nome: ");
//        string? name = Console.ReadLine();

//        if (inviteList.Contains(name))
//        {
//            Console.WriteLine("Puoi partecipare");
//        }
//        else
//        {
//            Console.WriteLine("Non puoi partecipare");
//        }
//        break;
//    case 7:
//        Console.WriteLine("Snack - 7");

//        int[] array = new int[6];

//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write("Inserisci un numero: ");
//            int numero = Convert.ToInt32(Console.ReadLine());
//            if (numero % 2 != 0)
//            {
//                array[i] = numero;
//            }
//        }
//        Console.WriteLine("Array risultante:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write(array[i] + " ");
//        }

//        break;
//    case 8:
//        Console.WriteLine("Snack - 8");

//        int[] numArray = new[] { 1, 4, 6, 8, 3, 7, 0, 2, 1, 23 };
//        int somma = 0;

//        for (int i = 0; i < numArray.Length; i++)
//        {
//            if (i % 2 == 0)
//            {
//                somma += numArray[i];
//            }
//        }

//        Console.WriteLine(somma);
//        break;
//    case 9:
//        Console.WriteLine("Snack - 9");

//        int sommaMax = 0;
//        string numbersArray = "";
//        do
//        {
//            Console.Write("Inserisci un numero: ");
//            string? numero = Console.ReadLine();
//            numbersArray += numero + ",";
//            sommaMax += Convert.ToInt32(numero);

//        } while (sommaMax < 50);

//        string[] onlyNumArray = numbersArray.Split(",");

//        int[] arrayNum = new int[onlyNumArray.Length-1];

//        for (int i = 0; i < onlyNumArray.Length-1; i++)
//        {
//            arrayNum[i] = Convert.ToInt32(onlyNumArray[i]);
//        }
//        break;
//}

Console.WriteLine("Snack - 12");

static bool isEven(int num){
    return (num % 2 == 0) ? true : false;
}

Console.Write("\nInserisci un numero: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(isEven(number));

