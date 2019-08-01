using System;
using System.Collections.Generic;
using System.Text;

namespace PCE_StarterProject
{
    /// <summary>
    /// The key is that this class actually inherits from the class containing the method we want to test
    /// This class then overrides that method
    /// The test then instantiates an instance of THIS class
    /// When the recursion happens, this class's overridden method is called first, which can
    ///     verify that everything is going the way it should, before this class calls base.method()
    ///     in order to actually do the 'real' work that the student has implemented
    /// </summary>
    class RM_Verifier : RecursiveMethods
    {
        private Recursion_Verifier verifier = new Recursion_Verifier();

        // So that the test framework can call Verifier.ResetCurrentCall on it
        public Recursion_Verifier Verifier
        {
            get
            {
                return verifier;
            }
        }

        override public void PrintEvenNumbers_Recursively(int N)
        {
            if( Verifier.isDebuggingOutputOn())
                Console.WriteLine("====================== Method intercepted! (Param = {0}) ========", N);

            Verifier.CheckCurrentCall( new Object[] { N  });
            Verifier.IncrementCurrentCall();

            if (Verifier.isDebuggingOutputOn()) 
                Console.WriteLine("====================== Proceeding on to actual method invocation ========");

            base.PrintEvenNumbers_Recursively(N);
        }
    }
}
