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

            //some quick C# string methods
            Console.WriteLine( characterName.Length); //prints length of string
            Console.WriteLine( characterName.ToLower()); //converts string to lowercase
            Console.WriteLine( characterName.Contains("John"));
            Console.WriteLine( characterName.Contains("john")); //check is string conatains word and spits back a bool
            Console.WriteLine( characterName[2]); //spits second character in string. note: first chart is at index pos0
            Console.WriteLine( samplePhrase.IndexOf("pony")); //spits index of first letter in the word specified
            Console.WriteLine( samplePhrase.IndexOf('a')); //spits index of first char specified
            Console.WriteLine( samplePhrase.IndexOf('z')); //spits back -1 when char is not in the string
            Console.WriteLine( samplePhrase.Substring( samplePhrase.IndexOf("pony")) );

            //some quick math operations

            Console.WriteLine( 4 + 2 );
            Console.WriteLine( 5 % 2 ); //% is modulus
            Console.WriteLine( (4 +2) * 2); //() can change the order of the math operations
            Console.WriteLine( Math.Sqrt(5)); //Math. will give you a bunch of useful math operations

            //operations to get user imput
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine( "Hello " + name + "!" );
            Console.Write(name + ", what is your age? ");
            string  age = Console.ReadLine();
            Console.WriteLine( "Hello " + name + ", your age is: " + age + "!" );

            //basic calculator taking user inputs. Using a method that converts a string into a number
            Console.Write("Enter a whole number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); //takes user imput as a string and converts it to an int/number
            Console.WriteLine("You entered: " + num1);
            Console.WriteLine("To verify that this is trully treated as a number, your number x2 = " + num1 * 2);
            
            //basic madlibs type of game
            string color, pluralNoun, food;
            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            
            Console.Write("Enter a favorite food: ");
            food = Console.ReadLine();

            Console.WriteLine("Roses are ," + color);
            Console.WriteLine(pluralNoun + " are blue,");
            Console.WriteLine("I Love " + food + " !");

        }
    }
}

