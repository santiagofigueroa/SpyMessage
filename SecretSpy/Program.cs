using System;
using System.Linq;

namespace SecretSpy
{

    public class Program
    {
        public static int Message { get; set; }
        public static int Spy { get; set; }
        public static int[] messageArray  = Enumerable.Range(1,9).ToArray();

        public static Stack stack;

         public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Spy Program");
            //IndexCheck's that 
            int Message = 0;
            messageArray = new int[8];
            Console.WriteLine("Please Enter Message !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Enter each digit and pres enter.");
            Console.WriteLine();
           

            // Checks the length only.
            while (Message < 9)
            {
                if (int.TryParse(Console.ReadLine(), out messageArray[Message]))
                {
                    int compare = messageArray[Message];
                    if(compare > -1 && compare < 10)
                    {
                        Message++;
                    }
                    else
                    {
                        Console.WriteLine("Please only enter number between 0 and 9 ONLY !");
                    }
                }
                else
                {
                    Console.WriteLine("You didn't enter a number! Please enter again!");
                }

            }

            #region Spy

            int spyIndex = 0;
            int[] spy = new int[3];
            Console.WriteLine("Please Enter Spy Secret Number");

            while (spyIndex < 4)
            {
                if (int.TryParse(Console.ReadLine(), out spy[spyIndex]))
                {
                    if (spyIndex >= 0 && 10 < spyIndex)
                    {
                        spyIndex++;
                    }
                    else
                    {
                        Console.WriteLine("Please only enter number between 0 and 9 ONLY !");
                    }


                }
                else
                {
                    Console.WriteLine("You didn't enter a number! Please enter again!");
                }
            }
            Console.Read();
            #endregion Spy 


            #region Array to Stack plus comparison. 
            // Starts a new Stack object and set size to the size of the 'Message array' array.
            stack = new Stack(messageArray.Length);
            

            foreach (int i in messageArray)  
            {
                int option = spy[i];
                for (int s =0; s > spy.Length; s++)
                {
                    if(spy[s] == messageArray[i])
                    {
                        stack.push(messageArray[i]);
                    } 

                } 
                
                //switch (option)
                //{
                //    case spy[0]:
                //        stack.push(messageArray[i]);
                //        break;
                //}

            }

                #endregion Array to Stack plus comparison. 

            }
        }
    }
