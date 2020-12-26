using System;

namespace Giraffe
{
    class Program
    {
         
        static void Main(string[] args)
        {
            //variables 
            //99% of what you will do will be with these variables
            string characterName = "John"; //string is plain text
            string samplePhrase = "John is a pony brony";
            char grade = 'A'; //char is only a single character. note: a char uses '' not ""
            int characterAge = 35; //int is a whole number, can also be a negagtive number
            //float, double, decimal are like int but more accurate (in order of accuaracy)
            // double is good for most cases
            double gpa = 3.3;
            bool isMale = true; //can only be true or false
        
            

            Console.WriteLine("    /|" + characterAge);
            Console.WriteLine("   / |" + characterName);
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            //some quick method examples
            Console.WriteLine(characterName.Length); //prints length of string
            Console.WriteLine( characterName.ToLower()); //converts string to lowercase
            Console.WriteLine( characterName.Contains("John"));
            Console.WriteLine( characterName.Contains("john")); //check is string conatains word and spits back a bool
            Console.WriteLine( characterName[2]); //spits second character in string. note: first chart is at index pos0
            Console.WriteLine( samplePhrase.IndexOf("pony")); //spits index of first letter in the word specified
            Console.WriteLine( samplePhrase.IndexOf('a')); //spits index of first char specified
            Console.WriteLine( samplePhrase.IndexOf('z')); //spits back -1 when char is not in the string
            //00:47:00



        

        }
    }
}
