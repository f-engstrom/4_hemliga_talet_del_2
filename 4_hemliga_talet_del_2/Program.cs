using System;

namespace _hemliga_talet_del_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool inMatatSiffror = false;
            int inMatatTal = 0;
            Random rndNr = new Random(); // Startar slumpgeneratorn för nummer. 
            int randomNummer = rndNr.Next(1, 101); //Skapar ett nummer från och med 1, då minvärdet är inkluderande, upp till 100 och 101 då maxvärdet är uteslutande. 

            Console.WriteLine("Gissa ett nummer mellan 1 och 100.");

            do //Loop som testar så att siffror matas in för det gissade numret och ber om tal om annat matas in.
            {
                string strAntalDecimaler = Console.ReadLine();
                try
                {
                    inMatatTal = Convert.ToInt32(strAntalDecimaler);
                    inMatatSiffror = true;
                }
                catch
                {
                    Console.WriteLine("Enbart siffror tack.\n" + "Skriv ett tal:");

                }
            } while (inMatatSiffror == false);



            if (inMatatTal < randomNummer) //Är det gissade talet för lågt skrivs det ut ett meddelande för detta, samt readkey för att pausa så användaren hinner läsa.
            {

                Console.WriteLine("Tyvärr, du gissade för lågt.");
                Console.ReadKey();

            }

            else if (inMatatTal > randomNummer) //Är det gissade talet för högt skrivs det ut ett meddelande för detta, samt readkey för att pausa så användaren hinner läsa.
            {
                Console.WriteLine("Tyvärr, du gissade för högt.");
                Console.ReadKey();

            }

            else if (inMatatTal == randomNummer) //Är det gissade talet rätt skrivs det ut ett meddelande för detta, samt readkey för att pausa så användaren hinner läsa.
            {

                Console.WriteLine("Grattis! Du gissade rätt.");
                Console.ReadKey();
            }
        }
    }
}
