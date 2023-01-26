using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace guess;
class Program
{
    static void Main(string[] args)
    {
        //   De code neemt een getal in het hoofd tussen 0 en 500
        Random r = new Random();
        Console.WriteLine("Tot hoe hoog wil je het maximale getal?");
        int max = Convert.ToInt32(Console.ReadLine());
        int secret = r.Next(0, max);
        Console.WriteLine("Raad een getal: ");

        // aantal pogingen bijhouden per ronde
        int attempts = 0;
        int[] roundAttempts = new int[50];
        int nrOfRounds = 0;

        //De gebruiker moet het getal raden
        bool again = true;
        int guess = -1;
        do
        {
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;
            if(guess == secret)
            {
                Console.WriteLine("Fantastisch! Geraden!");

                // bewaar ronde data
                roundAttempts[nrOfRounds] = attempts;
                nrOfRounds++;

                // Maak het mogelijk om nog een spel te starten
                Console.WriteLine("Nog een keer? J/N");
                string next = Console.ReadLine();
                again = next.ToLower().Equals("j");
                if(again)
                {
                    Console.WriteLine("Leuk! Nog een rondje.");
                    
                    // reset velden
                    secret = r.Next(0, max);
                    attempts = 0;
                    guess = -1;
                }

            }
            //Op de command wordt getoond of het getal hoger of lager moet zijn
            else if (guess < secret)
            {
                Console.WriteLine("Raad hoger");
            }
            else
            {
                Console.WriteLine("Raad lager");
            }

        }
        //De gebruiker kan blijven raden totdat het juiste antwoord gegeven is
        while (guess != secret && again);

        //Bonus: maak het mogelijk om het gemidideld aantal keer van meerdere rondes uit te rekenen(arrays e.d.nodig)

        int totalAttempts = 0;
        for(int i = 0; i < nrOfRounds; i++)
        {
            totalAttempts = totalAttempts + roundAttempts[i];
        }

        Console.WriteLine("Gemiddeld aantal pogingen: " + (Convert.ToDouble(totalAttempts) / (nrOfRounds)));

       
        //    Dan krijgt de gebruiker nog de volgende feedback:
        //Minder dan 5x: snel gedaan!
        //Tussen de 5 en 10x: netjes
        //Tussen de 10 en 15x: zo zo
        //Meer dan 15x: het duurde wel lang…

        //Bonus:  maak een enum van 4 bovenstaande opties en gebruik een switch statement

    }
}

