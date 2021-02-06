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
            int age = Convert.ToInt32(Console.ReadLine()); //takes user imput as a string and converts it to an int/number
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

            //basic array usage, remember an array is basically a container
            int[] luckyNumbers = { 4, 8, 15, 16};
            Console.WriteLine ( luckyNumbers[0] ); //should give the first number in the array. remember index's start at 0 and array is indexed
            string[] friends = new string[5]; //sets the size of the array
            friends[0] = "john"; //populates the array
            friends[1] = "kyle";

            //going to call the method bellow
            SayHi(name, age); //note that I had to pass in a string since method SayHi needs a string for nameMethod
            SayHiAgain(name, age);
            IfThens();
            Console.WriteLine(GetMax(2, 10));

            
        }



        //methods / remember naming convention of starting methods with a capitol letter
        //also know that some people call these methods functions though tec they are methods in C#
        //notice how i use nameMethod and ageMethod instead of (name, age). this is show that method SayHi is actually taking in two inputs
        static void SayHi(string nameMethod, int ageMethod) //adding string name inside the method () lets the method take in a peram.
        //also note that i added an int and that you can add most any value to be passed into the method as well
        {
            Console.WriteLine("Hello ," + nameMethod + " this is the SayHi Method, you are " + ageMethod);
            //remember that a method outiside of main does not get run automaticall so I will add a line above to callt his method
        }


       //dont forget to put identifiers for the inputs: name/ageMethod for every method taking an input in this case string and int
        static void SayHiAgain(string nameMethod, int ageMethod)
        {
            //pack a box
            int[] iLoveTheseNumbers = {1, 2 ,3 ,4};
            Console.WriteLine("if i print a 1, then this is basic array usage: " + iLoveTheseNumbers[0]);

            Console.WriteLine("Hello again "  + nameMethod + " who is btw " + ageMethod + ". this time we are calling a method with a return statement and 2 input numbers" );
            Console.WriteLine("enter your test word:");
            string tester = Console.ReadLine();
            Console.WriteLine("your test word was: " + tester);
            Console.WriteLine("these numbers will be cubed using a single method with a return of: 2, 3, and 7");
            
            Console.WriteLine(Cube(2));
            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(7));

        }
        
        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static void IfThens()
        {
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall) //could also use || for OR instead of AND
            {
                Console.WriteLine("you are a tall male");
            }
            else if (isMale && !isTall) 
            {
                Console.WriteLine("you are a short male");
            }
            else if (!isMale && isTall) 
            {
                Console.WriteLine("you are not male but you are tall");
            }
            else
            {
                Console.WriteLine("you are not male and not tall");
            }
        }

        //a method that returns the max of 2 numbers using a compare statement
        static int GetMax(int num1, int num2)
        {
            int resultGetMax;
            if (num1 > num2)
            {
                resultGetMax = num1;
            }
            else
            {
                resultGetMax = num2;
            }
            return resultGetMax;
        }




    }
}

//timestamp 02:06:00
