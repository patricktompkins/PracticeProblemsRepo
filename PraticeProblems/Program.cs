using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //String messageOne = "Patrick Cornelius Tompkins";
            //String messageTwo = "Dodge Charger";
            //String messageThree = "Batman";
            //Console.WriteLine("Patrick Cornelius Tompkins");
            //Console.WriteLine("Dodge Charger");
            //Console.WriteLine("Batman");

            ///*Day 2 Homework*/

            ///* Question 1 
            //-Lisa is cooking muffins. The recipe calls for 7 cups of sugar.She has already put in 2 cups.How many more cups does she need to put in? */

            /*int cupOne = 7;
            int cupTwo = 2;
            int cupTotal = cupOne - cupTwo;
           Console.WriteLine(cupOne - cupTwo);*/


            ///* Question 2 
            //   At a restaurant, Mike and his three friends decided to divide the bill evenly.If each person paid $13 then what was the total bill?*/


            /*int billOne = 13, billTwo = 13, billThree = 13, billFour = 13;
            Console.WriteLine(billOne + billTwo + billThree + billFour);*/

            ///*Question 3
            //-How many packages of diapers can you buy with $40 if one package costs $8? */


            //int diapersMoney = 40, diapersCost = 8;
            //Console.WriteLine(diapersMoney / diapersCost);

            ///*Question 4
            //  Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic. He now has $41. How much money did he receive? */


            //int moneyOne = 29, moneyTwo = 41;
            //Console.WriteLine(moneyTwo - moneyOne);


            //Day 3 Homework

            /*int cupOne = 7;
            int cupTwo = 2;
            int cupTotal = cupOne - cupTwo;
            Console.WriteLine(cupOne - cupTwo);*/

            /*Console.WriteLine("What is your name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("{0} needs {1} cups of sugar. ",firstName, cupTotal);*/

           
            
            
            //At a restaurant, Mike and his three friends decided to divide the bill evenly.If each person paid $13 then what was the total bill?    
            int billOne = 13;
            int billTwo = 13;
            int billThree = 13;
            int billFour = 13;
            int total = billOne + billTwo + billThree + billFour;
            Console.WriteLine(billOne + billTwo + billThree + billFour);

            Console.WriteLine(" Customer () paid $13 part of the overall total of $");
            string friend = Console.ReadLine();
            Console.WriteLine("Customer () paid $13 part of the overall total of $");
            string friendOne = Console.ReadLine();
            Console.WriteLine("Customer () paid $13 part of the overall total of $");
            string friendTwo = Console.ReadLine();
            Console.WriteLine("Customer () paid $13 part of the overall total of $?");          
            string friendThree = Console.ReadLine();
        
            Console.WriteLine("{0} needs {1} needs {2} needs {3} needs {4} needs. ",friend, friendOne, friendTwo, friendThree);




        }
    }
}
