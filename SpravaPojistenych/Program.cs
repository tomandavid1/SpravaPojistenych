using SpravaPojistenych;

bool loopApp = true;
Sprava sprava = new Sprava();

while (loopApp)
{
    Console.Clear();
    Console.WriteLine("----------------------------\nEvidence pojištěných\n----------------------------");
    Console.WriteLine("\nVyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");
    char vstup = Console.ReadKey().KeyChar;

    switch (vstup)
    {
        case '1':
            Console.Write("\nZadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();
            Console.Write("Zadejte věk: ");
            int vek = int.Parse(Console.ReadLine());
            Console.Write("Zadejte telefonní číslo: ");
            int telefon = int.Parse(Console.ReadLine());
            sprava.PridatPojisteneho(jmeno, prijmeni, vek, telefon);
            Console.WriteLine();
            break;
        case '2':
            Console.WriteLine();
            sprava.VypisPojistenych();
            Console.WriteLine();
            break;
        case '3':
            Console.Write("\nZadejte jméno pojištěného: ");
            jmeno = Console.ReadLine();
            Console.Write("Zadejte příjmení: ");
            prijmeni = Console.ReadLine();
            Console.WriteLine("\n" + sprava.VyhledatPojisteneho(jmeno, prijmeni) + "\n");
            break;
        case '4':
            Console.WriteLine("\n\nDěkuji za použití programu!\n");
            loopApp = false;
            break;
        default:
            Console.WriteLine("Neplatný výběr!");
            break;
    }
    Console.WriteLine("Pokračujte stiskem libovolné klávesy...\n");
    Console.ReadKey();
}

