using System;
using System.Collections;

namespace RandomizerCS
{
    internal class Generation
    {
        ArrayList list;
        Random rndm;
        public void inic()
        {
            list = new ArrayList();
            rndm = new Random();
        }
        
        public Generation()
        {
            this.inic();
            while (true) {
                Console.WriteLine("|String| randomizer ..|end| to stop the program");
                String input = Console.ReadLine();
                while (!input.Equals("string") && !input.Equals("String") && !input.Equals("end"))
                {
                    Console.WriteLine("Wrong input.. |String| ..|end| to stop the program");
                    input = Console.ReadLine();
                }
                switch (input)
                {
                    case "String":
                    case "string":
                        this.StringGeneration();
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
            String input = "";
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
                Console.WriteLine("Do you want to repeat the generation? |y|n|");
                input = Console.ReadLine();
                while(!input.Equals("y") && !input.Equals("n"))
                {
                    Console.WriteLine("Wrong input.. |y|n|");
                    input = Console.ReadLine();
                }

            } while (!input.Equals("n"));
        }
    }
}
