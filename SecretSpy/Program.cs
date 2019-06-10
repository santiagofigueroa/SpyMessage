using System;

namespace SecretSpy
{

    class Program
    {
        public static int Message { get; set; }
        public static int Spy { get; set; }


        static int Main(string[] args)
        {

            Console.WriteLine("Welcome to the Spy Program");
            int Message = 0;
            int[] array = new int[8];
            Console.WriteLine("Please Enter Message !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine();

            while (Message < 9)
            {
                if (int.TryParse(Console.ReadLine(), out array[Message]))
                {
                    Message++;
                }
                else
                {
                    Console.WriteLine("You didn't enter a number! Please enter again!");
                }
                    
            }

            //Message = Console.Read();
            //if (array.Length > 0 )
            //{
            //    object obj = new object();

            //    Console.WriteLine("Please enter a message");  
            //} 
            //if (!Validate) { }
            //for (int i = 0; i < Message; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine(array[i]);
            //}
            int spyIndex = 0;
            int[] spy = new int[3];
            Console.WriteLine("Please Enter Spy Number");

            while (spyIndex < 4)
            {
                if (int.TryParse(Console.ReadLine(), out spy[spyIndex]))
                    spyIndex++;
                else
                    Console.WriteLine("You didn't enter a number! Please enter again!");
            }
            Console.Read();

            return 0;
        }
    }
}
