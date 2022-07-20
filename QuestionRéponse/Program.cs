using System;

namespace QuestionRéponse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comment vous appelez-vous ?");

            String réponse = Console.ReadLine();

            Console.WriteLine("Enchanté, " + réponse);

            Console.WriteLine(réponse + ", Quelle est ton année de naissance ?");
            String years = Console.ReadLine();
            int yearsNum = int.Parse(years);
            int âge = DateTime.Now.Year - yearsNum;
            const string A = ", tu as ";
            Console.WriteLine(réponse + A + âge.ToString());

            if (âge < 24)
            {
                Console.WriteLine("Oh ! On a le même âge ! " + réponse);
            }
            else
            {
                Console.WriteLine("Hummm tu as connu la coupe du monde de 1998, pas moi");
            }


            Console.ReadKey();

        }
    }
}

