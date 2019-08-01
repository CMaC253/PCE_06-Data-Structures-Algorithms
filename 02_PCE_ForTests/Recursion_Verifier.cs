using System;
using System.Collections.Generic;
using System.Text;

namespace PCE_StarterProject
{
    /// <summary>
    /// Class exists to provide useful functionality to other subclasses.
    /// The other subclass(es) then implement an overridden version of the method 
    /// to be verified.
    /// </summary>
    class Recursion_Verifier
    {
        ///////////////////////////////////////////////////////////////////////
        //                       Method Call Transcript                      //
        ///////////////////////////////////////////////////////////////////////

        // The call transcript is an array of Objects
        // Each row in the array is one function call
        //      Each column (in each row) is the correct value of one parameter
        Object[,] callTranscript;
        public void SetCallTranscript(Object[,] calls)
        {
            callTranscript = calls;
        }
        public void PrintCallTranscript()
        {
            Console.WriteLine("CALL TRANSCRIPT: =========");
            for (int i = 0; i < callTranscript.GetLength(0); i++)
            {
                Console.WriteLine("For method call {0}:\tParam #\tValue", i);
                
                for (int j = 0; j < callTranscript.GetLength(1); j++)
                    Console.WriteLine("\t\t\t{0}\t\t{1}", j ,callTranscript[i,j]);
            }
            Console.WriteLine("==========================\n");
        }

        ///////////////////////////////////////////////////////////////////////
        //                       Tracking The Current Call                   //
        ///////////////////////////////////////////////////////////////////////
        private int currentCall;
        public void ResetCurrentCall()
        {
            currentCall = 0;
        }
        public void IncrementCurrentCall()
        {
            currentCall++;
        }
        /// <summary>
        /// This allows one to check that all the calls were made.  The test should pass if the number
        /// of method calls made is exactly equal to the number of rows in the callTranscript, AND
        /// the values in the transcript match the values of what was actually invoked.
        /// </summary>
        /// <returns>True, if all the calls that were expected were made, false otherwise</returns>
        public bool ConfirmAllCallsMade()
        {
            return callTranscript.Length == currentCall;
        }

        ///////////////////////////////////////////////////////////////////////
        //                       Debugging Output Control                    //
        ///////////////////////////////////////////////////////////////////////
        private bool printDebuggingInfo; // if set to true, print out debugging info
        public void TurnOffDebuggingOutput()
        {
            printDebuggingInfo = false;
        }
        public void TurnOnDebuggingOutput()
        {
            printDebuggingInfo = true;
        }
        public bool isDebuggingOutputOn()
        {
            return printDebuggingInfo;
        }

        ///////////////////////////////////////////////////////////////////////
        //              Verify that the current call is correct              //
        ///////////////////////////////////////////////////////////////////////

        public void CheckCurrentCall(Object []actualArgs)
        {
            String sMsg = "";
            if (printDebuggingInfo)
            {
                Console.WriteLine("Checking call {0}, which was invoked with parameters:", currentCall);
                for (int i = 0; i < actualArgs.Length; i++)
                    Console.WriteLine("\tParam #{0}\t\t{1}", i, actualArgs[i]);
            }

            if (currentCall >= callTranscript.GetLength(0) )
            {
                sMsg = "ERROR: Unexpected extra method call";
                
                if( printDebuggingInfo )
                    Console.WriteLine(sMsg);

                throw new ApplicationException(sMsg);
            }
            if (actualArgs.Length > callTranscript.GetLength(1) )
            {
                sMsg = "ERROR: For method call #"+currentCall+
                        ", expected there to be a "+ callTranscript.GetLength(1) +
                        " parameters, but the method was actually called with TOO MANY args (specifically, it was called with "+
                        actualArgs.Length +" parameters)";

                if (printDebuggingInfo)
                    Console.WriteLine(sMsg);

                throw new ApplicationException(sMsg);
            }
            if (actualArgs.Length < callTranscript.GetLength(1))
            {
                sMsg = "ERROR: For method call #" + currentCall +
                        ", expected there to be a " + callTranscript.GetLength(1) +
                        " parameters, but the method was actually called with TOO FEW args (specifically, it was called with " +
                        actualArgs.Length + " parameters)";
                        
                if (printDebuggingInfo)
                    Console.WriteLine(sMsg);

                throw new ApplicationException(sMsg);
            }

            for (int iArg = 0; iArg < callTranscript.GetLength(1); iArg++)
            {
                if (!callTranscript[currentCall, iArg].Equals(actualArgs[iArg]))
                {
                    sMsg = "ERROR: For parameter #" + iArg +
                            " Expected " + callTranscript[currentCall, iArg] + ", but was invoked with " +
                              actualArgs[iArg];

                    if (printDebuggingInfo)
                        Console.WriteLine(sMsg);

                    throw new ApplicationException(sMsg);
                }
                else if (printDebuggingInfo)
                {
                    Console.WriteLine("For parameter #{0}, expected {0}, and was given that value", 
                        iArg, callTranscript[currentCall,iArg], actualArgs[iArg]);
                }
            }
        }
    }
}