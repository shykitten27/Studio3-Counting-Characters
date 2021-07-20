using System;
using System.Collections.Generic;
using System.IO;

namespace Studio3_Counting_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = "";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:/Users/Donna/launchcode/csharp-practice/Chpt3/Studio3-Counting-Characters/Studio3-Counting-Characters/Studio3-Counting-Characters/trees_lyrics.txt");
                //Read the first line of text
                string line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);

                    userString += line;

                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            /*finally
            {
                Console.WriteLine("Executing finally block.");
            }*/
            //Console.WriteLine("Enter a sentence or phrase.");
            //string userString = Console.ReadLine();
            //string userString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            char[] charsArr = userString.ToLower().ToCharArray();
            Dictionary<char, int> characters = new Dictionary<char, int>();

            for (int i = 0; i < charsArr.Length; i++)
            {
                if (Char.IsLetter(charsArr[i])) //only include letters
                {
                    if (characters.ContainsKey(charsArr[i]))
                    {
                        characters[charsArr[i]] += 1; //if key exists, add 1 to value
                    }
                    else
                        characters.Add(charsArr[i], 1); // else, create new key and set value to 1
                    }
            }

            foreach (KeyValuePair<char, int> character in characters)
            {
                Console.WriteLine(character.Key + ":" + character.Value);
            }
        }
    }
}