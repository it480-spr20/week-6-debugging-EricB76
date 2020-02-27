using System;

namespace OddOrPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { -3, -2, 0, 1, 4 };
            int result = oddOrPositive(inputArray);
            Console.WriteLine("Expected result is 3, actual result is " + result);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        } //end main

        // If x==null throw NullPointerException
        // else return the number of elements in x that
        // are odd and/or positive
        static int oddOrPositive(int[] x)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 != 0 || x[i] > 0)
                {
                    count++;
                } //End if
            } //End for
            return count;
        } //End oddOrPositive
    } //End class
} //end namespace
