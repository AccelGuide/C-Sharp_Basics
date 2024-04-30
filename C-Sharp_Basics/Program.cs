using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a comment
            Console.WriteLine("Hello World");
            Console.WriteLine("I am Learning C#"); // This is a comment
            Console.Write("It ");
            Console.Write("is ");
            /* The code below will print "awesome!"
            to the screen, and it is amazing */
            Console.Write("awesome!");
            Console.WriteLine("The Method Write/() does not insert a new line at the end of the output unlike WriteLine/()");

            Console.WriteLine("_____CALC_____");

            Console.WriteLine("3 + 3");

            Console.WriteLine("_____Variables_____");

            string sName = "John";
            Console.WriteLine(sName);

            int myNum1 = 15;
            Console.WriteLine(myNum1);

            int myNum2;
            myNum2 = 15;
            Console.WriteLine(myNum2);

            int myNum3 = 15;
            myNum3 = 20; // myNum is now 20
            Console.WriteLine(myNum3);

            int myNum_A = 5;
            double myDoubleNum_A = 5.99D;
            char myLetter_A = 'D';
            bool myBool_A = true;
            string myText_A = "Text string";

            Console.WriteLine(myNum_A);
            Console.WriteLine(myDoubleNum_A);
            Console.WriteLine(myLetter_A);
            Console.WriteLine(myBool_A);
            Console.WriteLine(myText_A);

            Console.WriteLine("_____Data Types_____");

            /*
             * int 	4 bytes 	Stores whole numbers from -2,147,483,648 to 2,147,483,647
             * long 	8 bytes 	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
             * float 	4 bytes 	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
             * double 	8 bytes 	Stores fractional numbers. Sufficient for storing 15 decimal digits
             * bool 	1 bit 	Stores true or false values
             * char 	2 bytes 	Stores a single character/letter, surrounded by single quotes
             * string 	2 bytes per character 	Stores a sequence of characters, surrounded by double quotes
             */

            int myNum_int = 100000;
            Console.WriteLine(myNum_int);

            long myNum_long = 15000000000L;
            Console.WriteLine(myNum_long);

            float myNum_float = 5.75F;
            Console.WriteLine(myNum_float);

            double myNum_double = 19.99D;
            Console.WriteLine(myNum_double);

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            // Booleans

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            // Characters

            char myGrade_char = 'B';
            Console.WriteLine(myGrade_char);

            // Strings

            string greeting_string = "Hello World";
            Console.WriteLine(greeting_string);

            //_____Type_Casting_____Typ-Konvertierung-Umwandlung

            // Implicit Casting
            // Einfügen nach Oben

            int myInt_A = 9;
            double myDouble_A = myInt_A;  // Automatic casting: int to double

            Console.WriteLine(myInt_A);
            Console.WriteLine(myDouble_A);

            // Explicit Casting
            // Einfügen nach Unten

            double myDouble_B = 9.78;
            int myInt_B = (int)myDouble_B;  // Manual casting: double to int

            Console.WriteLine(myDouble_B);
            Console.WriteLine(myInt_B);

            // Konvertierung

            int myInt_C = 10;
            double myDouble_C = 5.25;
            bool myBool_C = true;

            Console.WriteLine(Convert.ToString(myInt_C));    // Convert int to string
            Console.WriteLine(Convert.ToDouble(myInt_C));    // Convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble_C));  // Convert double to int
            Console.WriteLine(Convert.ToString(myBool_C));   // Convert bool to string


            Console.WriteLine("Bist du Fertig?");
            Console.WriteLine("Drücke Enter, um das Programm zu beenden...");
            Console.ReadLine();
        }
    }
}
