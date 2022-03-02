using System;
using System.Collections;

namespace RandomizerCS
{
    class Generation
    {
        ArrayList list;
        Random rndm;
        String input;
       
        public Generation()
        {
            list = new ArrayList();
            rndm = new Random();
        }

        public void StringGeneration()
        {
            do
            {
                Console.WriteLine("\nEnter what u cant decide about.. then type |decide|");
                input = Console.ReadLine();
                while (!input.Equals("decide"))
                {
                    list.Add(input);
                    input = Console.ReadLine();
                }
                int cislo = rndm.Next(list.Count);
                Console.WriteLine("\nGo on:");
                Console.WriteLine(list[cislo] + "\n");
                this.rollDetection();
            } while (!input.Equals("n"));
        }

        public void IntGeneration() 
        {
            int bottomN;
            int topN;
            Console.WriteLine("\nEnter the smallest number..");
            bottomN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the biggest number..");
            topN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("____________________\n");

            do {
                int vysledok = rndm.Next(topN - bottomN + 1) + bottomN;
                Console.WriteLine("Random number is " + vysledok);
                this.rollDetection();
            } while (!input.Equals("n"));
        }

        public void CharGeneration()
        {
            String alphabet = "ABCDEFGH1IJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("Printing random letter between |A| - |Z|");
            Console.WriteLine("________________________________________");
            do
            {
                char pismeno = (alphabet[rndm.Next(26)]);
                if (pismeno == '1')
                {
                    Console.WriteLine("CH\n");
                }
                else
                {
                    Console.WriteLine("\n" + pismeno + "\n");
                }
                this.rollDetection();
            } while (!input.Equals("n"));
        }

        public void TestGeneration()
        {
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("\nEnter the number of test options |2|-|99|");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number < 2 && number > 99)
            {
                Console.WriteLine("Wrong input |2|-|99|");
                number = Convert.ToInt32(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("\n" + alphabet[rndm.Next(number)] + "\n");
                this.rollDetection();
            } while (!input.Equals("n"));
        }

        public void rollDetection()
        {
            Console.WriteLine("Do you want to repeat the generation? |y|n|");
            input = Console.ReadLine();
            while (!input.Equals("y") && !input.Equals("n"))
            {
                Console.WriteLine("Wrong input.. |y|n|");
                input = Console.ReadLine();
            }
            if (input.Equals("n"))
            {
                Console.WriteLine("\nEnjoy");
                Console.WriteLine("____________________\n");
            }
        }
    }
}
