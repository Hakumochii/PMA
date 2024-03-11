using System;
using System.Collections.Generic;

namespace CS_Using_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using HashSet");

            // Step 1: Define a string array with duplicate entries
            string[] names = new string[] {
                "Luffy",
                "Zoro",
                "Luffy",
                "Usopp",
                "Chopper",
                "Robin",
                "Sanji"
            };

            // Step 2: Print the length of the array and the data in it
            Console.WriteLine("Length of Array " + names.Length);
            Console.WriteLine("The Data in Array");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            // Step 3: Define a HashSet from the string array to eliminate duplicates
            HashSet<string> hSet = new HashSet<string>(names);

            // Step 4: Print the count of elements in HashSet
            Console.WriteLine("Count of Data in HashSet " + hSet.Count);
            Console.WriteLine();

            // Step 5: Print data in HashSet (eliminates duplicate "Luffy")
            Console.WriteLine("Data in HashSet");
            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}

/* The hashing mechanism of a HashSet converts elements into hash codes, 
distributing them across an internal array. This mechanism allows the HashSet to perform operations like adding, 
finding, and removing elements quickly and efficiently. 
HashSet is probably faster for adding elements and checking element presence because of its hashing mechanism.
While List may be faster for removing elements because the elements in a List are stored next to each other in memory. */