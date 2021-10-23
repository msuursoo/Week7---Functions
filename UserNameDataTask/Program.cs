using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //prgoramm küsib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab 1 , siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasustaja valib 2 , siis kuvatakse kasutaja eesnime esimest tähe
            //kui kasustaja valib 3 , siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnime");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta nember 1-3");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator) { 
                case '1':
                    userNameReverse(userName);
                    break;
                case '2':
                    userNameFirstLetter(userName);
                    break;
                case '3':
                    userNameLength(userName);
                    break;
                default:
                    Console.WriteLine("Vale number");
                    break;

            }
        }

        public static void userNameReverse(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void userNameFirstLetter(string userInput)
        {
            Console.WriteLine($"sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void userNameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }




    }
}
