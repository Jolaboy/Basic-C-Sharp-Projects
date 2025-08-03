using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {
            // Working with Arrays
            int[] numArray = new int[5];
            numArray[0] = 10;
            numArray[1] = 20;
            numArray[2] = 30;
            numArray[3] = 40;
            numArray[4] = 50;

            int[] numArray1 = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            int[] numArray2 = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            numArray2[4] = 65;

            Console.WriteLine(numArray2[4]);
            Console.ReadLine();

            // Working with Lists
            List<int> intList = new List<int> { 4, 10 };
            intList.Remove(4);

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            // List Strings
            List<string> stringList = new List<string> { "Hello", "Amadou" };
            stringList.Remove("Amadou");

            Console.WriteLine(stringList[0]);
            Console.ReadLine();
        }
    }
}
