using System;

namespace SecretSpy
{

    class Program
    {
        /// <summary>
        /// [1,2,4,0,0,7,5] [0,0,7] James Bond true 
        /// [0,2,2,0,4,7,0] [0,0,7] James Bond true
        /// [1,2,0,7,4,4,0] [0,0,7] James Bond false
        /// [3,6,0,1,2,6,4] [3,1,4] Ethan Hunt true
        /// [3,3,1,5,1,4,4] [3,1,4] Ethan Hunt true
        /// [4,1,3,8,4,3,1] [3,1,4] Ethan Hunt false
        /// </summary>
        public static int Message { get; set; }
        public static int Spy { get; set; }
        public static int[] array;
        public static int[] spy;
        public static Stack stack;
        public static bool hiding;
        #region Test Array 
        public static int[] array1 = { 1, 2, 4, 0, 0, 7, 5 };
        public static int[] spy1 = { 0, 0, 7 };

        public static int[] array2 = { 0, 2, 2, 0, 4, 7, 0 };
        public static int[] spy2 = { 0, 0, 7 };

        public static int[] array3 = { 1, 2, 0, 7, 4, 4, 0 };
        public static int[] spy3 = { 0, 0, 7 };

        public static int[] array4 = { 3, 6, 0, 1, 2, 6, 4 };
        public static int[] spy4 = { 3, 1, 4 };

        public static int[] array5 = { 3, 3, 1, 5, 1, 4, 4 };
        public static int[] spy5 = { 3, 1, 4 };

        public static int[] array6;
        public static int[] spy6 = { 3, 1, 4 };

        #endregion Test Arrays

        static int Main(string[] args)
        {

            Console.WriteLine("Welcome to the Spy Program");
            //  int Message = 0;
            array = new int[7];
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Please Enter Message !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine();
            buildArray(array);
            displayElements(array, "Message");

            spy = new int[3];
            Console.WriteLine();
            Console.WriteLine("Please Enter Spy Number");
            Console.WriteLine();
            buildArray(spy);
            displayElements(spy, "Spy");
            Console.WriteLine();
            hiding = compare();

            Console.WriteLine("Hiding (True or False):" + hiding.ToString());
            //Console.Read();
            Console.WriteLine();
            return 0;
        }

        public static bool compare()
        {
            int spyLenght = spy.Length;
            int add = 0;
            int top = 0;
            int[] temp = stack.getStackArray();

            foreach (int element in array)
            {
                //Check's that alll of  
                if (add < 4)
                {
                    if (temp[add] == element)
                    {
                        add++;
                        Console.WriteLine("Add: " + add);
                        //Returns the old_top of the Stack 
                        stack.pop();
                        stack.ToString();
                    }
                }

            }

            if (add == 3 && top == 0)
            {
                // If found spy then returns true;
                return true;
            }

            return false;
        }

        /// <summary>
        /// BuildArray Methods builds all arraya and sets there value to field.
        /// </summary>
        /// <param name="arr"></param>
        public static void buildArray(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    // Continue if there is an error
                }
            }
        }
        /// <summary>
        /// 
        /// Diplyas elments in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="type"></param>
        public static void displayElements(int[] arr, string type)
        {
            Console.Write("Elements in the array " + type + " are: ");
            foreach (int elements in arr)
            {
                Console.Write(elements + " ");
            }

            if (type == "Spy")
            {
                stack = new Stack(arr.Length);
                stack.push(arr[0]);
                stack.push(arr[1]);
                stack.push(arr[2]);
            }
        }
    }
}