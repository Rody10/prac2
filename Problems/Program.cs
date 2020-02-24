using System;
using System.Text;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
          
            int CountWords(string[] str)
            {
                int numWords = strArray.Length;
                return numWords;
            }
            int CountLetters(string[] str)
            {
                int numLetters = 0;

                for (int i =0 ; i < strArray.Length ; i++)
                {
                    numLetters = numLetters+strArray[i].Length;
                }
                return numLetters;

            }
            Console.WriteLine(CountLetters(strArray)+","+CountWords(strArray)+":"+str);
            Console.Read();
        }
    
    }
}
