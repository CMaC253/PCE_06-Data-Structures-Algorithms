using System;
using System.IO;
using NUnit.Framework;

/*
 * This file contains all the tests that will be run.
 * 
 * If you want to find out what a test does (or why it's failing), look in here
 * 
 */

namespace PCE_StarterProject
{
    [TestFixture]
    [Timeout(2000)] // 2 seconds default timeout
    [Description(TestHelpers.TEST_SUITE_DESC)] // tags this as an exercise to be graded...
    public class NUnit_Tests_PrintEven_Recursive : TestHelpers
    {
        RecursiveMethods rm;

        [SetUp]
        protected void SetUp()
        {
            rm = new RecursiveMethods();
        }

        [Test]
        [Category("PrintEvenNumbers_Recursively")]
        public void Correct_Output([Values(1, 2, 3, 4, 5)]int startingNum)
        {
            StringWriter sw = new StringWriter();
            switch (startingNum)
            {
                case 5:
                case 4:
                    sw.WriteLine("Argument: 4");
                    goto case 3;
                case 3:
                case 2:
                    sw.WriteLine("Argument: 2");
                    goto case 1;
                case 1:
                case 0:
                    sw.WriteLine("Argument: 0");
                    break;
            }
            string sCorrect = sw.ToString();

            StartOutputCapturing();

            rm.PrintEvenNumbers_Recursively(startingNum);

            String sResult = StopOutputCapturing();
            Assert.That(TestHelpers.EqualsFuzzyString(sCorrect, sResult), "Expected the output:\n" + sCorrect
                + "\nBut actually got the output:\n" + sResult);
        }
    }

    //////////////////////////////////////////////////////////////////////////
    //
    // Ignore this for now
    //
    //[TestFixture]
    //[Timeout(2000)] // 2 seconds default timeout
    //[Description(TestHelpers.TEST_SUITE_DESC)] // tags this as an exercise to be graded...
    //public class NUnit_Tests_PrintEven_Recursive_Verified : TestHelpers
    //{
    //    RM_Verifier rm;

    //    [SetUp]
    //    protected void SetUp()
    //    {
    //        rm = new RM_Verifier();
    //    }

    //    [Test]
    //    [Category("PrintEvenNumbers_Recursively_Verified")]
    //    public void Correct_for_basic_values([Values(1, 2, 3, 4, 5)]int startingNum)
    //    {
    //        // set up the call transcript
    //        Object[,] calls = new Object[,] 
    //        { 
    //            { 3 },
    //            { 2 },
    //            { 1 },
    //            { 0 },
    //        };
    //        DoTest(calls, startingNum);
    //    }

    //    private void DoTest(Object[,] calls, int startingNum)
    //    {
    //        // Tell the verifier what sequence of arguments (to the method calls) to expect
    //        rm.Verifier.SetCallTranscript(calls);

    //        // Uncomment the next line to confirm that the call transcript is set up correctly
    //        rm.Verifier.PrintCallTranscript();

    //        // Uncomment next line to see debugging output
    //        rm.Verifier.TurnOnDebuggingOutput();

    //        // Make sure that we're starting with the first method call :)
    //        rm.Verifier.ResetCurrentCall();

    //        // If there's a problem, the overridden RM_Verifier.PrintEvenNumbers_Recursively method 
    //        // will throw an exception, which will cause the test to fail.
    //        rm.PrintEvenNumbers_Recursively(3);

    //        // The test will fail if the recursive function makes too many function calls
    //        // Here we make sure that we called the method the number of times we should have
    //        Assert.That(rm.Verifier.ConfirmAllCallsMade(), "ERROR! The recursion stopped early, " +
    //            "and did NOT make all the calls that it should have!");
    //    }
    //}

    [TestFixture]
    [Timeout(2000)] // 2 seconds default timeout
    [Description(TestHelpers.TEST_SUITE_IGNORE_DESC)] // tags this as an exercise to be graded...
    public class NUnit_Tests_Recursive_Power : TestHelpers
    {
        RecursiveMethods rm;

        [SetUp]
        protected void SetUp()
        {
            rm = new RecursiveMethods();
        }

        [Test]
        [Category("Recursive Power Pos")]
        public void Correct_for_Positive_operands([Values(1, 2, 3, 4, 5)]int b, [Values(1, 2, 3, 4, 5)]int exp)
        {
            int rightAnswer = (int)Math.Pow(b, exp);
            int result = rm.PowR(b, exp);
            Assert.That(rightAnswer == result, "When raising " + b + " to the power of " + exp +
                " the expected answer is " + rightAnswer + "\nThe answer that was actually obtained was " + result);
        }

        [Test]
        [Category("Recursive Power With Zero")]
        public void Correct_for_Zero([Values(0, 1, 2, 3)]int b, [Values(0, 1, 2, 3)]int exp)
        {
            int rightAnswer = (int)Math.Pow(b, exp);
            int result = rm.PowR(b, exp);
            Assert.That(rightAnswer == result, "When raising " + b + " to the power of " + exp +
                " the expected answer is " + rightAnswer + "\nThe answer that was actually obtained was " + result);
        }
    }

    [TestFixture]
    [Timeout(2000)] // 2 seconds default timeout
    [Description(TestHelpers.TEST_SUITE_DESC)] // tags this as an exercise to be graded...
    public class NUnit_Tests_Recursive_Multiplication : TestHelpers
    {
        RecursiveMethods rm;

        [SetUp]
        protected void SetUp()
        {
            rm = new RecursiveMethods();
        }

        [Test]
        [Category("Recursive Multiplication Positives")]
        public void Correct_for_Positive_operands([Values(1, 2, 3, 4, 5)]int a, [Values(1, 2, 3, 4, 5)]int b)
        {
            int rightAnswer = a * b;
            int result = rm.MultR(a, b);
            Assert.That(rightAnswer == result, "When mupltiplying " + a + " * " + b +
                " the expected answer is " + rightAnswer + "\nThe answer that was actually obtained was " + result + "\n");
        }

        [Test]
        [Category("Recursive Multiplication Pos Neg")]
        public void Correct_for_Positive_Negative([Values(1, 2, 3, 4, 5)]int a, [Values(-1, -2, -3, -4, -5)]int b)
        {
            int rightAnswer = a * b;
            int result = rm.MultR(a, b);
            Assert.That(rightAnswer == result, "When mupltiplying " + a + " * " + b +
                " the expected answer is " + rightAnswer + "\nThe answer that was actually obtained was " + result);
        }


        [Test]
        [Category("Recursive Multiplication Neg Pos")]
        public void Correct_for_Negative_Positive([Values(-1, -2, -3, -4, -5)]int a, [Values(1, 2, 3, 4, 5)]int b)
        {
            int rightAnswer = a * b;
            int result = rm.MultR(a, b);
            Assert.That(rightAnswer == result, "When mupltiplying " + a + " * " + b +
                " the expected answer is " + rightAnswer + "\nThe answer that was actually obtained was " + result);
        }

        [Test]
        [Category("Recursive Multiplication Neg Neg")]
        public void Correct_for_Negative_Negative([Values(-1, -2, -3, -4, -5)]int a, [Values(-1, -2, -3, -4, -5)]int b)
        {
            int rightAnswer = a * b;
            int result = rm.MultR(a, b);
            Assert.That(rightAnswer == result, "When mupltiplying " + a + " * " + b +
                " the expected answer is " + rightAnswer + "\nThe answer that was actually obtained was " + result);
        }

        [Test]
        [Category("Recursive Multiplication With Zero")]
        public void Correct_for_Zero([Values(0, 1, 2, 3)]int a, [Values(0, 1, 2, 3)]int b)
        {
            int rightAnswer = a * b;
            int result = rm.MultR(a, b);
            Assert.That(rightAnswer == result, "When mupltiplying " + a + " * " + b +
                " the expected answer is " + rightAnswer + "\nThe answer that was actually obtained was " + result);
        }
    }

    [TestFixture]
    [Timeout(2000)] // 2 seconds default timeout
    [Description(TestHelpers.TEST_SUITE_IGNORE_DESC)] // tags this as an exercise to be graded...
    public class NUnit_Tests_Factorial_Recursive : TestHelpers
    {
        RecursiveMethods rm;

        [SetUp]
        protected void SetUp()
        {
            rm = new RecursiveMethods();
        }

        [Test]
        [Category("Factorial of Zero One")]
        public void Test_Zero( [Values(0, 1)]int N)
        {
            int result = rm.Factorial(N);
            int rightAnswer = 1;

            Assert.That(rightAnswer == result, "Factorial("+N+") should be " + rightAnswer + 
                "\nThe answer that was actually obtained was " + result);
        }

        [Test]
        [Category("Factorial of a negative number")]
        public void Test_Negatives([Values(-10, -20, -2, -1, -10000)]int N)
        {
            int result = rm.Factorial(N);
            int rightAnswer = 0;

            Assert.That(rightAnswer == result, "Factorial(" + N + ") should be " + rightAnswer +
                "\nThe answer that was actually obtained was " + result);
        }

        [Test]
        [Category("Factorial of a positive number")]
        public void Test_Positives([Values(2, 3, 4, 5, 6, 10)]int N)
        {
            int result = rm.Factorial(N);
            int rightAnswer = 0;
            switch (N)
            {
                case 2:
                    rightAnswer = 2;
                    break;
                case 3:
                    rightAnswer = 6;
                    break;
                case 4:
                    rightAnswer = 24;
                    break;
                case 5:
                    rightAnswer = 120;
                    break;
                case 6:
                    rightAnswer = 720;
                    break;
                case 10:
                    rightAnswer = 3628800;
                    break;
            }

            Assert.That(rightAnswer == result, "Factorial(" + N + ") should be " + rightAnswer +
                "\nThe answer that was actually obtained was " + result);
        }
    }

    [TestFixture]
    [Timeout(2000)] // 2 seconds default timeout
    [Description(TestHelpers.TEST_SUITE_IGNORE_DESC)] // tags this as an exercise to be graded...
    public class NUnit_Tests_Fibonacci_Array : TestHelpers
    {
        RecursiveMethods rm;

        [SetUp]
        protected void SetUp()
        {
            rm = new RecursiveMethods();
        }

        [Test]
        [Category("Fibonacci_Array with null")]
        public void Test_Null()
        {
            // If this crshes, the test will fail
            rm.Fibonacci_Array(null);

            // This isn't supposed to do anything other than not crash :)
        }

        [Test]
        [Category("Fibonacci_Array with empty array")]
        public void Test_Empty()
        {
            // If this crshes, the test will fail
            int[] nums = new int[0];
            rm.Fibonacci_Array(nums);

            // This isn't supposed to do anything other than not crash :)
        }

        [Test]
        [Category("Fibonacci_Array with empty array")]
        public void Test_Normal([Values(1, 2, 5, 7, 10)]int arrayLength)
        {
            int[] nums = new int[arrayLength];

            // Put in bogus starting values, just so that the method
            // really is calculating the values from scratch
            for (int i = 0; i < nums.Length; i++)
                nums[i] = -1;

            rm.Fibonacci_Array(nums);

            int []rightAnswer = new int [arrayLength];

            rightAnswer[0] = 0;
            if (arrayLength >= 2)
                rightAnswer[1] = 1;

            for (int i = 2; i < rightAnswer.Length; i++)
            {
                rightAnswer[i] = rightAnswer[i - 1] + rightAnswer[i - 2];
            }

            Console.WriteLine("Given an array of length " + nums.Length + "  What the array was filled with is:\n" +
                TestHelpers.Array_ToString(nums) + "\nWhat the array should have been filled with:\n" +
                TestHelpers.Array_ToString(rightAnswer));

            Assert.That(TestHelpers.ArraysTheSame(nums, rightAnswer), "Fibonacci_Array didn't fill the array with the expected values!!");
        }
    }

    [TestFixture]
    [Timeout(2000)] // 2 seconds default timeout
    [Description(TestHelpers.TEST_SUITE_DESC)] // tags this as an exercise to be graded...
    public class NUnit_Tests_LL_RecursivelyPrintForward 
    {
        LinkedList_Verifier LL;

        [SetUp]
        protected void SetUp()
        {
            LL = new LinkedList_Verifier();
        }

        [Test]
        [Category("LL RecursivelyPrintForward")]
        public void Print_Empty()
        {
            TestHelpers th = new TestHelpers();
            th.StartOutputCapturing();

            LL.RecursivelyPrintForward(); // this should NOT crash

            String sResult = th.StopOutputCapturing();
            String sCorrect = ""; // no actual output, since the list is empty

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back nothing (not even a new/blank line), but actually got:\n{0}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sResult);
        }

        [Test]
        [Category("LL RecursivelyPrintForward")]
        public void Print_Single()
        {
            LL.InsertAtFront(10);

            TestHelpers th = new TestHelpers();
            Console.WriteLine("Printing the list, using student implementation");

            th.StartOutputCapturing();

            LL.RecursivelyPrintForward(); // this should NOT crash

            String sResult = th.StopOutputCapturing();
            String sCorrect = "10";
            Console.WriteLine("Expected, correct output:\n" + sCorrect);

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back\n{0}\nActually got:\n{1}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sCorrect, sResult);
        }


        [Test]
        [Category("LL RecursivelyPrintForward")]
        public void Print_Several_Items([Values(new int[] { 1, 2, 3 }, new int[] { -10, 20, 200 })] int[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
                LL.InsertAtFront(nums[i]);

            TestHelpers th = new TestHelpers();
            Console.WriteLine("Printing the list, using student implementation");
            th.StartOutputCapturing();

            LL.RecursivelyPrintForward();

            String sResult = th.StopOutputCapturing();
            String sCorrect = TestHelpers.PrintArrayToString(nums);
            Console.WriteLine("Expected, correct output:\n" + sCorrect);

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back\n{0}\nActually got:\n{1}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sCorrect, sResult);
        }
    }

    [TestFixture]
    [Timeout(2000)] // 2 seconds default timeout
    [Description(TestHelpers.TEST_SUITE_DESC)] // tags this as an exercise to be graded...
    public class NUnit_Tests_LL_RecursivelyPrintBackward
    {
        LinkedList_Verifier LL;

        [SetUp]
        protected void SetUp()
        {
            LL = new LinkedList_Verifier();
        }

        [Test]
        [Category("LL RecursivelyPrintBackward")]
        public void Print_Empty()
        {
            TestHelpers th = new TestHelpers();
            th.StartOutputCapturing();

            LL.RecursivelyPrintBackward(); // this should NOT crash

            String sResult = th.StopOutputCapturing();
            String sCorrect = ""; // no actual output, since the list is empty

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back nothing (not even a new/blank line), but actually got:\n{0}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sResult);
        }

        [Test]
        [Category("LL RecursivelyPrintBackward")]
        public void Print_Single()
        {
            LL.InsertAtFront(10);

            TestHelpers th = new TestHelpers();
            Console.WriteLine("Printing the list, using student implementation");

            th.StartOutputCapturing();

            LL.RecursivelyPrintBackward(); // this should NOT crash

            String sResult = th.StopOutputCapturing();
            String sCorrect = "10";
            Console.WriteLine("Expected, correct output:\n" + sCorrect);

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back\n{0}\nActually got:\n{1}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sCorrect, sResult);
        }


        [Test]
        [Category("LL RecursivelyPrintBackward")]
        public void Print_Several_Items([Values(new int[] { 1, 2, 3 }, new int[] { -10, 20, 200 })] int[] nums)
        {
            // NOTE: We're adding these in the reverse order!!
            // (So the output will look right when we just 'print' the array)
            for (int i = 0; i < nums.Length; i++)
                LL.InsertAtFront(nums[i]);

            TestHelpers th = new TestHelpers();
            Console.WriteLine("Printing the list, using student implementation");
            th.StartOutputCapturing();

            LL.RecursivelyPrintBackward();

            String sResult = th.StopOutputCapturing();
            String sCorrect = TestHelpers.PrintArrayToString(nums);
            Console.WriteLine("Expected, correct output:\n" + sCorrect);

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back\n{0}\nActually got:\n{1}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sCorrect, sResult);
        }
    }

    [TestFixture]
    [Timeout(2000)] // 2 seconds default timeout
    [Description(TestHelpers.TEST_SUITE_DESC)] // tags this as an exercise to be graded...
    public class NUnit_Tests_LL_RecursivelyPrint
    {
        LinkedList_Verifier LL;

        [SetUp]
        protected void SetUp()
        {
            LL = new LinkedList_Verifier();
        }

        [Test]
        [Category("LL RecursivelyPrint Foward")]
        public void Print_Empty_Forward()
        {
            TestHelpers th = new TestHelpers();
            th.StartOutputCapturing();

            LL.RecursivelyPrint(true); // this should NOT crash

            String sResult = th.StopOutputCapturing();
            String sCorrect = ""; // no actual output, since the list is empty

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back nothing (not even a new/blank line), but actually got:\n{0}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sResult);
        }
        [Test]
        [Category("LL RecursivelyPrint Backward")]
        public void Print_Empty_Backward()
        {
            TestHelpers th = new TestHelpers();
            th.StartOutputCapturing();

            LL.RecursivelyPrint(false); // this should NOT crash

            String sResult = th.StopOutputCapturing();
            String sCorrect = ""; // no actual output, since the list is empty

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back nothing (not even a new/blank line), but actually got:\n{0}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sResult);
        }


        [Test]
        [Category("LL RecursivelyPrint Foward")]
        public void Print_Single_Forward()
        {
            LL.InsertAtFront(10);

            TestHelpers th = new TestHelpers();
            Console.WriteLine("Printing the list, using student implementation");

            th.StartOutputCapturing();

            LL.RecursivelyPrint(true); // this should NOT crash

            String sResult = th.StopOutputCapturing();
            String sCorrect = "10";
            Console.WriteLine("Expected, correct output:\n" + sCorrect);

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back\n{0}\nActually got:\n{1}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sCorrect, sResult);
        }

        [Test]
        [Category("LL RecursivelyPrint Backward")]
        public void Print_Single_Backward()
        {
            LL.InsertAtFront(10);

            TestHelpers th = new TestHelpers();
            Console.WriteLine("Printing the list, using student implementation");

            th.StartOutputCapturing();

            LL.RecursivelyPrint(false); // this should NOT crash

            String sResult = th.StopOutputCapturing();
            String sCorrect = "10";
            Console.WriteLine("Expected, correct output:\n" + sCorrect);

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back\n{0}\nActually got:\n{1}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sCorrect, sResult);
        }


        [Test]
        [Category("LL RecursivelyPrint Foward")]
        public void Print_Several_Items_Forward([Values(new int[] { 1, 2, 3 }, new int[] { -10, 20, 200 })] int[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
                LL.InsertAtFront(nums[i]);

            TestHelpers th = new TestHelpers();
            Console.WriteLine("Printing the list, using student implementation");
            th.StartOutputCapturing();

            LL.RecursivelyPrint(true);

            String sResult = th.StopOutputCapturing();
            String sCorrect = TestHelpers.PrintArrayToString(nums);
            Console.WriteLine("Expected, correct output:\n" + sCorrect);

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back\n{0}\nActually got:\n{1}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sCorrect, sResult);
        }

        [Test]
        [Category("LL RecursivelyPrint Backward")]
        public void Print_Several_Items_Backward([Values(new int[] { 1, 2, 3 }, new int[] { -10, 20, 200 })] int[] nums)
        {
            // NOTE: We're adding these in the reverse order!!
            // (So the output will look right when we just 'print' the array)
            for (int i = 0; i < nums.Length; i++)
                LL.InsertAtFront(nums[i]);

            TestHelpers th = new TestHelpers();
            Console.WriteLine("Printing the list, using student implementation");
            th.StartOutputCapturing();

            LL.RecursivelyPrint(false);

            String sResult = th.StopOutputCapturing();
            String sCorrect = TestHelpers.PrintArrayToString(nums);
            Console.WriteLine("Expected, correct output:\n" + sCorrect);

            Assert.That(TestHelpers.EqualsFuzzyString(sResult, sCorrect),
                "Expected to get back\n{0}\nActually got:\n{1}END OF YOUR OUTPUT\n(The above 'END OF YOUR OUTPUT' message was added by the test, so that it's clear if you've got an extra line in your output)", sCorrect, sResult);
        }
    }

}