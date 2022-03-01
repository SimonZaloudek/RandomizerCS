using System;

namespace RandomizerCS
{
    class Login
    {
        public Login()
        {
            Console.WriteLine("Enter your name..");
            String name = Console.ReadLine();

            Console.WriteLine("\nEnter password..");
            String input = Console.ReadLine();
            int counter = 0;
            while (!input.Equals("haha"))
            {
                counter++;
                Console.WriteLine("\nWrong password!!");
                if (counter > 2)
                {
                    Console.WriteLine("Hint: Sound you make when you laugh..\n");
                }
                input = Console.ReadLine();
                
            }
            Console.WriteLine("\nWelcome " + name + "!!");
            Console.WriteLine("____________________\n");
        }
    }
}
