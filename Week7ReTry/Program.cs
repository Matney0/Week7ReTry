using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7ReTry
{
    class Program
    {

        //Method to counts the number of words in a text file
        public static int CountWords(string fileName)
        {
            //Read the file
            string content = System.IO.File.ReadAllText(fileName);
            //Split the text into words
            string[] words = content.Split(' ');
            //Return the number of words
            return words.Length;
        }

        static void Main(string[] args)
        {
            //string file = "C:\\Users\\user\\Desktop\\test.txt";
            string fileName = "test.txt";

            //Call the method to count the number of words in the file
            int count = CountWords(fileName);

            //return the number of words andd what the file saidd
            Console.WriteLine("The file " + fileName + " contains " + count + " words.");

            //read the text from the test file
            string content = System.IO.File.ReadAllText(fileName);
            Console.WriteLine("The file says: " + content);
        }
    }
}
