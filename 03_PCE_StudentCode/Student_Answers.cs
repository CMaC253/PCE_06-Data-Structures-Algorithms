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
            Recursively_Printing_Even_Numbers rm = new Recursively_Printing_Even_Numbers();
            rm.RunExercise();
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
             RecursiveMethods rm = new RecursiveMethods();
            rm.PrintEvenNumbers_Recursively(5);
            
        }
    }

    public class RecursiveMethods
    {
        public void Print_Numbers_Recursively(int num)
        {
            if (num == 10+1)
                return;

                Console.WriteLine(num);
             
            
                Print_Numbers_Recursively(num+1);
        }

        public void PrintEvenNumbers_Iteratively(int N)
        {
            for(int i=N; i>0; i--)
            {
                if(i%2==0)
                    Console.WriteLine(i);
                else
                    Console.Write(" ");
            }


        }

        virtual public void PrintEvenNumbers_Recursively(int N)
        {
            if (N < 0)
                return;
            else if (N>=0)
            {
                if (N % 2 == 0)
                {
                    Console.WriteLine($"Argument: {N}");
                    PrintEvenNumbers_Recursively(N - 2);
                }
                if (N % 2 != 0)
                   PrintEvenNumbers_Recursively(N-1);
              
            }
         }

        public int PowR(int b, int exp)
        {
            if (exp < 0)
                throw new Exception("Illegal move");
            else if (exp == 0)
                return 1;
            else
                return b * PowR(b, exp - 1);
        }


        public int MultR(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;
            else if (b < 0)
                return -a + MultR(a, b + 1);
            else
                return a + MultR(a, b - 1);
        }
        private int __MultR(int a, int b)
        {
            return Int32.MinValue;
        }

        public int Factorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            if (n < 0)
                return 0;

            else
                return n * Factorial(n - 1);
        }

        public void Fibonacci_Array(int[] array)
        {
            if (array == null)
                return;

            //array[0] = 0;
            //array[1] = 1;
            //array[n] =  



        }
    }

    public class MyLinkedList
    {
        protected class LinkedListNode
        {
            public int m_data;
            public LinkedListNode m_next;
            public LinkedListNode()
            { }
            public LinkedListNode(int data)
            { data = m_data; }
        }

        // first item in the list, automtically given the value null
        protected LinkedListNode m_first;

        // from previous ICEs:
        public void InsertAtFront(int value)
        {
            if (m_first == null)
            {
                LinkedListNode newNode = new LinkedListNode();
                newNode.m_data = value;
                m_first = newNode;
                return;
            }
            LinkedListNode dupNode = new LinkedListNode();
            dupNode.m_data = value;
            dupNode.m_next = m_first;
            m_first = dupNode;
        }

        public void Print()
        {
            LinkedListNode cur = m_first;
            while (null != cur)
            {
                Console.WriteLine(cur.m_data);
                cur = cur.m_next;
            }
            //RecursivelyPrintForward(m_first);
        }

        public void RecursivelyPrintForward()
        {
           
            if (m_first == null) return;

           
            RecursivelyPrintFwd(m_first);
             
        }
        private void RecursivelyPrintFwd(LinkedListNode n)
        {
            if (n != null)
            {
                Console.WriteLine(n.m_data);
                RecursivelyPrintFwd(n.m_next);
            }

        }

        public  void RecursivelyPrintBackward()
        {
            if (m_first == null)
                return;

            RecursivelyPrintBackward(m_first);
        }
        private  void RecursivelyPrintBackward(LinkedListNode node)
        {
            if (node != null)
            {
                RecursivelyPrintBackward(node.m_next);
                Console.WriteLine(node.m_data);
            }


        }

        public void RecursivelyPrint(bool fwd)
        {
            if (m_first == null)
                return;
            if (fwd == true)
                RecursivelyPrintForward();
            if (fwd == false)
                RecursivelyPrintBackward();

        }
    }

}