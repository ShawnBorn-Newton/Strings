﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Shawn";
            //int lengthOfName= firstName.Length;
            //Console.WriteLine(lengthOfName);

            //string escapeString = "I want a tab after this line \t I want a new line without WriteLine\n Hi";
            //String ecsapeString2 = "I want o show a backslash here\\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(ecsapeString2);
            //Console.WriteLine(escapeString + ecsapeString2);
            //Console.WriteLine("User 1, please type something.");
            //string userOneInput = Console.ReadLine();

            //Console.WriteLine("User 2, please type something.");
            //string userTwoImput = Console.ReadLine();

            //if(userOneInput .Equals(userTwoImput))
            //{
            //    Console.WriteLine("No!");
            //}
            //else
            //{
            //    Console.WriteLine("Yes!");
            //}
            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Stephanie.";
            //string fullSentence = startOfSentence = endOfSentence;
            //Console.WriteLine(fullSentence);
            //Console.WriteLine("my friend {0} is awsome", endOfSentence);

            // problems

            Console.WriteLine(" Is you first or last name longer? \n Please ener your fist name.");
            string firstName = Console.ReadLine();
            int lengthofname = firstName.Length;
            //Console.WriteLine(lengthofname);

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();
            int lengthofLast = lastName.Length;
            //Console.WriteLine(lengthofLast);

            if(lengthofname > lengthofLast)
            {
                Console.WriteLine("First is longer");
            }
            else if(lengthofname == lengthofLast)
            {
                Console.WriteLine("Samsis");
            }
            else
            {
                Console.WriteLine("Last must be longer!");
            }


        }
    }
}
