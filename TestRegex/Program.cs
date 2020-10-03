using System;
using System.Text.RegularExpressions;

namespace TestRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input for testing Regex!");
            String input=Console.ReadLine();
            //Regex reg = new Regex("^[a-zA-Z]{5}$");
            // Regex reg = new Regex("^[0-9]*[a-zA-Z]{3,}[0-9a-zA-Z]*$");
            //Regex reg = new Regex("^[0-9]{6}$");
            Regex reg = new Regex("^[0-9]{3}[ ]?[0-9]{3}$");
            bool res= reg.IsMatch(input);
            
            if(res==true)
            {
                Console.WriteLine("Pattern matching");
            }
            else
            {
                Console.WriteLine("no matching");
            }
            Console.Read();
        }
    }
}
