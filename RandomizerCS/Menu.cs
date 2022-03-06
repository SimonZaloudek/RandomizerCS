using System;

namespace RandomizerCS
{
    class Menu
    {
        public Menu()
        {
            Generation generation = new Generation();
            while (true)
            {
                Console.WriteLine("|String| randomizer, |Int| randomizer, |Char| randomizer, |YesNo| or |Test| randomizer? ..|end| to stop the program");
                String input = Console.ReadLine();
                while (!input.Equals("string") && !input.Equals("String")
                    && !input.Equals("int") && !input.Equals("Int")
                    && !input.Equals("char") && !input.Equals("Char")
                    && !input.Equals("test") && !input.Equals("Test")
                    && !input.Equals("YesNo") && !input.Equals("yesno")
                    && !input.Equals("end"))
                {
                    Console.WriteLine("Wrong input.. |String|Int|Char|Test|YesNo| ..|end| to stop the program");
                    input = Console.ReadLine();
                }
                switch (input)
                {
                    case "String":
                    case "string":
                        generation.StringGeneration();
                        break;
                    case "Int":
                    case "int":
                        generation.IntGeneration();
                        break;
                    case "Char":
                    case "char":
                        generation.CharGeneration();
                        break;
                    case "Test":
                    case "test":
                        generation.TestGeneration();
                        break;
                    case "YesNo":
                    case "yesno":
                        generation.BoolGeneration();
                        break;
                    default:
                        goto end;
                        break;
                }
            }
        end:;
        }
    }
}
