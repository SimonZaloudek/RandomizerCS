using System;
using System.Collections;

namespace RandomizerCS
{
    internal class Generation
    {
        ArrayList list;
        Random rndm;
        String input;
        public void inic()
        {
            list = new ArrayList();
            rndm = new Random();
        }
        
        public Generation()
        {
            this.inic();
            while (true) {
                Console.WriteLine("|String| randomizer, |Int| randomizer, |Char| randomizer or |Test| randomizer? ..|end| to stop the program");
                String input = Console.ReadLine();
                while (!input.Equals("string") && !input.Equals("String") && !input.Equals("int") && !input.Equals("Int") && !input.Equals("char") && !input.Equals("Char") && !input.Equals("end"))
                {
                    Console.WriteLine("Wrong input.. |String|Int|Char|Test| ..|end| to stop the program");
                    input = Console.ReadLine();
                }
                switch (input)
                {
                    case "String":
                    case "string":
                        this.StringGeneration();
                        break;
                    case "Int":
                    case "int":
                        this.IntGeneration();
                        break;
                    case "Char":
                    case "char":
                        this.CharGeneration();
                        break;
                    default:
                        goto end;
                        break;
                }
            }
            end:;
        }

        private void StringGeneration()
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

        private void IntGeneration() 
        {
            int bottomN;
            int topN;
            Console.WriteLine("Enter the smallest number..");
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
            Console.WriteLine("________________________________________\n");
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

        private void rollDetection()
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
