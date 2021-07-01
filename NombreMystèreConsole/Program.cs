using System;

namespace NombreMystèreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int aléatoire = new Random().Next(21);

            NouvellePartie(aléatoire);

            Gagné(aléatoire);

            Console.ReadKey();
        }

        static void NouvellePartie(int aléatoire)
        {
            Console.WriteLine("Choisit un chiffre entre 0 et 20 :");

            int chiffreNum = ChoisiUnChiffre();

            while (chiffreNum != aléatoire)
            {
                if (chiffreNum > aléatoire)
                {
                    Console.WriteLine("C'est moins !");
                }
                else
                {
                    Console.WriteLine("C'est plus !");
                }

                chiffreNum = ChoisiUnChiffre();
            }
        }
        static void Gagné(int aléatoire)
        {
            Console.WriteLine("Félicitation le nombre est bien " + aléatoire);
        }

        static int ChoisiUnChiffre()
        {
            string chiffre = Console.ReadLine();
            int chiffreNum;

            while (int.TryParse(chiffre, out chiffreNum) == false)
            {
                Console.WriteLine("Je t'ai demandé un chiffre pas autre chose :");
                chiffre = Console.ReadLine();
            }

            return chiffreNum;
        }
    }
}
