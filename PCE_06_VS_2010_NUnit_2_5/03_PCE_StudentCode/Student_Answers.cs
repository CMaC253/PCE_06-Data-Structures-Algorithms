#define TESTING
using System;

/*
 * STUDENTS: Your answers (your code) goes into this file!!!!
 * 
  * NOTE: In addition to your answers, this file also contains a 'main' method, 
 *      in case you want to run a normal console application.
 * 
 * If you want to / have to put something into 'Main' for these PCEs, then put that 
 * into the Program.Main method that is located below, 
 * then select this project as startup object 
 * (Right-click on the project, then select 'Set As Startup Object'), then run it 
 * just like any other normal, console app: use the menu item Debug->Start Debugging, or 
 * Debug->Start Without Debugging
 * 
 */

namespace PCE_StarterProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
        }
    }

    class What_Does_This_Code_Print
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }

    class Warmup
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }

    class Warmup_Number2
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }

    class Warmup_Number3
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }

    class Warmup_MoreComplicated
    {
        // There is no code to write for this exercise
        // Put your answer, in comments, here:
        //
        //
        //
    }


    /////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////

    class Recursively_Printing_Even_Numbers
    {
        public void RunExercise()
        {
            // RecursiveMethods rm = new RecursiveMethods();
            // rm.PrintEvenNumbers_Recursively(3);
        }
    }

    public class RecursiveMethods
    {
        public void Print_Numbers_Recursively()
        {
            Console.WriteLine("YOU MUST IMPLEMENT THIS METHOD!!");
        }

        public void PrintEvenNumbers_Iteratively(int N)
        {
            Console.WriteLine("YOU MUST IMPLEMENT THIS METHOD!!");
        }

        virtual public void PrintEvenNumbers_Recursively(int N)
        {
            Console.WriteLine("YOU MUST IMPLEMENT THIS METHOD!!");
        }

        public int PowR(int b, int exp)
        {
            return -1;
        }


        public int MultR(int a, int b)
        {
            return Int32.MinValue;
        }
        private int __MultR(int a, int b)
        {
            return Int32.MinValue;
        }

        public int Factorial(int n)
        {
            return -1;
        }

        public void Fibonacci_Array(int[] array)
        {
            throw new Exception("YOU NEED TO REMOVE THIS LINE OF CODE, AND IMPLEMENT THIS METHOD");
        }
    }

    public class MyLinkedList
    {
        protected class LinkedListNode
        {
            public int m_data;
            public LinkedListNode m_next;
        }

        // first item in the list, automtically given the value null
        protected LinkedListNode m_first;

        // from previous ICEs:
        public void InsertAtFront(int value)
        {
            // YOUR CODE GOES HERE!!
            // You are allowed to copy-and-paste your prior work into here
            // HOWEVER
            // it's great practice to re-code this; you should be able to code
            // this up in ~5 minutes or so, including testing.  So re-typing
            // this is actually a good thing to do.
            // return;
        }

        public void Print()
        {
            RecursivelyPrintForward();
        }

        public void RecursivelyPrintForward()
        {
            Console.WriteLine("YOU NEED TO IMPLEMENT THIS!");
            return;
        }

        public void RecursivelyPrintBackward()
        {
            Console.WriteLine("YOU NEED TO IMPLEMENT THIS!");
            return;
        }

        public void RecursivelyPrint(bool fwd)
        {
            Console.WriteLine("YOU NEED TO IMPLEMENT THIS!");
            return;
        }
    }

}