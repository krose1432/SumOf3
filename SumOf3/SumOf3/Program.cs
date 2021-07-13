using System;
using System.Linq;

namespace SumOf3
    /*
     * 
     * @author Keishon Rose 113443769
     * version 7/13/2021
     * 
     */

{
    class Program
    {
        static void Main(string[] args)
            
        {
            //Variables for input
            string stringNumbers;
            double inputNumbers;

            
            Console.WriteLine("Enter three different numbers seperated by commas.");

            //This is reading in the numbers from the console while parsing them.
            stringNumbers = Console.ReadLine();
          /* this is what defines the parse and tells the program where to parse the numbers 
           * at. In this case, I defined it whenver a comma, "," ,appears.*/
            string[] separatingString = { ","}; 
            string[] numbers = stringNumbers.Split(separatingString, System.StringSplitOptions.RemoveEmptyEntries); //Doing the actual parsing 
            
            // Deleting this comment would allow for you to check and see if the numbers are parsed correctly. 
            // This is not a testing method however.
            /*foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            */

            //This is converting all of the strings from the "numbers" array to a double and putting them in a new array called "doubles.
            double[] doubles = Array.ConvertAll(numbers, double.Parse);

            //This is calculating the sum of the array a translating it to a string with three decimal points.
            String sum = doubles.Sum().ToString("F3");

            // This is outputting your resluts.
            Console.WriteLine("The sum of all three of these numbers is " + sum);
            double product = 7.777 * doubles.Sum();
            Console.WriteLine("The product of 7.777 and " + sum + " is " + product.ToString("F3"));
            

        }
    }
}
