using System;
using System.Collections.Generic;
using System.Text;

namespace SecretSpy
{
    /// <summary>
    /// Stack Class
    /// This class will be use to find the sequence of [0,0,7] and [3,1,4]
    /// </summary>
   public class Stack
    {
        private int maxSize;
        private int[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new int[maxSize];
            top = - 1; 
        }   
        
        public void push(int pushIntElement)
        {
            if (isFull())
            {

            }
            else
            {
                top++;
                stackArray[top] = pushIntElement;
            }
        }

        private int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Is Empty");
                return -1; 
            }else {
                // do copy of old_top make the top Minus.  
                int old_top = top;
                top--;
                return stackArray[old_top];

            }
        }

        private bool isEmpty()
        {
            return (top == -1); 
        }

        private bool isFull()
        {
            // -1 becoause that's how we started in the constructor.
            return (maxSize - 1 == top); 
        }
        // Get the completed stack Array if all  the Message Array inv
        public int[] getStackArray() {

            return stackArray; 
        } 
    }
}
