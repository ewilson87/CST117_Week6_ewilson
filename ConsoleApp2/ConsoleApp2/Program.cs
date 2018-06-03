/**
 * Program: Console text analyzer application
 * File: Program.cs
 * Summary: reads an text file and counts all words ending in t or e
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        private static char delimiter = ' ';
        private static string fileString;
        private static string[] fileWords;
        private static string filePath;
        private static string again;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path of the textfile:");
            Console.WriteLine("For example: \"C:\\Users\\Default\\Documents\\textfile.txt\" ");

            //while loop to continously run method until accurate file path is entered
            while (true) openFile();
        }

        public static void change(int x)
        {
            x = 10;
        }

        public static void change(ref int x)
        {
            x = 10;
        }

        public static void openFile()
        {
            try
            {
                //reads console input for file path
                filePath = Console.ReadLine();

                StreamReader streamReader = new StreamReader(File.OpenRead(filePath));

                //sets initial word count ending in e or t
                int count = 0;

                //reads entire file to string
                fileString = streamReader.ReadToEnd();

                //separates file into string array
                fileWords = fileString.Split(delimiter);

                foreach (string word in fileWords)
                {
                    //char[] wordArray = word.ToCharArray();
                    List<char> wordCharList = new List<char>();

                    foreach (char wordToChar in word.ToCharArray())
                    {
                        wordCharList.Add(wordToChar);
                    }
                    while (true)
                    {
                        if (wordCharList.Last() >= 'a' && wordCharList.Last() <= 'z' ||
                            wordCharList.Last() >= 'A' && wordCharList.Last() <= 'Z')
                        {
                            if (wordCharList.Last() == 't' || wordCharList.Last() == 'e' ||
                                wordCharList.Last() == 'T' || wordCharList.Last() == 'E')
                            {
                                count++;
                            }
                            break;
                        }
                        wordCharList.RemoveAt(wordCharList.Count - 1);
                    }
                }

                Console.WriteLine("The number of words that end with e or t is " + count);

                Console.WriteLine("Open another file? Type yes or no");

                again = Console.ReadLine();

                if (again == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the path of the textfile:");
                    Console.WriteLine("For example: \"C:\\Users\\Default\\Documents\\textfile.txt\" ");
                }
                else if (again == "no")
                {
                    Environment.Exit(0);
                }
            }
            catch
            {
                Console.WriteLine("Incorrect file path");
                Console.WriteLine();
                Console.WriteLine("Enter the path of the textfile:");
                Console.WriteLine("For example: \"C:\\Users\\Default\\Documents\\textfile.txt\" ");
            }
        }
    }
}
