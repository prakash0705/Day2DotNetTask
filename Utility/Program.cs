using System;
using System.Collections.Generic;

namespace Utility
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Find the word based on the position
            Console.WriteLine("Enter string");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the position of word");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the char to parse");
            char charToParse = Console.ReadLine()[0];
            Console.WriteLine(LastWord(position, input, charToParse)+"\n");

            //2. check if the any of string is palindrome in a array
            Console.WriteLine("Enter the number of strings to find palindrome");
            int lenghtOfString = int.Parse(Console.ReadLine());
            string[] palindromeArray = new string[lenghtOfString];
            Console.WriteLine("Enter the strings");
            for (int i=0;i<lenghtOfString;i++)
            {
                palindromeArray[i] = Console.ReadLine();
            }
           // palindromeArray = { "madam","refer","level","radar","welcome","world","hello"};
            Program program = new Program();
            //find Palindrome in array of strings
            List<string> list=program.GetPalindromes(palindromeArray);
            if(list.Count==0)
            {
                Console.WriteLine($"There is no palindrome in a array of strings" + "[{0}]", string.Join(",", palindromeArray).Trim(','));
            }
            else
            {
                Console.WriteLine($"Palindromes in array of strings"+"[{0}] are: ",string.Join(",",palindromeArray).Trim(','));
                foreach (string value in list)
                {
                    Console.WriteLine(value);
                }
                Console.Write("\n");
            }

            //3. Temperature convertor - celcius to fahrenheit and vice versa
            Console.WriteLine("Please select the convertor");
            Console.WriteLine("1 -  From celcius to fahrenheit");
            Console.WriteLine("2 - From fahrenheit to celcius");
            string options = Console.ReadLine();
            double celcius, fahrenheit;
            switch(options)
            {
                case "1":
                    Console.Write("Please enter celcius temperature: ");
                    fahrenheit = TemperatureConverter.CelciusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit is "+ string.Format("{0:0.00}",fahrenheit));
                    break;
                case "2":
                    Console.Write("Please enter fahrenheit temperature: ");
                    celcius = TemperatureConverter.FahrenheitToCelcius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celcius is "+ string.Format("{0:0.00}",celcius));
                    break;
                default:
                    Console.WriteLine("Please select converter");
                    break;
            }

        }
        static string LastWord(int position,string input,char charToParse)
        {
            string[] array = input.Split(charToParse);
            for(int i=0;i<array.Length;i++)
            {
                if(i==position)
                {
                    return $"the word {array[i]} is in position "+position;
                }
            }
            return "There is no word in the position " + position;
        }
        List<string> GetPalindromes(string[] array)
        {
            List<string> list = new List<string>();
            string reverse;
            string element;
            foreach(string value in array)
            {
                element = value;
                reverse = "";
                for(int i=element.Length-1;i>=0;i--)
                {
                    reverse += element[i];
                }
                if(reverse==element)
                {
                    list.Add(element);
                }
            }
            return list;
        }

    }
}
