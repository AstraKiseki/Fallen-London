using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Scholar_of_the_Correspondence
{
    class Program
    {    
        static int GetIntegerFromUser(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Good heavens, we need numbers here, not letters.  Please, repeat yourself.");
                }
            }
        }
        static void Main(string[] args)
        {
            int startingLevel = GetIntegerFromUser("What level of Scholar of the Correspondence are you at?");
            int endLevel = GetIntegerFromUser("What level of Scholar of the Correspondence would you like to reach?");

            if (startingLevel >= endLevel)
            {
                Console.WriteLine("Then it pleases me to inform you that you have already reached your goal!  Congratulations and good day.");
            }

            int CorePlaques = 0;
            int ExtraImps = 0;
            int AeolScreams = 0;
            int Watchful = 100 + (endLevel * 10);
            int ChangePoints = 0;

            int currentLevel = startingLevel;

            while (currentLevel != endLevel)
                {
                while (ChangePoints < currentLevel)
                {
                    CorePlaques += currentLevel;
                    ExtraImps += 1;
                    AeolScreams += 1;
                    ChangePoints += 1;
                }
                if (currentLevel == ChangePoints)
                {
                    currentLevel += 1;
                    ChangePoints = 0;
                }
            }
            Console.WriteLine("To go from SotC {0} to {1}, you will need appromixately Watchful {2}, {3} Correspondence plaques, {4} Extraordinary Implications, and {5} Aeolian Screams.  Good luck!", startingLevel, endLevel, Watchful, CorePlaques, ExtraImps, AeolScreams);
            Console.ReadKey();
        }
    }
}
