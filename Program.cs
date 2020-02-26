using System;

namespace MethodYuanluFang
{
    class Program
    {

      
        static void Main(string[] args)
        {
            // using try-catch to terminate appilication and print error message
            try
            {
                //Print name;
                Console.WriteLine("Yuanlu Fang");

                // call the method I created
                Calculation();
 
            }

            //print error message
            catch
            {   //for fun I decided to use the random method to pring error message
                //string the error messages I want to print
                string s1 = "Check your input. Is it valid?";
                string s3 = "Invalid input. Please try again!";
                //declear array
                string[] message = {s1,s3};
                int numStrings = 2;//assign an integer according to the number of string within the array

                int stringIndex;// declear another integer to help the random number to count

                Random r = new Random(); // declear a new random number

                 stringIndex = r.Next(0, numStrings); // assign the random number to stringIndex I just declear
                 Console.WriteLine(message[stringIndex]);//print the random error message 

                Console.WriteLine("");
            }

            // create a method to perform calculation
            static void Calculation()
            {
                //declear string use for instructions
                string s2 = "What's the first number you want to use?";
                string s4 = "What's the second number you want to use?";
                string s5 = "Which arithmetic operations do you want to use? ONLY choose from (+), (-), (/), (*)! ";

                // print first instruction
                Console.WriteLine(s2);
                int Num1 = Convert.ToInt32(Console.ReadLine()); //read user input and convert into a integer

                Console.WriteLine(s4);// print second instruction
                int Num2 = Convert.ToInt32(Console.ReadLine()); //read user input and convert into a integer    

                Console.WriteLine(s5);// print third instruction
                String FlagInUse = Convert.ToString(Console.ReadLine());// read user input and convert into a string

                Console.WriteLine(); // give it a empty line - easier to read

                //start if statement to read the input flag and perform actual calculation
                if (FlagInUse == "+" )
                {
                    int Num3 = Num1+Num2;
                    Console.Write("The total of " + Num1 + " and " + Num2 + " is " + Num3);
                }

                else if (FlagInUse == "-" )
                {
                    int Num3 = Num1-Num2;
                    Console.Write("Subtract " + Num2 + " from " + Num1 + " and you get " + Num3);
                }

                else if (FlagInUse == "/")
                {
                    int Num3 = Num1/Num2;
                    Console.Write("When " + Num1 + " is divided by " + Num2 + " , the result is " + Num3);
                }

                 else if (FlagInUse == "*" )
                {
                    int Num3 = Num1*Num2;
                    Console.Write("Multiply " + Num1 + " by " + Num2 + " and you get " + Num3);
                }
              
                else
                {// the last condition is to check if user input unknown operation
                    Console.WriteLine("Boo-Boo. Please read above and try again.");
                }
                
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
