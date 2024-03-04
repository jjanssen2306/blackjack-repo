namespace oop_week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool spelgekozen = false;
            Console.WriteLine("Welkom bij blackjack");
            Console.WriteLine("kies wat je wilt doen");
            Console.WriteLine("kies 1 voor spelregels");
            Console.WriteLine("kies 2 voor ...");
            Console.WriteLine("kies 3 voor ...");
            Console.WriteLine("kies 4 voor ...";
            int welkSpel = int.Parse(Console.ReadLine());
            while (spelgekozen == false) { 
            switch (welkSpel)
            {
                case 1:
                     
                    break;
                case 2:
                     
                    break;
                case 3:
                     
                    break;
                case 4:
                     
                    break;
                default:
                     
                    break;
            }
            }   
        }
    }


    public static void spelregels()
    {
        bool regelkeuze = false;
        Console.WriteLine("Welkom bij het stuk spelregels");
        Console.WriteLine("hier krijg je een uitleg over de spelregels van blackjack");
        Console.WriteLine("wil je wil je alles weeten van de spelregels of wil je specefieke regel weten");
        Console.WriteLine("type 1 voor een lijst met alle regels en type 2 voor de lijst van specefieke regels");
        int welkeRegels = int.Parse(Console.ReadLine());
        while (regelkeuze == false)
        {
            switch (welkeRegels)
            {
                case 1:
                    Console.WriteLine("hier komen de spelregels allemaal te staan");
                    regelkeuze = true;
                    break;
                case 2:
                    regelkeuze = true;
                    bool subregelsGekozen = false;
                    while (subregelsGekozen == false)
                    {
                        Console.WriteLine("welke regels wil je hebben");
                        Console.WriteLine("tiep 1 voor sub kopje 1e set regels");
                        Console.WriteLine("tiep 2 voor sub kopje 2e set regels");
                        Console.WriteLine("tiep 3 voor sub kopje 3e set regels");
                        Console.WriteLine("tiep 4 voor sub kopje 4e set regels");
                        Console.WriteLine("tiep 5 voor sub kopje 5e set regels");
                        int Subregels = int.Parse(Console.ReadLine());
                        switch (Subregels)
                        {
                            case 1:
                                Console.WriteLine("regels sub kopje 1");
                                subregelsGekozen = true;
                                break;
                            case 2:
                                Console.WriteLine("regels sub kopje 2");
                                subregelsGekozen = true;
                                break;
                            case 3:
                                Console.WriteLine("regels sub kopje 3");
                                    subregelsGekozen = true; 
                                break;
                            case 4:
                                Console.WriteLine("regels sub kopje 4");
                                subregelsGekozen = true;
                                break;
                            case 5:
                                Console.WriteLine("regels sub kopje 5");
                                subregelsGekozen = true;
                                break;
                            default:
                                Console.WriteLine("niet goed antwoord probeer op nieuw");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("niet goed antwoord probeer op nieuw");
                    break;
            }
        }
        return;
    }

}
