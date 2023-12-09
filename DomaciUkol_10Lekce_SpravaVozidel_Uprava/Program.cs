using DomaciUkol_10Lekce_SpravaVozidel_Uprava;

SpravceVozidel spravceVozidel = new SpravceVozidel();

bool jeKonec = false;

Console.WriteLine("Vítejte,");

while (!jeKonec)
{
    Console.WriteLine("\nJakou akci chcete provést \n1 - Výpis položek \n2 - Přidat nové auto \n3 - Přidat nový motocykl \n0 - Konec");
    string answAct = Console.ReadLine();
    bool tryAgainAct = true;

    while (tryAgainAct)
    {
        try
        {
            switch (Int32.Parse(answAct))
            {
                case (int)Action.konec:
                    jeKonec = true;
                    break;

                case (int)Action.vypis:

                    spravceVozidel.VypisVozidel();
                    break;

                case (int)Action.pridatAuto:

                    spravceVozidel.NoveAuto();
                    break;

                case (int)Action.pridatMotocykl:

                    spravceVozidel.NovyMotocykl();
                    break;

                default:
                    Console.WriteLine("Zřejmě jste jako odpověď nezadali správné číslo, zkuste to znovu:");
                    answAct = Console.ReadLine();
                    break;
            }
            tryAgainAct = false;
        }
        catch (FormatException e)
        {
            Console.WriteLine("Zřejmě jste jako odpověď nezadali správné číslo, zkuste to znovu:");
            answAct = Console.ReadLine();
        }
    }
}


enum Action
{
    konec = 0,
    vypis = 1,
    pridatAuto = 2,
    pridatMotocykl = 3
}